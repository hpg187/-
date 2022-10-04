using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SO_SY_MA_Storage", menuName = "��ũ���ͺ� �߰�/_SY_MA_Storage")]
public class SC_SY_MA_Storage : ScriptableObject
{
    public static SC_SY_MA_Storage __Storage = null;
    

    public static GameObject OB_SY_DB = null;
    public static SC_SY_DB_Manager OB_SY_DB_SCRIPT = null;
    public static GameObject OB_UI = null;
    public static SC_UI_Manager OB_UI_SCRIPT = null;
    public static GameObject OB_AN = null;
    // public static SC_AN_Manager OB_AN_SCRIPT = null;
    public static GameObject OB_SF = null;
    public static SC_SF_Manager OB_SF_SCRIPT = null;
    public static GameObject OB_EV = null;
    public static SC_EV_Manager OB_EV_SCRIPT = null;
    public static GameObject OB_SD = null;
    public static SC_SD_Manager OB_SD_SCRIPT = null;


    public static GameObject OB_MainCameraBody = null;
    public static SC_EV_CA_BodyMagnet OB_MainCameraBody_SCRIPT = null;
    public static GameObject OB_MainCameraHead = null;
    public static Camera OB_MainCameraHead_CAMERA = null;
    public static SC_EV_CA_Thing OB_MainCameraThing_SCRIPT = null;
    public static GameObject OB_MainCameraFreePoint = null;

    


    public static GameObject OB_MouseColliderManager = null;
    public static GameObject OB_MouseTouchCollider = null;
    public static GameObject OB_MouseChooseCollider = null;
    public static GameObject OB_MouseAttachCollider = null;
    public static GameObject OB_MouseDetachCollider = null;
    public static GameObject OB_MouseDragCollider = null;

    // public static List<GameObject> OB_MouseTouchCollider_List = null;
    // public static List<GameObject> OB_MouseChooseCollider_List = null;
    // public static List<GameObject> OB_MouseAttachCollider_List = null;
    // public static List<GameObject> OB_MouseDetachCollider_List = null;
    // public static List<GameObject> OB_MouseDragCollider_List = null;

    public static GameObject OB_MouseTouchCollidingPart = null;
    public static GameObject OB_MouseTouchCollidingCenter = null;
    public static GameObject OB_MouseChooseCollidingPart = null;
    public static GameObject OB_MouseChooseCollidingCenter = null;
    public static GameObject OB_MouseAttachCollidingPart = null;
    public static GameObject OB_MouseAttachCollidingCenter = null;
    public static GameObject OB_MouseDetachCollidingPart = null;
    public static GameObject OB_MouseDetachCollidingCenter = null;

    public static GameObject OB_MouseCollidingObject = null; // ��ǥ



    public static RaycastHit RH_AlwaysRaycastHit;

    // SY 1<<4
    // EV 1<<6 | 1<< 7
    // ST 1<<8 | 1<<9 | 1<<10 | 1<<11 | 1<<12 | 1<<13 | 1<<14 | 1<<15
    // SF 1<<16 | 1<<17 | 1<<18 | 1<<19
    // PT 1<<20 | 1<<21
    // HM 1<<22 | 1<<23
    // AN 1<<24 | 1<<25 | 1<<26 | 1<<27

    






    public static int RO_Number;

    public static int LogInUserStatSerial;


    [SerializeField]
    // public List<string> RO_List;
    

    public List<GameObject> EV_PR_MSTCCL_Prefeb = new List<GameObject>();
    public List<GameObject> EV_PR_MSCHCL_Prefeb = new List<GameObject>();    
    public List<GameObject> EV_PR_MSATCL_Prefeb = new List<GameObject>();
    public List<GameObject> EV_PR_MSDTCL_Prefeb = new List<GameObject>();
    public List<GameObject> EV_PR_MSDGCL_Prefeb = new List<GameObject>();

    public List<GameObject> UI_AccountMenu_ProfileMin_Prefeb = new List<GameObject>();


    public List<GameObject> UI_DialogueScr_CharDef_Prefeb = new List<GameObject>();
    public List<GameObject> UI_DialogueScr_CharGather_Prefeb = new List<GameObject>();

    public List<GameObject> ST_Food_Prefeb = new List<GameObject>();
    public List<GameObject> ST_Floor_Prefeb = new List<GameObject>();
    public List<GameObject> ST_Wall_Prefeb = new List<GameObject>();
    public List<GameObject> AN_Moose_Prefeb = new List<GameObject>();

    public List<GameObject> UI_PopCheck_Prefeb = new List<GameObject>();
    public List<Sprite> UI_UserIcon_Prefeb = new List<Sprite>();

    public List<ScriptableObject> AN_CO_Status_Prefeb = new List<ScriptableObject>();

    
    public List<string> UI_LoadingExplainSentence_List = new List<string>();

    [TextArea]
    public List<string> UI_DialogueSentence_List = new List<string>();
    







    public delegate int FuncCountRemb(int ld_a);


    // public static string RO_Name;

    //&_& ������ �߰� �� ����
    /*
    public enum EM_OB
    {
        OB_SY_DB_Manager,
        OB_UI,
        OB_AN,
        OB_EV
    }
    */


    void Awake()
    {
    }
    



    public static Transform FindCenterByDepth(int pm_a, Transform pm_b)
    {
        Transform lc_a = pm_b;
        for(int lc_b = 0; lc_b<pm_a; lc_b++)
        {
            lc_a = lc_a.parent;
        }
        return lc_a;
    }


    public static string Construe_StringWord(string pm_a)
    {
        string lc_a = "";

        switch(pm_a)
        {
            case "Ưȭ_����":
                lc_a = "Ưȭ�� ������ ���� ��ų ����Ʈ ���ʽ��� �ֽ��ϴ�.";
                break;
            case "Ưȭ_������":
                lc_a = "�������� ü�޺��� �ٸ� �������� ����ϸ� Ű���� �մϴ�.";
                break;
            case "Ưȭ_���":
                lc_a = "����� ������ �������� Ű�� �� �ֽ��ϴ�.";
                break;
            case "Ưȭ_����":
                lc_a = "������ ���� �ۿ��� ������ �� ���� ������ �� �ֽ��ϴ�.";
                break;
            case "Ưȭ_������":
                lc_a = "�������� ������ ���� �� ������ Ű��⵵ �������� Ű��⵵ �մϴ�.";
                break;
            case "����_�輺��":
                lc_a = "<sprite=4> ������ ������ ��..�ٴ� ��� ������ �л��Դϴ�.";
                break;
            case "����_�÷��":
                lc_a = "<sprite=5> ����� ������ȣ ��ȸ�� ����..���� ������ ��� �����Դϴ�.";
                break;
            case "����_���Ͽ�":
                lc_a = "<sprite=6> �ٻ� �ϻ󿡼��� �Ҽ��� �ູ�� ã�Ƴ��� �л��Դϴ�";
                break;
            case "����_������":
                lc_a = "<sprite=7> ��ĥ������ ���常ŭ��.. ���常 ������ �����Դϴ�.";
                break;
            case "����_�ڱ�":
                lc_a = "<sprite=0> ���ǿ����� �׷���, �� ���ӿ����� ���� �߿��ؿ�.. �Ф�";
                break;
            case "����_�ڰ�":
                lc_a = "<sprite=1> ���� ����Ʈ�� ��Ƽ�, ���ο� �Ծ� �ڰ��� ��������!";
                break;
            case "����_����":
                lc_a = "<sprite=2> ������, ��ų�� ����ϴ� ���� �ʿ��� ���̿���..!";
                break;
            case "����_��":
                lc_a = "<sprite=3> �� ����Ʈ�� ��Ƽ� ���ο� ��ų�� �����ϼ���!";
                break;
            default:
                break;
            }

        return lc_a;
    }


    public static int Construe_FormThingKind(GameObject pm_a)
    {
        if(pm_a != null)
        {
            if(pm_a.GetComponent<SC_ST_Floor_AL_Thing>() != null)
            {
                return 201;
            }
            else if(pm_a.GetComponent<SC_SF_Food_AL>() != null)
            {
                return 301;
            }
            else if(pm_a.GetComponent<SC_SF_AL_Thing>() != null)
            {
                return 300;
            }
            else if(pm_a.GetComponent<SC_AN_AL_Thing>() != null)
            {
                return 600;
            }
            else
            {
                return -1;
            }
        }
        return -1;
    }


}
