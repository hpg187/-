using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_EV_CA_Thing : MonoBehaviour
{
    public Transform ch_Body;
    public Transform ch_Root;
    public Transform ch_Target;
    public Transform ch_Leader;
    public Transform ch_Other;
    public Transform AttachTarget; //!_! ch_Leader(특히 ch_Target)가 따라다닐 외부 오브젝트

    public float TargetFixedDistance; //!_! 타겟과의 고정 거리
    public float TargetFixedRotation;

    public Coroutine MoveBodyMagnet_Doing;

    public SC_EV_CA_BodyMagnet BodyMagnet_SCRIPT;
    public float TargetBodyDistance = 0f; //!_! Body 오브젝트와의 거리, 이는 여기서는 그저 저장용이되 Body 오브젝트의 스크립트에서 주로 변경하여 이용함


    public Coroutine Update_Doing;

    public int ThisIsMainThing = -1;


    void Awake()
    {
        ch_Root.LookAt(ch_Target);
        ch_Target.rotation = ch_Root.rotation;
        SetLeader(ch_Target);

        if(ThisIsMainThing > 0)
        {
            SC_SY_MA_Storage.OB_MainCameraThing_SCRIPT = transform.GetComponent<SC_EV_CA_Thing>();
        }

    }


    void Start()
    {
        Update_Doing = StartCoroutine(Update_Going());
    }


    IEnumerator Update_Going()
    {
        while(true)
        {
            // deltaTime 없음!
            MoveBodyMagnetTry();

            yield return null;
        }        
    }



    public void MoveBodyMagnetTry()
    {
        if (MoveBodyMagnet_Doing != null)
        {
            StopCoroutine(MoveBodyMagnet_Doing);
        }

        if (ch_Body != null)
        {
            MoveBodyMagnet_Doing = StartCoroutine(MoveBodyMagnet_Going());
        }
    }



    IEnumerator MoveBodyMagnet_Going()
    {
        while (true)
        {
            if (BodyMagnet_SCRIPT == null && ch_Body != null) //!_! 여기서 2번째 조건은 이미 Update에서 동일하게 사용하므로 없어도 됨
            {
                BodyMagnet_SCRIPT = ch_Body.GetComponent<SC_EV_CA_BodyMagnet>(); //*_* 이미 BodyMagnet에서 적당히 Component를 전달해주는 것 같은데, 이 식이 필요할지 점검 필요
            }
                if (AttachTarget != null) //!_! 02_01_따라다닐 포지션 타겟이 있으면
                {
                    ch_Leader.position = AttachTarget.position;
                }                
            yield return null;
        }
    }





    public void SetLeader(Transform pm_a)
    {
        ch_Root.parent = transform;
        ch_Target.parent = transform;
        ch_Root.parent = pm_a;
        ch_Target.parent = pm_a;
        ch_Leader = pm_a;
        ch_Other = ch_Leader.GetChild(0);
    }






}