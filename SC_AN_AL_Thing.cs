using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using System;

public class SC_AN_AL_Thing : MonoBehaviour
{
    [SerializeField]
    public DateTime Stat_UnFlu_BirthDay; // 절대나이 생일
    [Space]
    public float Stat_Fluid_AgeBody_Remain = -1; // 육체나이
    public float Stat_Fluid_AgeBody_Attain = -1;
    public float Stat_UnFlu_AgeBody_Grow = -1;
    public float Stat_UnFlu_AgeBody_Max = -1;
    [Space]
    public float Stat_Fluid_SenseWatch_Remain = -1; // 시력
    public float Stat_Fluid_SenseWatch_Attain = -1;
    [Space]
    public float Stat_Fluid_SenseHear_Remain = -1; // 청력
    public float Stat_Fluid_SenseHear_Attain = -1;
    [Space]
    public float Stat_Fluid_SenseSmell_Remain = -1; // 후력
    public float Stat_Fluid_SenseSmell_Attain = -1;
    [Space]
    [Space]
    public float Stat_Fluid_Health_Remain = -1; // 건강
    public float Stat_Fluid_Health_Attain = -1;
    public float Stat_UnFlu_Health_Min = -1;
    public float Stat_UnFlu_Health_Grow = -1;
    public float Stat_UnFlu_Health_Max = -1;
    [Space]
    public float Stat_Fluid_Dignity_Remain = -1; // 위엄
    public float Stat_Fluid_Dignity_Attain = -1;
    public float Stat_UnFlu_Dignity_Min = -1;
    public float Stat_UnFlu_Dignity_Grow = -1;
    public float Stat_UnFlu_Dignity_Max = -1;
    [Space]
    public float Stat_Fluid_Stamina_Remain; // 스태미나
    public float Stat_Fluid_Endurance_Remain = -1; // 지구력
    public float Stat_Fluid_Endurance_Attain = -1;
    public float Stat_UnFlu_Endurance_Min = -1;
    public float Stat_UnFlu_Endurance_Grow = -1;
    public float Stat_UnFlu_Endurance_Max = -1;
    [Space]
    public float Stat_Fluid_RobustCrash_Remain = -1; // 충돌방어력
    public float Stat_Fluid_RobustCrash_Attain = -1;
    public float Stat_UnFlu_RobustCrash_Min = -1;
    public float Stat_UnFlu_RobustCrash_Grow = -1;
    public float Stat_UnFlu_RobustCrash_Max = -1;
    [Space]
    public float Stat_Fluid_RobustPierce_Remain = -1; // 관통방어력
    public float Stat_Fluid_RobustPierce_Attain = -1;
    public float Stat_UnFlu_RobustPierce_Min = -1;
    public float Stat_UnFlu_RobustPierce_Grow = -1;
    public float Stat_UnFlu_RobustPierce_Max = -1;
    [Space]
    public float Stat_Fluid_SturdyFlesh_Remain = -1; // 피부체력
    public float Stat_Fluid_SturdyFlesh_Attain = -1;
    public float Stat_UnFlu_SturdyFlesh_Min = -1;
    public float Stat_UnFlu_SturdyFlesh_Grow = -1;
    public float Stat_UnFlu_SturdyFlesh_Max = -1;
    [Space]
    public float Stat_Fluid_SturdyGut_Remain = -1; // 체내체력
    public float Stat_Fluid_SturdyGut_Attain = -1;
    public float Stat_UnFlu_SturdyGut_Min = -1;
    public float Stat_UnFlu_SturdyGut_Grow = -1;
    public float Stat_UnFlu_SturdyGut_Max = -1;
    [Space]
    public float Stat_Fluid_Immunity_Remain = -1; // 면역력
    public float Stat_Fluid_Immunity_Attain = -1;
    public float Stat_UnFlu_Immunity_Min = -1;
    public float Stat_UnFlu_Immunity_Grow = -1;
    public float Stat_UnFlu_Immunity_Max = -1;
    [Space]
    [Space]
    public float Stat_Fluid_Defence_Remain = -1; // 경계성
    public float Stat_Fluid_Defence_Attain = -1;
    public float Stat_UnFlu_Defence_Min = -1;
    public float Stat_UnFlu_Defence_Grow = -1;
    public float Stat_UnFlu_Defence_Max = -1;
    [Space]
    public float Stat_Fluid_Offence_Remain = -1; // 공격성
    public float Stat_Fluid_Offence_Attain = -1;
    public float Stat_UnFlu_Offence_Min = -1;
    public float Stat_UnFlu_Offence_Grow = -1;
    public float Stat_UnFlu_Offence_Max = -1;
    [Space]
    public float Stat_Fluid_Threat_Remain = -1; // 위협
    public float Stat_Fluid_Threat_Attain = -1;
    public float Stat_UnFlu_Threat_Min = -1;
    public float Stat_UnFlu_Threat_Grow = -1;
    public float Stat_UnFlu_Threat_Max = -1;
    [Space]
    public float Stat_Fluid_HarmCrash_Remain = -1; // 충돌피해량
    public float Stat_Fluid_HarmCrash_Attain = -1;
    public float Stat_UnFlu_HarmCrash_Min = -1;
    public float Stat_UnFlu_HarmCrash_Grow = -1;
    public float Stat_UnFlu_HarmCrash_Max = -1;
    [Space]
    public float Stat_Fluid_HarmPierce_Remain = -1; // 관통피해량
    public float Stat_Fluid_HarmPierce_Attain = -1;
    public float Stat_UnFlu_HarmPierce_Min = -1;
    public float Stat_UnFlu_HarmPierce_Grow = -1;
    public float Stat_UnFlu_HarmPierce_Max = -1;
    [Space]
    public float Stat_Fluid_Rush_Remain = -1; // 돌진속도
    public float Stat_Fluid_Rush_Attain = -1;
    public float Stat_UnFlu_Rush_Min = -1;
    public float Stat_UnFlu_Rush_Grow = -1;
    public float Stat_UnFlu_Rush_Max = -1;
    [Space]
    public float Stat_Fluid_React_Remain = -1; // 반응속도
    public float Stat_Fluid_React_Attain = -1;
    public float Stat_UnFlu_React_Min = -1;
    public float Stat_UnFlu_React_Grow = -1;
    public float Stat_UnFlu_React_Max = -1;
    [Space]
    public float Stat_Fluid_Walking_Remain = -1; // 걷기속도
    public float Stat_Fluid_Walking_Attain = -1;
    public float Stat_UnFlu_Walking_Min = -1;
    public float Stat_UnFlu_Walking_Grow = -1;
    public float Stat_UnFlu_Walking_Max = -1;
    [Space]
    [Space]
    public float Stat_Fluid_Physique_Remain = -1; // 몸집
    public float Stat_Fluid_Physique_Attain = -1;
    public float Stat_UnFlu_Physique_Min = -1;
    public float Stat_UnFlu_Physique_Grow = -1;
    public float Stat_UnFlu_Physique_Max = -1;
    [Space]
    public float Stat_Fluid_Palate_Remain = -1; // 식성
    public float Stat_Fluid_Palate_Attain = -1;
    public float Stat_UnFlu_Palate_Min = -1;
    public float Stat_UnFlu_Palate_Grow = -1;
    public float Stat_UnFlu_Palate_Max = -1;
    [Space]
    public float Stat_Fluid_EatStomach_Remain; // 섭취 위 보존량
    public float Stat_Fluid_Intake_Remain = -1; // 식사량
    public float Stat_Fluid_Intake_Attain = -1;
    public float Stat_UnFlu_Intake_Min = -1;
    public float Stat_UnFlu_Intake_Grow = -1;
    public float Stat_UnFlu_Intake_Max = -1;
    [Space]
    public float Stat_Fluid_EatMouth_Remain; // 섭취 입 보존량
    public float Stat_Fluid_Gulp_Remain = -1; // 한입량
    public float Stat_Fluid_Gulp_Attain = -1;
    public float Stat_UnFlu_Gulp_Min = -1;
    public float Stat_UnFlu_Gulp_Grow = -1;
    public float Stat_UnFlu_Gulp_Max = -1;
    [Space]
    public float Stat_Fluid_Chomp_Remain = -1; // 씹기속도
    public float Stat_Fluid_Chomp_Attain = -1;
    public float Stat_UnFlu_Chomp_Min = -1;
    public float Stat_UnFlu_Chomp_Grow = -1;
    public float Stat_UnFlu_Chomp_Max = -1;
    [Space]
    public float Stat_Fluid_Intestine_Remain = -1; // 소화속도
    public float Stat_Fluid_Intestine_Attain = -1;
    public float Stat_UnFlu_Intestine_Min = -1;
    public float Stat_UnFlu_Intestine_Grow = -1;
    public float Stat_UnFlu_Intestine_Max = -1;
    [Space]
    public float Stat_Fluid_Digest_Remain = -1; // 소화효율
    public float Stat_Fluid_Digest_Attain = -1;
    public float Stat_UnFlu_Digest_Min = -1;
    public float Stat_UnFlu_Digest_Grow = -1;
    public float Stat_UnFlu_Digest_Max = -1;
    [Space]
    public float Stat_Fluid_Bowel_Remain = -1; // 배변
    public float Stat_Fluid_Bowel_Attain = -1;
    public float Stat_UnFlu_Bowel_Min = -1;
    public float Stat_UnFlu_Bowel_Grow = -1;
    public float Stat_UnFlu_Bowel_Max = -1;
    [Space]
    public float Stat_Fluid_Calorific_Remain = -1; // 열량
    public float Stat_Fluid_Calorific_Attain = -1;
    public float Stat_UnFlu_Calorific_Min = -1;
    public float Stat_UnFlu_Calorific_Grow = -1;
    public float Stat_UnFlu_Calorific_Max = -1;
    [Space]
    [Space]
    public float Stat_Fluid_BodyHeat_Remain = -1; // 체온
    public float Stat_Fluid_BodyHeat_Attain = -1;
    public float Stat_UnFlu_BodyHeat_Min = -1;
    public float Stat_UnFlu_BodyHeat_Inc = -1;
    public float Stat_UnFlu_BodyHeat_Max = -1;
    public float Stat_UnFlu_BodyHeat_Dec = -1;
    [Space]
    public float Stat_Fluid_Tired_Remain = -1; // 피로
    public float Stat_Fluid_Tired_Attain = -1;
    public float Stat_UnFlu_Tired_Min = -1;
    public float Stat_UnFlu_Tired_Grow = -1;
    public float Stat_UnFlu_Tired_Max = -1;
    [Space]
    public float Stat_Fluid_Stress_Remain = -1; // 스트레스
    public float Stat_Fluid_Stress_Attain = -1;
    public float Stat_UnFlu_Stress_Min = -1;
    public float Stat_UnFlu_Stress_Grow = -1;
    public float Stat_UnFlu_Stress_Max = -1;
    [Space]
    public float Stat_Fluid_Slumber_Remain = -1; // 수면
    // 활동시간 변수 없음
    [Space]
    public float Stat_Fluid_CleanSelf_Remain = -1; // 청결
    [Space]
    public float Stat_Fluid_Nature_Remain = -1; // 야생본능
    public float Stat_Fluid_Nature_Attain = -1;
    public float Stat_UnFlu_Nature_Min = -1;
    public float Stat_UnFlu_Nature_Grow = -1;
    public float Stat_UnFlu_Nature_Max = -1;
    [Space]
    public float Stat_Fluid_IndepPursuit_Remain = -1; // 자립성질
    public float Stat_Fluid_IndepPursuit_Attain = -1;
    public float Stat_UnFlu_IndepPursuit_Min = -1;
    public float Stat_UnFlu_IndepPursuit_Grow = -1;
    public float Stat_UnFlu_IndepPursuit_Max = -1;
    [Space]
    public float Stat_Fluid_IndepCapacity_Remain = -1; // 자립능력
    public float Stat_Fluid_IndepCapacity_Attain = -1;
    public float Stat_UnFlu_IndepCapacity_Min = -1;
    public float Stat_UnFlu_IndepCapacity_Grow = -1;
    public float Stat_UnFlu_IndepCapacity_Max = -1;
    [Space]
    [Space]
    public float Stat_Fluid_Adapt_Remain = -1; // 적응
    public float Stat_Fluid_Adapt_Attain = -1;
    public float Stat_UnFlu_Adapt_Min = -1;
    public float Stat_UnFlu_Adapt_Grow = -1;
    public float Stat_UnFlu_Adapt_Max = -1;
    [Space]
    public float Stat_Fluid_Civilization_Remain = -1; // 문물
    public float Stat_Fluid_Civilization_Attain = -1;
    public float Stat_UnFlu_Civilization_Min = -1;
    public float Stat_UnFlu_Civilization_Grow = -1;
    public float Stat_UnFlu_Civilization_Max = -1;
    [Space]
    public float Stat_Fluid_FoodChain_Min = -1; // 천적친화
    public float Stat_Fluid_FoodChain_Max = -1;
    [Space]
    public float Stat_Fluid_Social_Remain = -1; // 사교
    public float Stat_Fluid_Social_Attain = -1;
    public float Stat_UnFlu_Social_Min = -1;
    public float Stat_UnFlu_Social_Grow = -1;
    public float Stat_UnFlu_Social_Max = -1;
    [Space]
    public float Stat_Fluid_Loyalty_Remain = -1; // 복종
    public float Stat_Fluid_Loyalty_Attain = -1;
    public float Stat_UnFlu_Loyalty_Min = -1;
    public float Stat_UnFlu_Loyalty_Grow = -1;
    public float Stat_UnFlu_Loyalty_Max = -1;
    [Space]
    public float Stat_Fluid_Discipline_Remain = -1; // 기강
    public float Stat_Fluid_Discipline_Attain = -1;
    public float Stat_UnFlu_Discipline_Min = -1;
    public float Stat_UnFlu_Discipline_Grow = -1;
    public float Stat_UnFlu_Discipline_Max = -1;
    [Space]
    public float Stat_Fluid_Possession_Remain = -1; // 소유
    public float Stat_Fluid_Possession_Attain = -1;
    public float Stat_UnFlu_Possession_Min = -1;
    public float Stat_UnFlu_Possession_Grow = -1;
    public float Stat_UnFlu_Possession_Max = -1;
    [Space]
    public float Stat_Fluid_Security_Remain = -1; // 안보
    public float Stat_Fluid_Security_Attain = -1;
    public float Stat_UnFlu_Security_Min = -1;
    public float Stat_UnFlu_Security_Grow = -1;
    public float Stat_UnFlu_Security_Max = -1;
    [Space]
    public float Stat_Fluid_Escapist_Remain = -1; // 탈출
    public float Stat_Fluid_Escapist_Attain = -1;
    public float Stat_UnFlu_Escapist_Min = -1;
    public float Stat_UnFlu_Escapist_Grow = -1;
    public float Stat_UnFlu_Escapist_Max = -1;
    [Space]
    [Space]
    public float Stat_Fluid_Curiosity_Remain = -1; // 궁금
    public float Stat_Fluid_Curiosity_Attain = -1;
    public float Stat_UnFlu_Curiosity_Min = -1;
    public float Stat_UnFlu_Curiosity_Grow = -1;
    public float Stat_UnFlu_Curiosity_Max = -1;
    [Space]
    public float Stat_Fluid_Looze_Remain = 1-1; // 유휴활동 남은시간
    public float Stat_Fluid_Bubbly_Remain = -1; // 발랄
    public float Stat_Fluid_Bubbly_Attain = -1;
    public float Stat_UnFlu_Bubbly_Min = -1;
    public float Stat_UnFlu_Bubbly_Grow = -1;
    public float Stat_UnFlu_Bubbly_Max = -1;
    [Space]
    public float Stat_Fluid_Witty_Remain = -1; // 재치
    public float Stat_Fluid_Witty_Attain = -1;
    public float Stat_UnFlu_Witty_Min = -1;
    public float Stat_UnFlu_Witty_Grow = -1;
    public float Stat_UnFlu_Witty_Max = -1;
    [Space]
    public float Stat_Fluid_Wisely_Remain = -1; // 지혜
    public float Stat_Fluid_Wisely_Attain = -1;
    public float Stat_UnFlu_Wisely_Min = -1;
    public float Stat_UnFlu_Wisely_Grow = -1;
    public float Stat_UnFlu_Wisely_Max = -1;
    [Space]
    public float Stat_Fluid_Knowledge_Remain = -1; // 지식
    public float Stat_Fluid_Knowledge_Attain = -1;
    public float Stat_UnFlu_Knowledge_Min = -1;
    public float Stat_UnFlu_Knowledge_Grow = -1;
    public float Stat_UnFlu_Knowledge_Max = -1;
    [Space]
    public float Stat_Fluid_Activity_Remain = -1; // 실천
    public float Stat_Fluid_Activity_Attain = -1;
    public float Stat_UnFlu_Activity_Min = -1;
    public float Stat_UnFlu_Activity_Grow = -1;
    public float Stat_UnFlu_Activity_Max = -1;
    [Space]
    public float Stat_Fluid_Sincere_Remain = -1; // 성실
    public float Stat_Fluid_Sincere_Attain = -1;
    public float Stat_UnFlu_Sincere_Min = -1;
    public float Stat_UnFlu_Sincere_Grow = -1;
    public float Stat_UnFlu_Sincere_Max = -1;
    [Space]
    public float Stat_Fluid_Patient_Remain = -1; // 끈기
    public float Stat_Fluid_Patient_Attain = -1;
    public float Stat_UnFlu_Patient_Min = -1;
    public float Stat_UnFlu_Patient_Grow = -1;
    public float Stat_UnFlu_Patient_Max = -1;
    [Space]
    public float Stat_Fluid_Composure_Remain = -1; // 침착
    public float Stat_Fluid_Composure_Attain = -1;
    public float Stat_UnFlu_Composure_Min = -1;
    public float Stat_UnFlu_Composure_Grow = -1;
    public float Stat_UnFlu_Composure_Max = -1;
    [Space]
    [Space]
    [Space]
    /* 대충 틀
     
    public float Stat_Fluid__Remain = -1; // 
    public float Stat_Fluid__Attain = -1;
    public float Stat_UnFlu__Min = -1;
    public float Stat_UnFlu__Grow = -1;
    public float Stat_UnFlu__Max = -1;

    public float Stat_Fluid__Remain = -1; // 
    public float Stat_Fluid__Attain = -1;
    public float Stat_UnFlu__Min = -1;
    public float Stat_UnFlu__Grow = -1;
    public float Stat_UnFlu__Max = -1;
    
     */




    public string ThingName_Poss = "-1";
    public string ThingKind_Poss = "-1";
    
    public string ThingName_Text = "동물";

    public int ThingPrefeb_idx = -1;
    public int Owner_idx = -1;
    public int ProfileIcon_AL_idx = -1;
    
    public GameObject ThingPrefeb_Poss;
    public GameObject Owner_Poss;
    public Sprite ProfileIcon_Common_Poss;

    public int ThingPrice_Money = -1;
    public int ThingPrice_Mana = -1;
    public int ThingPrice_Fame = -1;
    public int ThingPrice_Rear = -1;
    


    public Animation Animater; //*_* 애니메이터가 추가되면 다시 고려해봐야 함

    public NavMeshAgent NaviAgent;


    public SC_AL_ScheduleRemember Schedule_SCRIPT;


    public Vector3 MoveVectorRelative = new Vector3(0f, 0f, 0f);
    public Vector3 Destination;


    public Coroutine Update_Doing;


    public string AnimationFrontName = "Rabbit_";

    

    public float increasePoint = 0;



    private void Awake()
    {
        Animater = transform.GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetComponent<Animation>();
        NaviAgent = transform.GetComponent<NavMeshAgent>();
        NaviAgent.updateRotation = false;
    }

    void Start()
    {
        Update_Doing = StartCoroutine(Update_Going());
    }

    
    IEnumerator Update_Going()
    {
        while(true)
        {
            if(Time.deltaTime > 0)
            {
                increasePoint += Time.deltaTime;

                if(increasePoint >= 3)
                {
                    increasePoint -= 3;
                    SC_SY_DB_Manager.US_List[Owner_idx].RearHave += 1;
                }



                Stat_Fluid_EatStomach_Remain = Mathf.Max(Stat_Fluid_EatStomach_Remain - Stat_Fluid_Intestine_Remain * Time.deltaTime, 0);
                Stat_Fluid_Looze_Remain = Mathf.Max(Stat_Fluid_Looze_Remain - 1.0f * Time.deltaTime, 0);


                if(Stat_Fluid_Looze_Remain <= 0)
                {
                    if(Schedule_SCRIPT.Schedule_Target.Count <= 0)                
                    {
                        Action_UsualMove();
                        Action_FindBall();
                        /*
                        if(Stat_Fluid_Palate_Attain > (Stat_Fluid_EatStomach_Remain/Stat_Fluid_Intake_Remain))
                        {
                            Action_FindFood();
                        }
                        */
                        if(Stat_Fluid_EatStomach_Remain <= 0)
                        {
                            Action_FindFood();
                        }
                    }

                        Stat_Fluid_Looze_Remain += 10000f / Stat_Fluid_Bubbly_Remain;
                
                }







                if(MoveVectorRelative != new Vector3(0f, 0f, 0f))
                {
                    SetDest(MoveVectorRelative);
                }
                MoveVectorRelative = new Vector3(0f, 0f, 0f);


                


                mmove();
            }

            yield return null;
        }
    }

    




    public bool Action_FindBall()
    {
        if(SC_SY_MA_Storage.OB_SF_SCRIPT.RemainBallList.Count >= 1)
        {
            float lc_b = Mathf.Infinity;
            float lc_d = Mathf.Max(Stat_Fluid_SenseWatch_Remain, 0);
            // float lc_d = Mathf.Max(Stat_Fluid_SenseWatch_Remain, Stat_Fluid_SenseSmell_Remain);
            GameObject lc_c = null;
            for(int lc_a = 0; lc_a < SC_SY_MA_Storage.OB_SF_SCRIPT.RemainBallList.Count; lc_a++)
            {
                if(Vector3.Distance(SC_SY_MA_Storage.OB_SF_SCRIPT.RemainBallList[lc_a].transform.position, transform.position) < lc_b)
                {
                    lc_b = Vector3.Distance(SC_SY_MA_Storage.OB_SF_SCRIPT.RemainBallList[lc_a].transform.position, transform.position);
                    lc_c = SC_SY_MA_Storage.OB_SF_SCRIPT.RemainBallList[lc_a];
                }
            }
            if(lc_b <= lc_d)
            {
                SetDest(lc_c.transform.position);
                return true;
            }
            else
            {
                
                // 대상 음식이 거리 내에 없어서, 탐지 실패!
            }
        }
        return false;
    }


    public bool Action_FindFood()
    {
        if(SC_SY_MA_Storage.OB_SF_SCRIPT.RemainFoodList.Count >= 1)
        {
            float lc_b = Mathf.Infinity;
            float lc_d = Mathf.Max(0, Stat_Fluid_SenseSmell_Remain);
            // float lc_d = Mathf.Max(Stat_Fluid_SenseWatch_Remain, Stat_Fluid_SenseSmell_Remain);
            GameObject lc_c = null;
            for(int lc_a = 0; lc_a < SC_SY_MA_Storage.OB_SF_SCRIPT.RemainFoodList.Count; lc_a++)
            {
                if(Vector3.Distance(SC_SY_MA_Storage.OB_SF_SCRIPT.RemainFoodList[lc_a].transform.position, transform.position) < lc_b)
                {
                    lc_b = Vector3.Distance(SC_SY_MA_Storage.OB_SF_SCRIPT.RemainFoodList[lc_a].transform.position, transform.position);
                    lc_c = SC_SY_MA_Storage.OB_SF_SCRIPT.RemainFoodList[lc_a];
                }
            }
            if(lc_b <= lc_d)
            {
                SetDest(lc_c.transform.position);
                return true;
            }
            else
            {
                
                // 대상 음식이 거리 내에 없어서, 탐지 실패!
            }
        }
        return false;
    }


    public bool Action_UsualMove()
    {
        SetDest(new Vector3(transform.position.x + UnityEngine.Random.Range(-Stat_Fluid_Curiosity_Remain/10000f, Stat_Fluid_Curiosity_Remain/10000f), transform.position.y, transform.position.z + UnityEngine.Random.Range(-Stat_Fluid_Curiosity_Remain/10000f, Stat_Fluid_Curiosity_Remain/10000f)));
        return true;
    }



    public void eatstart()
    {
        Animater.Play(AnimationFrontName+"EatGulpAL");
        Stat_Fluid_EatStomach_Remain += 50f;
    }


    
    public virtual void mmove()
    {
        if(Animater.IsPlaying(AnimationFrontName+"Walk"))
        {
        // var dir = Destination - transform.position;
        var dir = new Vector3(NaviAgent.steeringTarget.x, transform.position.y, NaviAgent.steeringTarget.z) - transform.position;
            if(dir != new Vector3(0f, 0f, 0f))
            {
                transform.forward = dir;
            }
            else
            {

            }
        // transform.position += dir.normalized * Time.deltaTime * 2f;
        }

        if(Vector3.Distance(transform.position, Destination) <= 0.1f) // if(NaviAgent.velocity.magnitude == 0f)
        {
            Animater.Play(AnimationFrontName+"Stand");
            // Animater.Stop();
        }
        
    }


    public virtual void SetDest(Vector3 pm_a)
    {
        NaviAgent.SetDestination(pm_a);
        Destination = pm_a;
        Animater.Play(AnimationFrontName+"Walk");
    }






    private void OnTriggerEnter(Collider other)
    {
        // deltaTime 없음
        if(other.tag == "Food" && (this.tag == "Animal"))
        {
            // 음식량 교환 코드 필요
            /*
            transform.parent.parent.GetComponent<SC_ST_TT_Moose01>().Stat_Fluid_Hungry_Remain += 100;
            other.GetComponent<SC_ST_TT_TestFood>().FoodAmount = Mathf.Max(other.GetComponent<SC_ST_TT_TestFood>().FoodAmount - 100, 0);
            */
        }
    }

    public void Receiving_Keyboard_WS(float pm_a)
    {
        MoveVectorRelative += transform.position+new Vector3(pm_a,0f,0f);
    }

    public void Receiving_Keyboard_AD(float pm_a)
    {
        MoveVectorRelative += transform.position+new Vector3(pm_a,0f,0f);
    }

    public void Receiving_MouseClick_R(float pm_a)
    {
        if(Physics.Raycast(SC_SY_MA_Storage.OB_MainCameraHead_CAMERA.ScreenPointToRay(Input.mousePosition), out SC_SY_MA_Storage.RH_AlwaysRaycastHit))
        {
            SetDest(SC_SY_MA_Storage.RH_AlwaysRaycastHit.point);
        }
    }
}
