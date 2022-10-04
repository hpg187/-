using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SO_SY_MA_Storage", menuName = "스크립터블 추가/_SY_MA_Storage")]
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

    public static GameObject OB_MouseCollidingObject = null; // 대표



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

    //&_& 엑셀에 추가 안 했음
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
            case "특화_설명":
                lc_a = "특화인 동물에 대한 스킬 포인트 보너스가 있습니다.";
                break;
            case "특화_포유류":
                lc_a = "포유류는 체급별로 다른 전략으로 방어하며 키워야 합니다.";
                break;
            case "특화_어류":
                lc_a = "어류는 수족관 내에서만 키울 수 있습니다.";
                break;
            case "특화_조류":
                lc_a = "조류는 새장 밖에만 나가면 집 어디든 도달할 수 있습니다.";
                break;
            case "특화_절지류":
                lc_a = "절지류는 종류에 따라 한 마리씩 키우기도 군단으로 키우기도 합니다.";
                break;
            case "유저_배성준":
                lc_a = "<sprite=4> 동물에 관심이 없..다던 어느 도시의 학생입니다.";
                break;
            case "요정_시루디":
                lc_a = "<sprite=5> 도드람 동물보호 협회의 직원..으로 위장한 어느 요정입니다.";
                break;
            case "유저_윤하영":
                lc_a = "<sprite=6> 바쁜 일상에서도 소소한 행복을 찾아내는 학생입니다";
                break;
            case "요정_차우코":
                lc_a = "<sprite=7> 까칠하지만 심장만큼은.. 심장만 따뜻한 요정입니다.";
                break;
            case "점수_자금":
                lc_a = "<sprite=0> 현실에서도 그렇고, 이 게임에서도 돈이 중요해요.. ㅠㅠ";
                break;
            case "점수_자격":
                lc_a = "<sprite=1> 동물 포인트를 모아서, 새로운 입양 자격을 얻으세요!";
                break;
            case "점수_마나":
                lc_a = "<sprite=2> 마나는, 스킬을 사용하는 데에 필요한 힘이에요..!";
                break;
            case "점수_명성":
                lc_a = "<sprite=3> 명성 포인트를 모아서 새로운 스킬을 습득하세요!";
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
