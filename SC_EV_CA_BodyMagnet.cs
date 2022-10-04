using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_EV_CA_BodyMagnet : SC_AL_AnyKeyInputReceive_Center
{
    
    public Vector3 AccumCameraMovePositionVector = new Vector3(0f,0f,0f);
    public Vector3 AccumCameraMoveRotationVector = new Vector3(0f,0f,0f);
    public int AccumCameraMoveRotationMode = 0;
    public bool AccumCameraMoveBool = false;

    public int MagnetCameraMoveAttitudeMode = -1; //!_! 01 = 일반, 02 = 스토리
    public int[] MagnetCameraMovePositionMode01 = {-1, -1, -1};
    public int[] MagnetCameraMovePositionMode02 = { -1, -1, -1};
    public int[] MagnetCameraMoveRotationMode01 = { -1, -1, -1 };
    public int[] MagnetCameraMoveRotationMode02 = { -1, -1, -1 };
    //!_! 0 = 객체 기준, 1 = 가속형
    //!_! 0-0 = 객체 기준, 1-0 = 등속, 1-1 = 가출급정형, 1-2 = 가출감정형, 1-3 = 급출감정형, 1-4 급출급정형
    //!_! 가감의 정도


    

    public Coroutine ShakeCamera_Doing = null;
    public float ShakeCameraMaintain; //!_! 화면 흔들기에 현재 힘을 유지하는 시간
    public float ShakeCameraRemain; //!_! 화면 흔들기 현재 힘이자 잔여량
    public float ShakeCameraDiscount; //!_! 화면 흔들기 잔여량 감소 계수

    public Transform TargetObjectSet;
    public SC_EV_CA_Thing TargetObjectSet_SCRIPT;



    private void Awake()
    {
        SC_SY_MA_Storage.OB_MainCameraBody = gameObject;
        SC_SY_MA_Storage.OB_MainCameraBody_SCRIPT = transform.GetComponent<SC_EV_CA_BodyMagnet>();
    }

    void Start()
    {
        Update_Doing = StartCoroutine(Update_Going());

        if(TargetObjectSet != null)
        {
            SetFollowObject(TargetObjectSet);
        }

        SC_SY_MA_Storage.OB_UI_SCRIPT.ReceivableObject_MouseClick_Scroll_Set(SC_SY_MA_Storage.OB_MainCameraBody, true);
    }


    IEnumerator Update_Going()
    {
        while(true)
        {
            // deltaTime 없음!

            ShakeCamera_Try();
            AccumCameraMoveFuncReturn();

            yield return null;
        }
    }


    public override void Receiving_MouseClick_Scrolling(float pm_a)
    {
        if(pm_a < 0)
        {
            TargetObjectSet_SCRIPT.TargetBodyDistance = Mathf.Min(TargetObjectSet_SCRIPT.TargetBodyDistance + 1, 20);
        }
        else if(pm_a > 0)
        {
            TargetObjectSet_SCRIPT.TargetBodyDistance = Mathf.Max(TargetObjectSet_SCRIPT.TargetBodyDistance - 1, 0);
        }
    }


    public void AccumCameraMoveFuncReturn()
    {
        transform.position = TargetObjectSet_SCRIPT.ch_Root.position;
        transform.GetChild(0).position = AccumCameraMovePositionVector + transform.position - transform.forward * TargetObjectSet_SCRIPT.TargetBodyDistance;

        switch (MagnetCameraMoveAttitudeMode)
        {
            case 1:
                MagnetCameraMovePositionAccordingtoMode(ref MagnetCameraMovePositionMode01, ref MagnetCameraMoveRotationMode01);
                break;
            case 2:
                MagnetCameraMovePositionAccordingtoMode(ref MagnetCameraMovePositionMode02, ref MagnetCameraMoveRotationMode02);
                break;
            default:
                break;
        }

        transform.rotation = TargetObjectSet_SCRIPT.ch_Root.rotation;

        AccumCameraMoveBool = false;

        AccumCameraMovePositionVector = new Vector3(0f, 0f, 0f);
        AccumCameraMoveRotationVector = new Vector3(0f, 0f, 0f);
    }




    public void MagnetCameraMovePositionAccordingtoMode(ref int[] pm_a, ref int[] pm_b)
    {
        switch (pm_a[0] * 100 + pm_a[1])
        {
            case 0:
                SC_SY_MA_Storage.OB_MainCameraHead.transform.position = transform.GetChild(0).position;
                break;
            case 100:
                if (Vector3.Distance(SC_SY_MA_Storage.OB_MainCameraHead.transform.position, transform.GetChild(0).position) > pm_a[2] / 1000000f)
                {
                    SC_SY_MA_Storage.OB_MainCameraHead.transform.position = (transform.GetChild(0).position - SC_SY_MA_Storage.OB_MainCameraHead.transform.position) * pm_a[2] / 1000000f;
                }
                else
                {
                    SC_SY_MA_Storage.OB_MainCameraHead.transform.position = transform.GetChild(0).position;
                }
                break;
            case 101:
                break;
            case 102:
                break;
            case 103:
                if (Vector3.Distance(SC_SY_MA_Storage.OB_MainCameraHead.transform.position, transform.GetChild(0).position) > 0.001f)
                {
                    
                    SC_SY_MA_Storage.OB_MainCameraHead.transform.position = Vector3.Lerp(SC_SY_MA_Storage.OB_MainCameraHead.transform.position, transform.GetChild(0).position, pm_a[2] / 1000000f);
                }
                else
                {
                    SC_SY_MA_Storage.OB_MainCameraHead.transform.position = transform.GetChild(0).position;
                }
                break;
            case 104:
                break;
            default:
                break;
        }
        
        switch (pm_b[0] * 100 + pm_b[1])
        {
            case 0:                
                SC_SY_MA_Storage.OB_MainCameraHead.transform.rotation = transform.GetChild(0).rotation;
                break;
            case 1: //*_* 아직 그냥 비어잇음!
                SC_SY_MA_Storage.OB_MainCameraHead.transform.rotation = transform.GetChild(0).rotation;
                break;
            default:
                SC_SY_MA_Storage.OB_MainCameraHead.transform.rotation = transform.GetChild(0).rotation;
                break;
        }
    }





    public void SetShakeNormal(float pm_a, float pm_b, float pm_c) //!_! 카메라 흔들기 함수
    {
        ShakeCameraMaintain = Mathf.Max(pm_a,ShakeCameraMaintain);
        ShakeCameraRemain = Mathf.Max(pm_b,ShakeCameraRemain);
        ShakeCameraDiscount = Mathf.Max(pm_c,ShakeCameraDiscount);
        ShakeCamera_Try();
    }

    public void ShakeCamera_Try()
    {
        if(ShakeCamera_Doing == null)
        {
            ShakeCamera_Doing = StartCoroutine(ShakeCamera_Going());
        }
    }


    IEnumerator ShakeCamera_Going()
    {
        while (true)
        {
            if (ShakeCameraDiscount < 0)
            {
                ShakeCameraDiscount = 0;
                ShakeCameraRemain = 0;
                ShakeCameraMaintain = 0;
            }
            else {
                AccumCameraMoveBool = true;

                AccumCameraMoveFuncAddLocalPosition(Mathf.Max(ShakeCameraRemain, 0) * Random.insideUnitSphere);

                if (ShakeCameraMaintain > 0)
                {
                    ShakeCameraMaintain = Mathf.Max(ShakeCameraMaintain - Time.deltaTime, 0);
                }
                else if (ShakeCameraRemain > 0)
                {
                    ShakeCameraRemain = Mathf.Max(ShakeCameraRemain - (Time.deltaTime * ShakeCameraDiscount), 0);
                }
                else
                {
                    break;
                }
            }
            yield return null;
        }

        ShakeCamera_Doing = null;

        yield break;
    }





    public void SetFollowObject(Transform pm_a)
    {
        if(TargetObjectSet_SCRIPT != null)
        {
            TargetObjectSet_SCRIPT.ch_Body = null;
        }
        TargetObjectSet = pm_a;
        TargetObjectSet_SCRIPT = pm_a.GetComponent<SC_EV_CA_Thing>();
        TargetObjectSet_SCRIPT.ch_Body = transform;
        TargetObjectSet_SCRIPT.BodyMagnet_SCRIPT = transform.GetComponent<SC_EV_CA_BodyMagnet>();
        transform.localPosition = new Vector3(0f, 0f, 0f);
        transform.localRotation = new Quaternion(0f, 0f, 0f, 0f);        
    }





    public void AccumCameraMoveFuncAddLocalPosition(Vector3 pm_a)
    {
        AccumCameraMovePositionVector += pm_a;
    }

    public void AccumCameraMoveFuncAddLocalRotation(Vector3 pm_a)
    {
        AccumCameraMoveRotationVector += pm_a;
    }

    


}