using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.Data;
using Mono.Data.SqliteClient;
using System.IO;
using UnityEngine.Networking;



//㎪㎪㎪ 001001
public class CL_TableManager
{
    public char Updated = 'N';
    public int Serial0;
    public int Serial1;
    public int Serial2;
    public string Name;
    public int Kind0;
    public int Kind1;
    public int Kind2;
    public int Kind3;
    public int BuildVersion;
    public DateTime DateRealCreate;
    public int CountSerial;
    public int CountAttribute;
    public int MaxSerial0;
    public int MaxSerial1;
    public int MaxSerial2;
    public int LastSerial0;
    public int LastSerial1;
    public int LastSerial2;
    public int TopicSerial0;
    public int TopicSerial1;
    public int TopicSerial2;

    public CL_TableManager(int pm_Serial0, int pm_Serial1, int pm_Serial2, string pm_Name, int pm_Kind0, int pm_Kind1, int pm_Kind2, int pm_Kind3,
                                int pm_BuildVersion, string pm_DateRealCreate, int pm_CountSerial, int pm_CountAttribute,
                                int pm_MaxSerial0, int pm_MaxSerial1, int pm_MaxSerial2, int pm_LastSerial0, int pm_LastSerial1, int pm_LastSerial2,
                                int pm_TopicSerial0, int pm_TopicSerial1, int pm_TopicSerial2, char pm_Updated = 'N')
    {
        Updated = pm_Updated;
        Serial0 = pm_Serial0;
        Serial1 = pm_Serial1;
        Serial2 = pm_Serial2;
        Name = pm_Name;
        Kind0 = pm_Kind0;
        Kind1 = pm_Kind1;
        Kind2 = pm_Kind2;
        Kind3 = pm_Kind3;
        BuildVersion = pm_BuildVersion;
        DateRealCreate = Convert.ToDateTime(pm_DateRealCreate);
        CountSerial = pm_CountSerial;
        CountAttribute = pm_CountAttribute;
        MaxSerial0 = pm_MaxSerial0;
        MaxSerial1 = pm_MaxSerial1;
        MaxSerial2 = pm_MaxSerial2;
        LastSerial0 = pm_LastSerial0;
        LastSerial1 = pm_LastSerial1;
        LastSerial2 = pm_LastSerial2;
        TopicSerial0 = pm_TopicSerial0;
        TopicSerial1 = pm_TopicSerial1;
        TopicSerial2 = pm_TopicSerial2;
    }

}
//%_% Table_01 테이블 관리

//㎪㎪㎪ 001002
public enum EM_TM
{
    CC_Nothing,
    CC_Count,
    CC_MaxSerial0,
    CC_MaxSerial1,
    CC_MaxSerial2,

    Updated,
    Serial0,
    Serial1,
    Serial2,
    Name,
    Kind0,
    Kind1,
    Kind2,
    Kind3,
    BuildVersion,
    DateRealCreate,
    CountSerial,
    CountAttribute,
    MaxSerial0,
    MaxSerial1,
    MaxSerial2,
    LastSerial0,
    LastSerial1,
    LastSerial2,
    TopicSerial0,
    TopicSerial1,
    TopicSerial2,
}


//㎪㎪㎪ 001001
public class CL_AnimalEncyclopedia
{
    public char Updated = 'N';
    public int Serial0;
    public int Serial1;
    public int Serial2;
    public string Name;
    public int Kind0;
    public int Kind1;
    public int Kind2;
    public int Kind3;
    public int Kind4;
    public int Kind5;
    public int Kind6;
    public int Kind7;
    public int Kind8;
    public int Kind9;
    public int EntityWildGroupAve;
    public int EntityWildGroupErr;
    public int EntityWildMemberAve;
    public int EntityWildMemberErr;
    public int EntityShopGroupAve;
    public int EntityShopGroupErr;
    public int EntityShopMemberAve;
    public int EntityShopMemberErr;
    public int ChildbirthMemberAve;
    public int ChildbirthMemberErr;
    public int ChildbirthTimeManyAve;
    public int ChildbirthTimeManyErr;
    public int ChildbirthTimeLongAve;
    public int ChildbirthTimeLongErr;
    public int ChildbirthAgeMinAve;
    public int ChildbirthAgeMinErr;
    public int ChildbirthAgeMaxAve;
    public int ChildbirthAgeMaxErr;
    public int ChildbirthSuccessAve;
    public int AgeAbsoluteWildAve;
    public int AgeAbsoluteWildRatio;
    public int AgeAbsoluteShopAve;
    public int AgeAbsoluteShopRatio;
    public int AgeAbsoluteSelterAve;
    public int AgeAbsoluteSelterMax;
    public int AgeBodyIncErr;
    public int AgeBodyMaxAve;
    public int AgeBodyMaxErr;
    public int AgeBodyGrowAve;
    public int AgeBodyGrowErr;
    public int HealthMinAve;
    public int HealthMinErr;
    public int HealthGrowAve;
    public int HealthGrowErr;
    public int HealthMaxAve;
    public int HealthMaxErr;
    public int SkinMinAve;
    public int SkinMinErr;
    public int SkinGrowAve;
    public int SkinGrowErr;
    public int SkinMaxAve;
    public int SkinMaxErr;
    public int SkinUsualInc;
    public int SkinStaminaRatioDec;
    public int StaminaMinAve;
    public int StaminaMinErr;
    public int StaminaGrowAve;
    public int StaminaGrowErr;
    public int StaminaMaxAve;
    public int StaminaMaxErr;
    public int StaminaUsualInc;
    public int StaminaAgeBodyAboveDec;
    public int RobustMinAve;
    public int RobustMinErr;
    public int RobustGrowAve;
    public int RobustGrowErr;
    public int RobustMaxAve;
    public int RobustMaxErr;
    public int RobustUsualInc;
    public int RobustSkinRatioDec;
    public int ImmunityMinAve;
    public int ImmunityMinErr;
    public int ImmunityGrowAve;
    public int ImmunityGrowErr;
    public int ImmunityMaxAve;
    public int ImmunityMaxErr;
    public int ImmunityUsualInc;
    public int ImmunityHealthRatioDec;
    public int OffenceMinAve;
    public int OffenceMinErr;
    public int OffenceGrowAve;
    public int OffenceGrowErr;
    public int OffenceMaxAve;
    public int OffenceMaxErr;
    public int OffenceHealthRatioInc;
    public int OffenceHealthRatioDec;
    public int PierceMinAve;
    public int PierceMinErr;
    public int PierceGrowAve;
    public int PierceGrowErr;
    public int PierceMaxAve;
    public int PierceMaxErr;
    public int PermeateMinAve;
    public int PermeateMinErr;
    public int PermeateGrowAve;
    public int PermeateGrowErr;
    public int PermeateMaxAve;
    public int PermeateMaxErr;
    public int PermeateKind1;
    public int PermeateKind2;
    public int PermeateKind3;
    public int ToleranceMinAve;
    public int ToleranceMinErr;
    public int ToleranceGrowAve;
    public int ToleranceGrowErr;
    public int ToleranceMaxAve;
    public int ToleranceMaxErr;
    public int ToleranceKind1;
    public int ToleranceKind2;
    public int ToleranceKind3;
    public int RushMinAve;
    public int RushMinErr;
    public int RushGrowAve;
    public int RushGrowErr;
    public int RushMaxAve;
    public int RushMaxErr;
    public int ReactMinAve;
    public int ReactMinErr;
    public int ReactGrowAve;
    public int ReactGrowErr;
    public int ReactMaxAve;
    public int ReactMaxErr;
    public int WittyMinAve;
    public int WittyMinErr;
    public int WittyGrowAve;
    public int WittyGrowErr;
    public int WittyMaxAve;
    public int WittyMaxErr;
    public int PhysiqueMinAve;
    public int PhysiqueMinErr;
    public int PhysiqueGrowAve;
    public int PhysiqueGrowErr;
    public int PhysiqueMaxAve;
    public int PhysiqueMaxErr;
    public int PalateMinAve;
    public int PalateMinErr;
    public int PalateGrowAve;
    public int PalateGrowErr;
    public int PalateMaxAve;
    public int PalateMaxErr;
    public int DigestMinAve;
    public int DigestMinErr;
    public int DigestGrowAve;
    public int DigestGrowErr;
    public int DigestMaxAve;
    public int DigestMaxErr;
    public int CuriosityMinAve;
    public int CuriosityMinErr;
    public int CuriosityGrowAve;
    public int CuriosityGrowErr;
    public int CuriosityMaxAve;
    public int CuriosityMaxErr;
    public int ActiveMinAve;
    public int ActiveMinErr;
    public int ActiveGrowAve;
    public int ActiveGrowErr;
    public int ActiveMaxAve;
    public int ActiveMaxErr;
    public int BubblyMinAve;
    public int BubblyMinErr;
    public int BubblyGrowAve;
    public int BubblyGrowErr;
    public int BubblyMaxAve;
    public int BubblyMaxErr;
    public int PatientMinAve;
    public int PatientMinErr;
    public int PatientGrowAve;
    public int PatientGrowErr;
    public int PatientMaxAve;
    public int PatientMaxErr;
    public int ComposureMinAve;
    public int ComposureMinErr;
    public int ComposureGrowAve;
    public int ComposureGrowErr;
    public int ComposureMaxAve;
    public int ComposureMaxErr;
    public int SincereMinAve;
    public int SincereMinErr;
    public int SincereGrowAve;
    public int SincereGrowErr;
    public int SincereMaxAve;
    public int SincereMaxErr;
    public int LoyaltyMinAve;
    public int LoyaltyMinErr;
    public int LoyaltyGrowAve;
    public int LoyaltyGrowErr;
    public int LoyaltyMaxAve;
    public int LoyaltyMaxErr;
    public int CleanSelfInc;
    public int CleanSelfRatio;
    public int AdaptMinAve;
    public int AdaptMinErr;
    public int AdaptGrowAve;
    public int AdaptGrowErr;
    public int AdaptMaxAve;
    public int AdaptMaxErr;
    public int SocialMinAve;
    public int SocialMinErr;
    public int SocialGrowAve;
    public int SocialGrowErr;
    public int SocialMaxAve;
    public int SocialMaxErr;
    public int TiredMinAve;
    public int TiredMinErr;
    public int TiredGrowAve;
    public int TiredGrowErr;
    public int TiredMaxAve;
    public int TiredMaxErr;
    public int TiredUsualInc;
    public int StressMinAve;
    public int StressMinErr;
    public int StressGrowAve;
    public int StressGrowErr;
    public int StressMaxAve;
    public int StressMaxErr;
    public int StressUsualInc;
    public int CivilizationMinAve;
    public int CivilizationMinErr;
    public int CivilizationGrowAve;
    public int CivilizationGrowErr;
    public int CivilizationMaxAve;
    public int CivilizationMaxErr;
    public int DisciplineMinAve;
    public int DisciplineMinErr;
    public int DisciplineGrowAve;
    public int DisciplineGrowErr;
    public int DisciplineMaxAve;
    public int DisciplineMaxErr;
    public int KnowledgeMinAve;
    public int KnowledgeMinErr;
    public int KnowledgeGrowAve;
    public int KnowledgeGrowErr;
    public int KnowledgeMaxAve;
    public int KnowledgeMaxErr;
    public int BowelMinAve;
    public int BowelMinErr;
    public int BowelGrowAve;
    public int BowelGrowErr;
    public int BowelMaxAve;
    public int BowelMaxErr;
    public int TerritoryMinAve;
    public int TerritoryMinErr;
    public int TerritoryGrowAve;
    public int TerritoryGrowErr;
    public int TerritoryMaxAve;
    public int TerritoryMaxErr;
    public int EscapistMinAve;
    public int EscapistMinErr;
    public int EscapistGrowAve;
    public int EscapistGrowErr;
    public int EscapistMaxAve;
    public int EscapistMaxErr;
    public int PossessionMinAve;
    public int PossessionMinErr;
    public int PossessionGrowAve;
    public int PossessionGrowErr;
    public int PossessionMaxAve;
    public int PossessionMaxErr;
    public int FoodChainSelfGrade;
    public int FoodChainOtherGrade;
    public int FoodChainFriendGrade;
    public int SlumberTimeMin;
    public int SlumberTimeMid;
    public int SlumberTimeMax;
    public int SlumberTiredDec;
    public int SlumberHealthInc;
    public int DignityMinAve;
    public int DignityMinErr;
    public int DignityGrowAve;
    public int DignityGrowErr;
    public int DignityMaxAve;
    public int DignityMaxErr;
    public int ThreatMinAve;
    public int ThreatMinErr;
    public int ThreatGrowAve;
    public int ThreatGrowErr;
    public int ThreatMaxAve;
    public int ThreatMaxErr;
    public int EnduranceMinAve;
    public int EnduranceMinErr;
    public int EnduranceGrowAve;
    public int EnduranceGrowErr;
    public int EnduranceMaxAve;
    public int EnduranceMaxErr;
    public int WalkingMinAve;
    public int WalkingMinErr;
    public int WalkingGrowAve;
    public int WalkingGrowErr;
    public int WalkingMaxAve;
    public int WalkingMaxErr;
    public int EatWaterAmount;
    public int EatMeatAmount;
    public int EatPlantAmount;
    public int EatFoodType1;
    public int EatFoodType2;
    public int EatFoodType3;
    public int EatFoodType4;
    public int EatFoodType5;
    public int EatNutritionType1;
    public int EatNutritionType2;
    public int EatNutritionType3;
    public int EatNutritionAmount1;
    public int EatNutritionAmount2;
    public int EatNutritionAmount3;
    public int EatAvoidType1;
    public int EatAvoidType2;
    public int EatAvoidType3;
    public int EatAvoidAmount1;
    public int EatAvoidAmount2;
    public int EatAvoidAmount3;
    public int EatEndodisrDamage;
    public int EatEndodisrResolve;
    public int AbilitySpecialType1;
    public int AbilitySpecialPower1;
    public int AbilitySpecialType2;
    public int AbilitySpecialPower2;
    public int AbilitySpecialType3;
    public int AbilitySpecialPower3;
    public int AbilitySpecialType4;
    public int AbilitySpecialPower4;
    public int AbilitySpecialType5;
    public int AbilitySpecialPower5;
    public int NatureMinAve;
    public int NatureMinErr;
    public int NatureGrowAve;
    public int NatureGrowErr;
    public int NatureMaxAve;
    public int NatureMaxErr;
    public int IndepPursuitMinAve;
    public int IndepPursuitMinErr;
    public int IndepPursuitGrowAve;
    public int IndepPursuitGrowErr;
    public int IndepPursuitMaxAve;
    public int IndepPursuitMaxErr;
    public int IndepCapacityMinAve;
    public int IndepCapacityMinErr;
    public int IndepCapacityGrowAve;
    public int IndepCapacityGrowErr;
    public int IndepCapacityMaxAve;
    public int IndepCapacityMaxErr;
    public int BodyHeatAdaptType;
    public int BodyHeatMidSafeAve;
    public int BodyHeatMidSafeErr;
    public int BodyHeatMinSafeAve;
    public int BodyHeatMinSafeErr;
    public int BodyHeatMinRecoverAve;
    public int BodyHeatMinRecoverErr;
    public int BodyHeatMinRecoverCal;
    public int BodyHeatMinRecoverDam;
    public int BodyHeatMaxSafeAve;
    public int BodyHeatMaxSafeErr;
    public int BodyHeatMaxRecoverAve;
    public int BodyHeatMaxRecoverErr;
    public int BodyHeatMaxRecoverCal;
    public int BodyHeatMaxRevoverDam;
    public int ChildBirthType;
    public int ChildLookType;
    public long PriceAve;

    public CL_AnimalEncyclopedia(

    int pm_Serial0,
    int pm_Serial1,
    int pm_Serial2,
    string pm_Name,
    int pm_Kind0,
    int pm_Kind1,
    int pm_Kind2,
    int pm_Kind3,
    int pm_Kind4,
    int pm_Kind5,
    int pm_Kind6,
    int pm_Kind7,
    int pm_Kind8,
    int pm_Kind9,
    int pm_EntityWildGroupAve,
    int pm_EntityWildGroupErr,
    int pm_EntityWildMemberAve,
    int pm_EntityWildMemberErr,
    int pm_EntityShopGroupAve,
    int pm_EntityShopGroupErr,
    int pm_EntityShopMemberAve,
    int pm_EntityShopMemberErr,
    int pm_ChildbirthMemberAve,
    int pm_ChildbirthMemberErr,
    int pm_ChildbirthTimeManyAve,
    int pm_ChildbirthTimeManyErr,
    int pm_ChildbirthTimeLongAve,
    int pm_ChildbirthTimeLongErr,
    int pm_ChildbirthAgeMinAve,
    int pm_ChildbirthAgeMinErr,
    int pm_ChildbirthAgeMaxAve,
    int pm_ChildbirthAgeMaxErr,
    int pm_ChildbirthSuccessAve,
    int pm_AgeAbsoluteWildAve,
    int pm_AgeAbsoluteWildRatio,
    int pm_AgeAbsoluteShopAve,
    int pm_AgeAbsoluteShopRatio,
    int pm_AgeAbsoluteSelterAve,
    int pm_AgeAbsoluteSelterMax,
    int pm_AgeBodyIncErr,
    int pm_AgeBodyMaxAve,
    int pm_AgeBodyMaxErr,
    int pm_AgeBodyGrowAve,
    int pm_AgeBodyGrowErr,
    int pm_HealthMinAve,
    int pm_HealthMinErr,
    int pm_HealthGrowAve,
    int pm_HealthGrowErr,
    int pm_HealthMaxAve,
    int pm_HealthMaxErr,
    int pm_SkinMinAve,
    int pm_SkinMinErr,
    int pm_SkinGrowAve,
    int pm_SkinGrowErr,
    int pm_SkinMaxAve,
    int pm_SkinMaxErr,
    int pm_SkinUsualInc,
    int pm_SkinStaminaRatioDec,
    int pm_StaminaMinAve,
    int pm_StaminaMinErr,
    int pm_StaminaGrowAve,
    int pm_StaminaGrowErr,
    int pm_StaminaMaxAve,
    int pm_StaminaMaxErr,
    int pm_StaminaUsualInc,
    int pm_StaminaAgeBodyAboveDec,
    int pm_RobustMinAve,
    int pm_RobustMinErr,
    int pm_RobustGrowAve,
    int pm_RobustGrowErr,
    int pm_RobustMaxAve,
    int pm_RobustMaxErr,
    int pm_RobustUsualInc,
    int pm_RobustSkinRatioDec,
    int pm_ImmunityMinAve,
    int pm_ImmunityMinErr,
    int pm_ImmunityGrowAve,
    int pm_ImmunityGrowErr,
    int pm_ImmunityMaxAve,
    int pm_ImmunityMaxErr,
    int pm_ImmunityUsualInc,
    int pm_ImmunityHealthRatioDec,
    int pm_OffenceMinAve,
    int pm_OffenceMinErr,
    int pm_OffenceGrowAve,
    int pm_OffenceGrowErr,
    int pm_OffenceMaxAve,
    int pm_OffenceMaxErr,
    int pm_OffenceHealthRatioInc,
    int pm_OffenceHealthRatioDec,
    int pm_PierceMinAve,
    int pm_PierceMinErr,
    int pm_PierceGrowAve,
    int pm_PierceGrowErr,
    int pm_PierceMaxAve,
    int pm_PierceMaxErr,
    int pm_PermeateMinAve,
    int pm_PermeateMinErr,
    int pm_PermeateGrowAve,
    int pm_PermeateGrowErr,
    int pm_PermeateMaxAve,
    int pm_PermeateMaxErr,
    int pm_PermeateKind1,
    int pm_PermeateKind2,
    int pm_PermeateKind3,
    int pm_ToleranceMinAve,
    int pm_ToleranceMinErr,
    int pm_ToleranceGrowAve,
    int pm_ToleranceGrowErr,
    int pm_ToleranceMaxAve,
    int pm_ToleranceMaxErr,
    int pm_ToleranceKind1,
    int pm_ToleranceKind2,
    int pm_ToleranceKind3,
    int pm_RushMinAve,
    int pm_RushMinErr,
    int pm_RushGrowAve,
    int pm_RushGrowErr,
    int pm_RushMaxAve,
    int pm_RushMaxErr,
    int pm_ReactMinAve,
    int pm_ReactMinErr,
    int pm_ReactGrowAve,
    int pm_ReactGrowErr,
    int pm_ReactMaxAve,
    int pm_ReactMaxErr,
    int pm_WittyMinAve,
    int pm_WittyMinErr,
    int pm_WittyGrowAve,
    int pm_WittyGrowErr,
    int pm_WittyMaxAve,
    int pm_WittyMaxErr,
    int pm_PhysiqueMinAve,
    int pm_PhysiqueMinErr,
    int pm_PhysiqueGrowAve,
    int pm_PhysiqueGrowErr,
    int pm_PhysiqueMaxAve,
    int pm_PhysiqueMaxErr,
    int pm_PalateMinAve,
    int pm_PalateMinErr,
    int pm_PalateGrowAve,
    int pm_PalateGrowErr,
    int pm_PalateMaxAve,
    int pm_PalateMaxErr,
    int pm_DigestMinAve,
    int pm_DigestMinErr,
    int pm_DigestGrowAve,
    int pm_DigestGrowErr,
    int pm_DigestMaxAve,
    int pm_DigestMaxErr,
    int pm_CuriosityMinAve,
    int pm_CuriosityMinErr,
    int pm_CuriosityGrowAve,
    int pm_CuriosityGrowErr,
    int pm_CuriosityMaxAve,
    int pm_CuriosityMaxErr,
    int pm_ActiveMinAve,
    int pm_ActiveMinErr,
    int pm_ActiveGrowAve,
    int pm_ActiveGrowErr,
    int pm_ActiveMaxAve,
    int pm_ActiveMaxErr,
    int pm_BubblyMinAve,
    int pm_BubblyMinErr,
    int pm_BubblyGrowAve,
    int pm_BubblyGrowErr,
    int pm_BubblyMaxAve,
    int pm_BubblyMaxErr,
    int pm_PatientMinAve,
    int pm_PatientMinErr,
    int pm_PatientGrowAve,
    int pm_PatientGrowErr,
    int pm_PatientMaxAve,
    int pm_PatientMaxErr,
    int pm_ComposureMinAve,
    int pm_ComposureMinErr,
    int pm_ComposureGrowAve,
    int pm_ComposureGrowErr,
    int pm_ComposureMaxAve,
    int pm_ComposureMaxErr,
    int pm_SincereMinAve,
    int pm_SincereMinErr,
    int pm_SincereGrowAve,
    int pm_SincereGrowErr,
    int pm_SincereMaxAve,
    int pm_SincereMaxErr,
    int pm_LoyaltyMinAve,
    int pm_LoyaltyMinErr,
    int pm_LoyaltyGrowAve,
    int pm_LoyaltyGrowErr,
    int pm_LoyaltyMaxAve,
    int pm_LoyaltyMaxErr,
    int pm_CleanSelfInc,
    int pm_CleanSelfRatio,
    int pm_AdaptMinAve,
    int pm_AdaptMinErr,
    int pm_AdaptGrowAve,
    int pm_AdaptGrowErr,
    int pm_AdaptMaxAve,
    int pm_AdaptMaxErr,
    int pm_SocialMinAve,
    int pm_SocialMinErr,
    int pm_SocialGrowAve,
    int pm_SocialGrowErr,
    int pm_SocialMaxAve,
    int pm_SocialMaxErr,
    int pm_TiredMinAve,
    int pm_TiredMinErr,
    int pm_TiredGrowAve,
    int pm_TiredGrowErr,
    int pm_TiredMaxAve,
    int pm_TiredMaxErr,
    int pm_TiredUsualInc,
    int pm_StressMinAve,
    int pm_StressMinErr,
    int pm_StressGrowAve,
    int pm_StressGrowErr,
    int pm_StressMaxAve,
    int pm_StressMaxErr,
    int pm_StressUsualInc,
    int pm_CivilizationMinAve,
    int pm_CivilizationMinErr,
    int pm_CivilizationGrowAve,
    int pm_CivilizationGrowErr,
    int pm_CivilizationMaxAve,
    int pm_CivilizationMaxErr,
    int pm_DisciplineMinAve,
    int pm_DisciplineMinErr,
    int pm_DisciplineGrowAve,
    int pm_DisciplineGrowErr,
    int pm_DisciplineMaxAve,
    int pm_DisciplineMaxErr,
    int pm_KnowledgeMinAve,
    int pm_KnowledgeMinErr,
    int pm_KnowledgeGrowAve,
    int pm_KnowledgeGrowErr,
    int pm_KnowledgeMaxAve,
    int pm_KnowledgeMaxErr,
    int pm_BowelMinAve,
    int pm_BowelMinErr,
    int pm_BowelGrowAve,
    int pm_BowelGrowErr,
    int pm_BowelMaxAve,
    int pm_BowelMaxErr,
    int pm_TerritoryMinAve,
    int pm_TerritoryMinErr,
    int pm_TerritoryGrowAve,
    int pm_TerritoryGrowErr,
    int pm_TerritoryMaxAve,
    int pm_TerritoryMaxErr,
    int pm_EscapistMinAve,
    int pm_EscapistMinErr,
    int pm_EscapistGrowAve,
    int pm_EscapistGrowErr,
    int pm_EscapistMaxAve,
    int pm_EscapistMaxErr,
    int pm_PossessionMinAve,
    int pm_PossessionMinErr,
    int pm_PossessionGrowAve,
    int pm_PossessionGrowErr,
    int pm_PossessionMaxAve,
    int pm_PossessionMaxErr,
    int pm_FoodChainSelfGrade,
    int pm_FoodChainOtherGrade,
    int pm_FoodChainFriendGrade,
    int pm_SlumberTimeMin,
    int pm_SlumberTimeMid,
    int pm_SlumberTimeMax,
    int pm_SlumberTiredDec,
    int pm_SlumberHealthInc,
    int pm_DignityMinAve,
    int pm_DignityMinErr,
    int pm_DignityGrowAve,
    int pm_DignityGrowErr,
    int pm_DignityMaxAve,
    int pm_DignityMaxErr,
    int pm_ThreatMinAve,
    int pm_ThreatMinErr,
    int pm_ThreatGrowAve,
    int pm_ThreatGrowErr,
    int pm_ThreatMaxAve,
    int pm_ThreatMaxErr,
    int pm_EnduranceMinAve,
    int pm_EnduranceMinErr,
    int pm_EnduranceGrowAve,
    int pm_EnduranceGrowErr,
    int pm_EnduranceMaxAve,
    int pm_EnduranceMaxErr,
    int pm_WalkingMinAve,
    int pm_WalkingMinErr,
    int pm_WalkingGrowAve,
    int pm_WalkingGrowErr,
    int pm_WalkingMaxAve,
    int pm_WalkingMaxErr,
    int pm_EatWaterAmount,
    int pm_EatMeatAmount,
    int pm_EatPlantAmount,
    int pm_EatFoodType1,
    int pm_EatFoodType2,
    int pm_EatFoodType3,
    int pm_EatFoodType4,
    int pm_EatFoodType5,
    int pm_EatNutritionType1,
    int pm_EatNutritionType2,
    int pm_EatNutritionType3,
    int pm_EatNutritionAmount1,
    int pm_EatNutritionAmount2,
    int pm_EatNutritionAmount3,
    int pm_EatAvoidType1,
    int pm_EatAvoidType2,
    int pm_EatAvoidType3,
    int pm_EatAvoidAmount1,
    int pm_EatAvoidAmount2,
    int pm_EatAvoidAmount3,
    int pm_EatEndodisrDamage,
    int pm_EatEndodisrResolve,
    int pm_AbilitySpecialType1,
    int pm_AbilitySpecialPower1,
    int pm_AbilitySpecialType2,
    int pm_AbilitySpecialPower2,
    int pm_AbilitySpecialType3,
    int pm_AbilitySpecialPower3,
    int pm_AbilitySpecialType4,
    int pm_AbilitySpecialPower4,
    int pm_AbilitySpecialType5,
    int pm_AbilitySpecialPower5,
    int pm_NatureMinAve,
    int pm_NatureMinErr,
    int pm_NatureGrowAve,
    int pm_NatureGrowErr,
    int pm_NatureMaxAve,
    int pm_NatureMaxErr,
    int pm_IndepPursuitMinAve,
    int pm_IndepPursuitMinErr,
    int pm_IndepPursuitGrowAve,
    int pm_IndepPursuitGrowErr,
    int pm_IndepPursuitMaxAve,
    int pm_IndepPursuitMaxErr,
    int pm_IndepCapacityMinAve,
    int pm_IndepCapacityMinErr,
    int pm_IndepCapacityGrowAve,
    int pm_IndepCapacityGrowErr,
    int pm_IndepCapacityMaxAve,
    int pm_IndepCapacityMaxErr,
    int pm_BodyHeatAdaptType,
    int pm_BodyHeatMidSafeAve,
    int pm_BodyHeatMidSafeErr,
    int pm_BodyHeatMinSafeAve,
    int pm_BodyHeatMinSafeErr,
    int pm_BodyHeatMinRecoverAve,
    int pm_BodyHeatMinRecoverErr,
    int pm_BodyHeatMinRecoverCal,
    int pm_BodyHeatMinRecoverDam,
    int pm_BodyHeatMaxSafeAve,
    int pm_BodyHeatMaxSafeErr,
    int pm_BodyHeatMaxRecoverAve,
    int pm_BodyHeatMaxRecoverErr,
    int pm_BodyHeatMaxRecoverCal,
    int pm_BodyHeatMaxRevoverDam,
    int pm_ChildBirthType,
    int pm_ChildLookType,
    long pm_PriceAve,

    char pm_Updated = 'N')
    {
        Updated = pm_Updated;

        Serial0 = pm_Serial0;
        Serial1 = pm_Serial1;
        Serial2 = pm_Serial2;
        Name = pm_Name;
        Kind0 = pm_Kind0;
        Kind1 = pm_Kind1;
        Kind2 = pm_Kind2;
        Kind3 = pm_Kind3;
        Kind4 = pm_Kind4;
        Kind5 = pm_Kind5;
        Kind6 = pm_Kind6;
        Kind7 = pm_Kind7;
        Kind8 = pm_Kind8;
        Kind9 = pm_Kind9;
        EntityWildGroupAve = pm_EntityWildGroupAve;
        EntityWildGroupErr = pm_EntityWildGroupErr;
        EntityWildMemberAve = pm_EntityWildMemberAve;
        EntityWildMemberErr = pm_EntityWildMemberErr;
        EntityShopGroupAve = pm_EntityShopGroupAve;
        EntityShopGroupErr = pm_EntityShopGroupErr;
        EntityShopMemberAve = pm_EntityShopMemberAve;
        EntityShopMemberErr = pm_EntityShopMemberErr;
        ChildbirthMemberAve = pm_ChildbirthMemberAve;
        ChildbirthMemberErr = pm_ChildbirthMemberErr;
        ChildbirthTimeManyAve = pm_ChildbirthTimeManyAve;
        ChildbirthTimeManyErr = pm_ChildbirthTimeManyErr;
        ChildbirthTimeLongAve = pm_ChildbirthTimeLongAve;
        ChildbirthTimeLongErr = pm_ChildbirthTimeLongErr;
        ChildbirthAgeMinAve = pm_ChildbirthAgeMinAve;
        ChildbirthAgeMinErr = pm_ChildbirthAgeMinErr;
        ChildbirthAgeMaxAve = pm_ChildbirthAgeMaxAve;
        ChildbirthAgeMaxErr = pm_ChildbirthAgeMaxErr;
        ChildbirthSuccessAve = pm_ChildbirthSuccessAve;
        AgeAbsoluteWildAve = pm_AgeAbsoluteWildAve;
        AgeAbsoluteWildRatio = pm_AgeAbsoluteWildRatio;
        AgeAbsoluteShopAve = pm_AgeAbsoluteShopAve;
        AgeAbsoluteShopRatio = pm_AgeAbsoluteShopRatio;
        AgeAbsoluteSelterAve = pm_AgeAbsoluteSelterAve;
        AgeAbsoluteSelterMax = pm_AgeAbsoluteSelterMax;
        AgeBodyIncErr = pm_AgeBodyIncErr;
        AgeBodyMaxAve = pm_AgeBodyMaxAve;
        AgeBodyMaxErr = pm_AgeBodyMaxErr;
        AgeBodyGrowAve = pm_AgeBodyGrowAve;
        AgeBodyGrowErr = pm_AgeBodyGrowErr;
        HealthMinAve = pm_HealthMinAve;
        HealthMinErr = pm_HealthMinErr;
        HealthGrowAve = pm_HealthGrowAve;
        HealthGrowErr = pm_HealthGrowErr;
        HealthMaxAve = pm_HealthMaxAve;
        HealthMaxErr = pm_HealthMaxErr;
        SkinMinAve = pm_SkinMinAve;
        SkinMinErr = pm_SkinMinErr;
        SkinGrowAve = pm_SkinGrowAve;
        SkinGrowErr = pm_SkinGrowErr;
        SkinMaxAve = pm_SkinMaxAve;
        SkinMaxErr = pm_SkinMaxErr;
        SkinUsualInc = pm_SkinUsualInc;
        SkinStaminaRatioDec = pm_SkinStaminaRatioDec;
        StaminaMinAve = pm_StaminaMinAve;
        StaminaMinErr = pm_StaminaMinErr;
        StaminaGrowAve = pm_StaminaGrowAve;
        StaminaGrowErr = pm_StaminaGrowErr;
        StaminaMaxAve = pm_StaminaMaxAve;
        StaminaMaxErr = pm_StaminaMaxErr;
        StaminaUsualInc = pm_StaminaUsualInc;
        StaminaAgeBodyAboveDec = pm_StaminaAgeBodyAboveDec;
        RobustMinAve = pm_RobustMinAve;
        RobustMinErr = pm_RobustMinErr;
        RobustGrowAve = pm_RobustGrowAve;
        RobustGrowErr = pm_RobustGrowErr;
        RobustMaxAve = pm_RobustMaxAve;
        RobustMaxErr = pm_RobustMaxErr;
        RobustUsualInc = pm_RobustUsualInc;
        RobustSkinRatioDec = pm_RobustSkinRatioDec;
        ImmunityMinAve = pm_ImmunityMinAve;
        ImmunityMinErr = pm_ImmunityMinErr;
        ImmunityGrowAve = pm_ImmunityGrowAve;
        ImmunityGrowErr = pm_ImmunityGrowErr;
        ImmunityMaxAve = pm_ImmunityMaxAve;
        ImmunityMaxErr = pm_ImmunityMaxErr;
        ImmunityUsualInc = pm_ImmunityUsualInc;
        ImmunityHealthRatioDec = pm_ImmunityHealthRatioDec;
        OffenceMinAve = pm_OffenceMinAve;
        OffenceMinErr = pm_OffenceMinErr;
        OffenceGrowAve = pm_OffenceGrowAve;
        OffenceGrowErr = pm_OffenceGrowErr;
        OffenceMaxAve = pm_OffenceMaxAve;
        OffenceMaxErr = pm_OffenceMaxErr;
        OffenceHealthRatioInc = pm_OffenceHealthRatioInc;
        OffenceHealthRatioDec = pm_OffenceHealthRatioDec;
        PierceMinAve = pm_PierceMinAve;
        PierceMinErr = pm_PierceMinErr;
        PierceGrowAve = pm_PierceGrowAve;
        PierceGrowErr = pm_PierceGrowErr;
        PierceMaxAve = pm_PierceMaxAve;
        PierceMaxErr = pm_PierceMaxErr;
        PermeateMinAve = pm_PermeateMinAve;
        PermeateMinErr = pm_PermeateMinErr;
        PermeateGrowAve = pm_PermeateGrowAve;
        PermeateGrowErr = pm_PermeateGrowErr;
        PermeateMaxAve = pm_PermeateMaxAve;
        PermeateMaxAve = pm_PermeateMaxErr;
        PermeateKind1 = pm_PermeateKind1;
        PermeateKind2 = pm_PermeateKind2;
        PermeateKind3 = pm_PermeateKind3;
        ToleranceMinAve = pm_ToleranceMinAve;
        ToleranceMinErr = pm_ToleranceMinErr;
        ToleranceGrowAve = pm_ToleranceGrowAve;
        ToleranceGrowErr = pm_ToleranceGrowErr;
        ToleranceMaxAve = pm_ToleranceMaxAve;
        ToleranceMaxErr = pm_ToleranceMaxErr;
        ToleranceKind1 = pm_ToleranceKind1;
        ToleranceKind2 = pm_ToleranceKind2;
        ToleranceKind3 = pm_ToleranceKind3;
        RushMinAve = pm_RushMinAve;
        RushMinErr = pm_RushMinErr;
        RushGrowAve = pm_RushGrowAve;
        RushGrowErr = pm_RushGrowErr;
        RushMaxAve = pm_RushMaxAve;
        RushMaxErr = pm_RushMaxErr;
        ReactMinAve = pm_ReactMinAve;
        ReactMinErr = pm_ReactMinErr;
        ReactGrowAve = pm_ReactGrowAve;
        ReactGrowErr = pm_ReactGrowErr;
        ReactMaxAve = pm_ReactMaxAve;
        ReactMaxAve = pm_ReactMaxErr;
        WittyMinAve = pm_WittyMinAve;
        WittyMinErr = pm_WittyMinErr;
        WittyGrowAve = pm_WittyGrowAve;
        WittyGrowAve = pm_WittyGrowErr;
        WittyMaxAve = pm_WittyMaxAve;
        WittyMaxErr = pm_WittyMaxErr;
        PhysiqueMinAve = pm_PhysiqueMinAve;
        PhysiqueMinErr = pm_PhysiqueMinErr;
        PhysiqueGrowAve = pm_PhysiqueGrowAve;
        PhysiqueGrowAve = pm_PhysiqueGrowErr;
        PhysiqueMaxAve = pm_PhysiqueMaxAve;
        PhysiqueMaxErr = pm_PhysiqueMaxErr;
        PalateMinAve = pm_PalateMinAve;
        PalateMinErr = pm_PalateMinErr;
        PalateGrowAve = pm_PalateGrowAve;
        PalateGrowErr = pm_PalateGrowErr;
        PalateMaxAve = pm_PalateMaxAve;
        PalateMaxAve = pm_PalateMaxErr;
        DigestMinAve = pm_DigestMinAve;
        DigestMinErr = pm_DigestMinErr;
        DigestGrowAve = pm_DigestGrowAve;
        DigestGrowErr = pm_DigestGrowErr;
        DigestMaxAve = pm_DigestMaxAve;
        DigestMaxErr = pm_DigestMaxErr;
        CuriosityMinAve = pm_CuriosityMinAve;
        CuriosityMinErr = pm_CuriosityMinErr;
        CuriosityGrowAve = pm_CuriosityGrowAve;
        CuriosityGrowErr = pm_CuriosityGrowErr;
        CuriosityMaxAve = pm_CuriosityMaxAve;
        CuriosityMaxErr = pm_CuriosityMaxErr;
        ActiveMinAve = pm_ActiveMinAve;
        ActiveMinErr = pm_ActiveMinErr;
        ActiveGrowAve = pm_ActiveGrowAve;
        ActiveGrowErr = pm_ActiveGrowErr;
        ActiveMaxAve = pm_ActiveMaxAve;
        ActiveMaxErr = pm_ActiveMaxErr;
        BubblyMinAve = pm_BubblyMinAve;
        BubblyMinAve = pm_BubblyMinErr;
        BubblyGrowAve = pm_BubblyGrowAve;
        BubblyGrowErr = pm_BubblyGrowErr;
        BubblyMaxAve = pm_BubblyMaxAve;
        BubblyMaxErr = pm_BubblyMaxErr;
        PatientMinAve = pm_PatientMinAve;
        PatientMinErr = pm_PatientMinErr;
        PatientGrowAve = pm_PatientGrowAve;
        PatientGrowErr = pm_PatientGrowErr;
        PatientMaxAve = pm_PatientMaxAve;
        PatientMaxErr = pm_PatientMaxErr;
        ComposureMinAve = pm_ComposureMinAve;
        ComposureMinErr = pm_ComposureMinErr;
        ComposureGrowAve = pm_ComposureGrowAve;
        ComposureGrowErr = pm_ComposureGrowErr;
        ComposureMaxAve = pm_ComposureMaxAve;
        ComposureMaxErr = pm_ComposureMaxErr;
        SincereMinAve = pm_SincereMinAve;
        SincereMinAve = pm_SincereMinErr;
        SincereGrowAve = pm_SincereGrowAve;
        SincereGrowErr = pm_SincereGrowErr;
        SincereMaxAve = pm_SincereMaxAve;
        SincereMaxErr = pm_SincereMaxErr;
        SincereMaxErr = pm_LoyaltyMinAve;
        LoyaltyMinErr = pm_LoyaltyMinErr;
        LoyaltyGrowAve = pm_LoyaltyGrowAve;
        LoyaltyGrowAve = pm_LoyaltyGrowErr;
        LoyaltyGrowAve = pm_LoyaltyMaxAve;
        LoyaltyMaxErr = pm_LoyaltyMaxErr;
        CleanSelfInc = pm_CleanSelfInc;
        CleanSelfRatio = pm_CleanSelfRatio;
        AdaptMinAve = pm_AdaptMinAve;
        AdaptMinErr = pm_AdaptMinErr;
        AdaptGrowAve = pm_AdaptGrowAve;
        AdaptGrowErr = pm_AdaptGrowErr;
        AdaptMaxAve = pm_AdaptMaxAve;
        AdaptMaxErr = pm_AdaptMaxErr;
        SocialMinAve = pm_SocialMinAve;
        SocialMinErr = pm_SocialMinErr;
        SocialGrowAve = pm_SocialGrowAve;
        SocialGrowErr = pm_SocialGrowErr;
        SocialMaxAve = pm_SocialMaxAve;
        SocialMaxErr = pm_SocialMaxErr;
        TiredMinAve = pm_TiredMinAve;
        TiredMinErr = pm_TiredMinErr;
        TiredGrowAve = pm_TiredGrowAve;
        TiredGrowErr = pm_TiredGrowErr;
        TiredMaxAve = pm_TiredMaxAve;
        TiredMaxErr = pm_TiredMaxErr;
        TiredUsualInc = pm_TiredUsualInc;
        StressMinAve = pm_StressMinAve;
        StressMinErr = pm_StressMinErr;
        StressGrowAve = pm_StressGrowAve;
        StressGrowErr = pm_StressGrowErr;
        StressMaxAve = pm_StressMaxAve;
        StressMaxErr = pm_StressMaxErr;
        StressUsualInc = pm_StressUsualInc;
        CivilizationMinAve = pm_CivilizationMinAve;
        CivilizationMinErr = pm_CivilizationMinErr;
        CivilizationMinErr = pm_CivilizationGrowAve;
        CivilizationGrowErr = pm_CivilizationGrowErr;
        CivilizationMaxAve = pm_CivilizationMaxAve;
        CivilizationMaxErr = pm_CivilizationMaxErr;
        DisciplineMinAve = pm_DisciplineMinAve;
        DisciplineMinErr = pm_DisciplineMinErr;
        DisciplineGrowAve = pm_DisciplineGrowAve;
        DisciplineGrowErr = pm_DisciplineGrowErr;
        DisciplineMaxAve = pm_DisciplineMaxAve;
        DisciplineMaxErr = pm_DisciplineMaxErr;
        KnowledgeMinAve = pm_KnowledgeMinAve;
        KnowledgeMinErr = pm_KnowledgeMinErr;
        KnowledgeGrowAve = pm_KnowledgeGrowAve;
        KnowledgeGrowErr = pm_KnowledgeGrowErr;
        KnowledgeGrowErr = pm_KnowledgeMaxAve;
        KnowledgeMaxErr = pm_KnowledgeMaxErr;
        BowelMinAve = pm_BowelMinAve;
        BowelMinErr = pm_BowelMinErr;
        BowelGrowAve = pm_BowelGrowAve;
        BowelGrowErr = pm_BowelGrowErr;
        BowelMaxAve = pm_BowelMaxAve;
        BowelMaxErr = pm_BowelMaxErr;
        TerritoryMinAve = pm_TerritoryMinAve;
        TerritoryMinErr = pm_TerritoryMinErr;
        TerritoryGrowAve = pm_TerritoryGrowAve;
        TerritoryGrowErr = pm_TerritoryGrowErr;
        TerritoryMaxAve = pm_TerritoryMaxAve;
        TerritoryMaxErr = pm_TerritoryMaxErr;
        EscapistMinAve = pm_EscapistMinAve;
        EscapistMinAve = pm_EscapistMinErr;
        EscapistGrowAve = pm_EscapistGrowAve;
        EscapistGrowErr = pm_EscapistGrowErr;
        EscapistMaxAve = pm_EscapistMaxAve;
        EscapistMaxErr = pm_EscapistMaxErr;
        PossessionMinAve = pm_PossessionMinAve;
        PossessionMinErr = pm_PossessionMinErr;
        PossessionGrowAve = pm_PossessionGrowAve;
        PossessionGrowErr = pm_PossessionGrowErr;
        PossessionMaxAve = pm_PossessionMaxAve;
        PossessionMaxErr = pm_PossessionMaxErr;
        FoodChainSelfGrade = pm_FoodChainSelfGrade;
        FoodChainOtherGrade = pm_FoodChainOtherGrade;
        FoodChainFriendGrade = pm_FoodChainFriendGrade;
        SlumberTimeMin = pm_SlumberTimeMin;
        SlumberTimeMid = pm_SlumberTimeMid;
        SlumberTimeMax = pm_SlumberTimeMax;
        SlumberTiredDec = pm_SlumberTiredDec;
        SlumberHealthInc = pm_SlumberHealthInc;
        DignityMinAve = pm_DignityMinAve;
        DignityMinErr = pm_DignityMinErr;
        DignityGrowAve = pm_DignityGrowAve;
        DignityGrowErr = pm_DignityGrowErr;
        DignityMaxAve = pm_DignityMaxAve;
        DignityMaxErr = pm_DignityMaxErr;
        ThreatMinAve = pm_ThreatMinAve;
        ThreatMinErr = pm_ThreatMinErr;
        ThreatGrowAve = pm_ThreatGrowAve;
        ThreatGrowErr = pm_ThreatGrowErr;
        ThreatMaxAve = pm_ThreatMaxAve;
        ThreatMaxErr = pm_ThreatMaxErr;
        EnduranceMinAve = pm_EnduranceMinAve;
        EnduranceMinErr = pm_EnduranceMinErr;
        EnduranceGrowAve = pm_EnduranceGrowAve;
        EnduranceGrowErr = pm_EnduranceGrowErr;
        EnduranceMaxAve = pm_EnduranceMaxAve;
        EnduranceMaxErr = pm_EnduranceMaxErr;
        WalkingMinAve = pm_WalkingMinAve;
        WalkingMinErr = pm_WalkingMinErr;
        WalkingGrowAve = pm_WalkingGrowAve;
        WalkingGrowErr = pm_WalkingGrowErr;
        WalkingMaxAve = pm_WalkingMaxAve;
        WalkingMaxErr = pm_WalkingMaxErr;
        EatWaterAmount = pm_EatWaterAmount;
        EatMeatAmount = pm_EatMeatAmount;
        EatPlantAmount = pm_EatPlantAmount;
        EatFoodType1 = pm_EatFoodType1;
        EatFoodType2 = pm_EatFoodType2;
        EatFoodType3 = pm_EatFoodType3;
        EatFoodType4 = pm_EatFoodType4;
        EatFoodType5 = pm_EatFoodType5;
        EatNutritionType1 = pm_EatNutritionType1;
        EatNutritionType2 = pm_EatNutritionType2;
        EatNutritionType3 = pm_EatNutritionType3;
        EatNutritionAmount1 = pm_EatNutritionAmount1;
        EatNutritionAmount2 = pm_EatNutritionAmount2;
        EatNutritionAmount3 = pm_EatNutritionAmount3;
        EatAvoidType1 = pm_EatAvoidType1;
        EatAvoidType2 = pm_EatAvoidType2;
        EatAvoidType3 = pm_EatAvoidType3;
        EatAvoidAmount1 = pm_EatAvoidAmount1;
        EatAvoidAmount2 = pm_EatAvoidAmount2;
        EatAvoidAmount3 = pm_EatAvoidAmount3;
        EatEndodisrDamage = pm_EatEndodisrDamage;
        EatEndodisrResolve = pm_EatEndodisrResolve;
        AbilitySpecialType1 = pm_AbilitySpecialType1;
        AbilitySpecialPower1 = pm_AbilitySpecialPower1;
        AbilitySpecialType2 = pm_AbilitySpecialType2;
        AbilitySpecialPower2 = pm_AbilitySpecialPower2;
        AbilitySpecialType3 = pm_AbilitySpecialType3;
        AbilitySpecialPower3 = pm_AbilitySpecialPower3;
        AbilitySpecialType4 = pm_AbilitySpecialType4;
        AbilitySpecialPower4 = pm_AbilitySpecialPower4;
        AbilitySpecialType5 = pm_AbilitySpecialType5;
        AbilitySpecialPower5 = pm_AbilitySpecialPower5;
        NatureMinAve = pm_NatureMinAve;
        NatureMinErr = pm_NatureMinErr;
        NatureGrowAve = pm_NatureGrowAve;
        NatureGrowErr = pm_NatureGrowErr;
        NatureMaxAve = pm_NatureMaxAve;
        NatureMaxErr = pm_NatureMaxErr;
        IndepPursuitMinAve = pm_IndepPursuitMinAve;
        IndepPursuitMinErr = pm_IndepPursuitMinErr;
        IndepPursuitGrowAve = pm_IndepPursuitGrowAve;
        IndepPursuitGrowErr = pm_IndepPursuitGrowErr;
        IndepPursuitMaxAve = pm_IndepPursuitMaxAve;
        IndepPursuitMaxErr = pm_IndepPursuitMaxErr;
        IndepCapacityMinAve = pm_IndepCapacityMinAve;
        IndepCapacityMinErr = pm_IndepCapacityMinErr;
        IndepCapacityGrowAve = pm_IndepCapacityGrowAve;
        IndepCapacityGrowErr = pm_IndepCapacityGrowErr;
        IndepCapacityMaxAve = pm_IndepCapacityMaxAve;
        IndepCapacityMaxErr = pm_IndepCapacityMaxErr;
        BodyHeatAdaptType = pm_BodyHeatAdaptType;
        BodyHeatMidSafeAve = pm_BodyHeatMidSafeAve;
        BodyHeatMidSafeErr = pm_BodyHeatMidSafeErr;
        BodyHeatMinSafeAve = pm_BodyHeatMinSafeAve;
        BodyHeatMinSafeErr = pm_BodyHeatMinSafeErr;
        BodyHeatMinRecoverAve = pm_BodyHeatMinRecoverAve;
        BodyHeatMinRecoverErr = pm_BodyHeatMinRecoverErr;
        BodyHeatMinRecoverCal = pm_BodyHeatMinRecoverCal;
        BodyHeatMinRecoverDam = pm_BodyHeatMinRecoverDam;
        BodyHeatMaxSafeAve = pm_BodyHeatMaxSafeAve;
        BodyHeatMaxSafeAve = pm_BodyHeatMaxSafeErr;
        BodyHeatMaxRecoverAve = pm_BodyHeatMaxRecoverAve;
        BodyHeatMaxRecoverErr = pm_BodyHeatMaxRecoverErr;
        BodyHeatMaxRecoverCal = pm_BodyHeatMaxRecoverCal;
        BodyHeatMaxRevoverDam = pm_BodyHeatMaxRevoverDam;
        ChildBirthType = pm_ChildBirthType;
        ChildLookType = pm_ChildLookType;
        PriceAve = pm_PriceAve;
    }
}
//%_% Table_02 동물 사전

//㎪㎪㎪ 001002
public enum EM_AE
{
    CC_Nothing,
    CC_Count,
    CC_MaxSerial0,
    CC_MaxSerial1,
    CC_MaxSerial2,

    Updated,
    Serial0,
    Serial1,
    Serial2,
    Name,
    Kind0,
    Kind1,
    Kind2,
    Kind3,
    Kind4,
    Kind5,
    Kind6,
    Kind7,
    Kind8,
    Kind9,
    EntityWildGroupAve,
    EntityWildGroupErr,
    EntityWildMemberAve,
    EntityWildMemberErr,
    EntityShopGroupAve,
    EntityShopGroupErr,
    EntityShopMemberAve,
    EntityShopMemberErr,
    ChildbirthMemberAve,
    ChildbirthMemberErr,
    ChildbirthTimeManyAve,
    ChildbirthTimeManyErr,
    ChildbirthTimeLongAve,
    ChildbirthTimeLongErr,
    ChildbirthAgeMinAve,
    ChildbirthAgeMinErr,
    ChildbirthAgeMaxAve,
    ChildbirthAgeMaxErr,
    ChildbirthSuccessAve,
    AgeAbsoluteWildAve,
    AgeAbsoluteWildRatio,
    AgeAbsoluteShopAve,
    AgeAbsoluteShopRatio,
    AgeAbsoluteSelterAve,
    AgeAbsoluteSelterMax,
    AgeBodyIncErr,
    AgeBodyMaxAve,
    AgeBodyMaxErr,
    AgeBodyGrowAve,
    AgeBodyGrowErr,
    HealthMinAve,
    HealthMinErr,
    HealthGrowAve,
    HealthGrowErr,
    HealthMaxAve,
    HealthMaxErr,
    SkinMinAve,
    SkinMinErr,
    SkinGrowAve,
    SkinGrowErr,
    SkinMaxAve,
    SkinMaxErr,
    SkinUsualInc,
    SkinStaminaRatioDec,
    StaminaMinAve,
    StaminaMinErr,
    StaminaGrowAve,
    StaminaGrowErr,
    StaminaMaxAve,
    StaminaMaxErr,
    StaminaUsualInc,
    StaminaAgeBodyAboveDec,
    RobustMinAve,
    RobustMinErr,
    RobustGrowAve,
    RobustGrowErr,
    RobustMaxAve,
    RobustMaxErr,
    RobustUsualInc,
    RobustSkinRatioDec,
    ImmunityMinAve,
    ImmunityMinErr,
    ImmunityGrowAve,
    ImmunityGrowErr,
    ImmunityMaxAve,
    ImmunityMaxErr,
    ImmunityUsualInc,
    ImmunityHealthRatioDec,
    OffenceMinAve,
    OffenceMinErr,
    OffenceGrowAve,
    OffenceGrowErr,
    OffenceMaxAve,
    OffenceMaxErr,
    OffenceHealthRatioInc,
    OffenceHealthRatioDec,
    PierceMinAve,
    PierceMinErr,
    PierceGrowAve,
    PierceGrowErr,
    PierceMaxAve,
    PierceMaxErr,
    PermeateMinAve,
    PermeateMinErr,
    PermeateGrowAve,
    PermeateGrowErr,
    PermeateMaxAve,
    PermeateMaxErr,
    PermeateKind1,
    PermeateKind2,
    PermeateKind3,
    ToleranceMinAve,
    ToleranceMinErr,
    ToleranceGrowAve,
    ToleranceGrowErr,
    ToleranceMaxAve,
    ToleranceMaxErr,
    ToleranceKind1,
    ToleranceKind2,
    ToleranceKind3,
    RushMinAve,
    RushMinErr,
    RushGrowAve,
    RushGrowErr,
    RushMaxAve,
    RushMaxErr,
    ReactMinAve,
    ReactMinErr,
    ReactGrowAve,
    ReactGrowErr,
    ReactMaxAve,
    ReactMaxErr,
    WittyMinAve,
    WittyMinErr,
    WittyGrowAve,
    WittyGrowErr,
    WittyMaxAve,
    WittyMaxErr,
    PhysiqueMinAve,
    PhysiqueMinErr,
    PhysiqueGrowAve,
    PhysiqueGrowErr,
    PhysiqueMaxAve,
    PhysiqueMaxErr,
    PalateMinAve,
    PalateMinErr,
    PalateGrowAve,
    PalateGrowErr,
    PalateMaxAve,
    PalateMaxErr,
    DigestMinAve,
    DigestMinErr,
    DigestGrowAve,
    DigestGrowErr,
    DigestMaxAve,
    DigestMaxErr,
    CuriosityMinAve,
    CuriosityMinErr,
    CuriosityGrowAve,
    CuriosityGrowErr,
    CuriosityMaxAve,
    CuriosityMaxErr,
    ActiveMinAve,
    ActiveMinErr,
    ActiveGrowAve,
    ActiveGrowErr,
    ActiveMaxAve,
    ActiveMaxErr,
    BubblyMinAve,
    BubblyMinErr,
    BubblyGrowAve,
    BubblyGrowErr,
    BubblyMaxAve,
    BubblyMaxErr,
    PatientMinAve,
    PatientMinErr,
    PatientGrowAve,
    PatientGrowErr,
    PatientMaxAve,
    PatientMaxErr,
    ComposureMinAve,
    ComposureMinErr,
    ComposureGrowAve,
    ComposureGrowErr,
    ComposureMaxAve,
    ComposureMaxErr,
    SincereMinAve,
    SincereMinErr,
    SincereGrowAve,
    SincereGrowErr,
    SincereMaxAve,
    SincereMaxErr,
    LoyaltyMinAve,
    LoyaltyMinErr,
    LoyaltyGrowAve,
    LoyaltyGrowErr,
    LoyaltyMaxAve,
    LoyaltyMaxErr,
    CleanSelfInc,
    CleanSelfRatio,
    AdaptMinAve,
    AdaptMinErr,
    AdaptGrowAve,
    AdaptGrowErr,
    AdaptMaxAve,
    AdaptMaxErr,
    SocialMinAve,
    SocialMinErr,
    SocialGrowAve,
    SocialGrowErr,
    SocialMaxAve,
    SocialMaxErr,
    TiredMinAve,
    TiredMinErr,
    TiredGrowAve,
    TiredGrowErr,
    TiredMaxAve,
    TiredMaxErr,
    TiredUsualInc,
    StressMinAve,
    StressMinErr,
    StressGrowAve,
    StressGrowErr,
    StressMaxAve,
    StressMaxErr,
    StressUsualInc,
    CivilizationMinAve,
    CivilizationMinErr,
    CivilizationGrowAve,
    CivilizationGrowErr,
    CivilizationMaxAve,
    CivilizationMaxErr,
    DisciplineMinAve,
    DisciplineMinErr,
    DisciplineGrowAve,
    DisciplineGrowErr,
    DisciplineMaxAve,
    DisciplineMaxErr,
    KnowledgeMinAve,
    KnowledgeMinErr,
    KnowledgeGrowAve,
    KnowledgeGrowErr,
    KnowledgeMaxAve,
    KnowledgeMaxErr,
    BowelMinAve,
    BowelMinErr,
    BowelGrowAve,
    BowelGrowErr,
    BowelMaxAve,
    BowelMaxErr,
    TerritoryMinAve,
    TerritoryMinErr,
    TerritoryGrowAve,
    TerritoryGrowErr,
    TerritoryMaxAve,
    TerritoryMaxErr,
    EscapistMinAve,
    EscapistMinErr,
    EscapistGrowAve,
    EscapistGrowErr,
    EscapistMaxAve,
    EscapistMaxErr,
    PossessionMinAve,
    PossessionMinErr,
    PossessionGrowAve,
    PossessionGrowErr,
    PossessionMaxAve,
    PossessionMaxErr,
    FoodChainSelfGrade,
    FoodChainOtherGrade,
    FoodChainFriendGrade,
    SlumberTimeMin,
    SlumberTimeMid,
    SlumberTimeMax,
    SlumberTiredDec,
    SlumberHealthInc,
    DignityMinAve,
    DignityMinErr,
    DignityGrowAve,
    DignityGrowErr,
    DignityMaxAve,
    DignityMaxErr,
    ThreatMinAve,
    ThreatMinErr,
    ThreatGrowAve,
    ThreatGrowErr,
    ThreatMaxAve,
    ThreatMaxErr,
    EnduranceMinAve,
    EnduranceMinErr,
    EnduranceGrowAve,
    EnduranceGrowErr,
    EnduranceMaxAve,
    EnduranceMaxErr,
    WalkingMinAve,
    WalkingMinErr,
    WalkingGrowAve,
    WalkingGrowErr,
    WalkingMaxAve,
    WalkingMaxErr,
    EatWaterAmount,
    EatMeatAmount,
    EatPlantAmount,
    EatFoodType1,
    EatFoodType2,
    EatFoodType3,
    EatFoodType4,
    EatFoodType5,
    EatNutritionType1,
    EatNutritionType2,
    EatNutritionType3,
    EatNutritionAmount1,
    EatNutritionAmount2,
    EatNutritionAmount3,
    EatAvoidType1,
    EatAvoidType2,
    EatAvoidType3,
    EatAvoidAmount1,
    EatAvoidAmount2,
    EatAvoidAmount3,
    EatEndodisrDamage,
    EatEndodisrResolve,
    AbilitySpecialType1,
    AbilitySpecialPower1,
    AbilitySpecialType2,
    AbilitySpecialPower2,
    AbilitySpecialType3,
    AbilitySpecialPower3,
    AbilitySpecialType4,
    AbilitySpecialPower4,
    AbilitySpecialType5,
    AbilitySpecialPower5,
    NatureMinAve,
    NatureMinErr,
    NatureGrowAve,
    NatureGrowErr,
    NatureMaxAve,
    NatureMaxErr,
    IndepPursuitMinAve,
    IndepPursuitMinErr,
    IndepPursuitGrowAve,
    IndepPursuitGrowErr,
    IndepPursuitMaxAve,
    IndepPursuitMaxErr,
    IndepCapacityMinAve,
    IndepCapacityMinErr,
    IndepCapacityGrowAve,
    IndepCapacityGrowErr,
    IndepCapacityMaxAve,
    IndepCapacityMaxErr,
    BodyHeatAdaptType,
    BodyHeatMidSafeAve,
    BodyHeatMidSafeErr,
    BodyHeatMinSafeAve,
    BodyHeatMinSafeErr,
    BodyHeatMinRecoverAve,
    BodyHeatMinRecoverErr,
    BodyHeatMinRecoverCal,
    BodyHeatMinRecoverDam,
    BodyHeatMaxSafeAve,
    BodyHeatMaxSafeErr,
    BodyHeatMaxRecoverAve,
    BodyHeatMaxRecoverErr,
    BodyHeatMaxRecoverCal,
    BodyHeatMaxRevoverDam,
    ChildBirthType,
    ChildLookType,
    PriceAve
}


//㎪㎪㎪ 001001
public class CL_StuffEncyclopedia
{
    public char Updated = 'N';
    public int Serial0;
    public int Serial1;
    public int Serial2;
    public string Name;
    public long PriceAve;

    public CL_StuffEncyclopedia(int pm_Serial0, int pm_Serial1, int pm_Serial2, string pm_Name, long pm_PriceAve, char pm_Updated = 'N')
    {
        Updated = pm_Updated;
        Serial0 = pm_Serial0;
        Serial1 = pm_Serial1;
        Serial2 = pm_Serial2;
        Name = pm_Name;
        PriceAve = pm_PriceAve;
    }
}
//%_% Table_03 물건 사전

//㎪㎪㎪ 001002
public enum EM_FE
{
    CC_Nothing,
    CC_Count,
    CC_MaxSerial0,
    CC_MaxSerial1,
    CC_MaxSerial2,

    Updated,
    Serial0,
    Serial1,
    Serial2,
    Name,
    PriceAve,
}


//㎪㎪㎪ 001001
public class CL_NoticeEncyclopedia
{
    public char Updated = 'N';
    public int Serial0;
    public int Serial1;
    public int Serial2;

    public CL_NoticeEncyclopedia(int pm_Serial0, int pm_Serial1, int pm_Serial2, char pm_Updated = 'N')
    {
        Updated = pm_Updated;
        Serial0 = pm_Serial0;
        Serial1 = pm_Serial1;
        Serial2 = pm_Serial2;
    }
}
//%_% Table_04 소식 사전 ★Text

//㎪㎪㎪ 001002
public enum EM_NE
{
    CC_Nothing,
    CC_Count,
    CC_MaxSerial0,
    CC_MaxSerial1,
    CC_MaxSerial2,

    Updated,
    Serial0,
    Serial1,
    Serial2,
}


//㎪㎪㎪ 001001
public class CL_QuestEncyclopedia
{
    public char Updated = 'N';
    public int Serial0;
    public int Serial1;
    public int Serial2;

    public CL_QuestEncyclopedia(int pm_Serial0, int pm_Serial1, int pm_Serial2, char pm_Updated = 'N')
    {
        Updated = pm_Updated;
        Serial0 = pm_Serial0;
        Serial1 = pm_Serial1;
        Serial2 = pm_Serial2;
    }
}
//%_% Table_05 의뢰 사전 ★Text

//㎪㎪㎪ 001002
public enum EM_QE
{
    CC_Nothing,
    CC_Count,
    CC_MaxSerial0,
    CC_MaxSerial1,
    CC_MaxSerial2,

    Updated,
    Serial0,
    Serial1,
    Serial2,
}


//㎪㎪㎪ 001001
public class CL_DialogueEncyclopedia
{
    public char Updated = 'N';
    public int Serial0;
    public int Serial1;
    public int Serial2;

    public CL_DialogueEncyclopedia(int pm_Serial0, int pm_Serial1, int pm_Serial2, char pm_Updated = 'N')
    {
        Updated = pm_Updated;
        Serial0 = pm_Serial0;
        Serial1 = pm_Serial1;
        Serial2 = pm_Serial2;
    }
}
//%_% Table_06 대화 사전 ★Text

//㎪㎪㎪ 001002
public enum EM_DE
{
    CC_Nothing,
    CC_Count,
    CC_MaxSerial0,
    CC_MaxSerial1,
    CC_MaxSerial2,

    Updated,
    Serial0,
    Serial1,
    Serial2,
}


//㎪㎪㎪ 001001
public class CL_MailEncyclopedia
{
    public char Updated = 'N';
    public int Serial0;
    public int Serial1;
    public int Serial2;

    public CL_MailEncyclopedia(int pm_Serial0, int pm_Serial1, int pm_Serial2, char pm_Updated = 'N')
    {
        Updated = pm_Updated;
        Serial0 = pm_Serial0;
        Serial1 = pm_Serial1;
        Serial2 = pm_Serial2;
    }
}
//%_% Table_07 메일 사전 ★Text

//㎪㎪㎪ 001002
public enum EM_ME
{
    CC_Nothing,
    CC_Count,
    CC_MaxSerial0,
    CC_MaxSerial1,
    CC_MaxSerial2,

    Updated,
    Serial0,
    Serial1,
    Serial2
}


//㎪㎪㎪ 001001
public class CL_CounselEncyclopedia
{
    public char Updated = 'N';
    public int Serial0;
    public int Serial1;
    public int Serial2;

    public CL_CounselEncyclopedia(int pm_Serial0, int pm_Serial1, int pm_Serial2, char pm_Updated = 'N')
    {
        Updated = pm_Updated;
        Serial0 = pm_Serial0;
        Serial1 = pm_Serial1;
        Serial2 = pm_Serial2;
    }
}
//%_% Table_08 조언 사전 ★Text

//㎪㎪㎪ 001002
public enum EM_CE
{
    CC_Nothing,
    CC_Count,
    CC_MaxSerial0,
    CC_MaxSerial1,
    CC_MaxSerial2,

    Updated,
    Serial0,
    Serial1,
    Serial2
}


//㎪㎪㎪ 001001
public class CL_WarningEncyclopedia
{
    public char Updated = 'N';
    public int Serial0;
    public int Serial1;
    public int Serial2;

    public CL_WarningEncyclopedia(int pm_Serial0, int pm_Serial1, int pm_Serial2, char pm_Updated = 'N')
    {
        Updated = pm_Updated;
        Serial0 = pm_Serial0;
        Serial1 = pm_Serial1;
        Serial2 = pm_Serial2;
    }
}
//%_% Table_09 경고 사전 ★Text

//㎪㎪㎪ 001002
public enum EM_WE
{
    CC_Nothing,
    CC_Count,
    CC_MaxSerial0,
    CC_MaxSerial1,
    CC_MaxSerial2,

    Updated,
    Serial0,
    Serial1,
    Serial2,
}


//㎪㎪㎪ 001001 //@_@ 일부 내용 변경됨
public class CL_UserDataLobby
{
    public char Updated = 'N';
    public int Serial_0;
    public int Serial_1;
    public int Serial_2;
    public string Name;
    public DateTime DateRealCreate;
    public DateTime DateRealJoin;
    public DateTime DateInGame;
    public int StorylineKind;
    public int StorylineDifficulty;
    public int StorylineChallenge;
    public int CharacterOriginMainSerial;
    public int CharacterOriginSuppSerial;
    public int CharacterOriginAnmlSerial;
    public int CharacterNowMainSerial;
    public int CharacterNowSuppSerial;
    public int CharacterNowAnmlSerial;


    public CL_UserDataLobby(int pm_Serial_0, int pm_Serial_1, int pm_Serial_2, string pm_Name,
            string pm_DateRealCreate, string pm_DateRealJoin, string pm_DateInGame, int pm_StorylineKind, int pm_StorylineDifficulty, int pm_StorylineChallenge,
            int pm_CharacterOriginMainSerial, int pm_CharacterOriginSuppSerial, int pm_CharacterOriginAnmlSerial,
            int pm_CharacterNowMainSerial, int pm_CharacterNowSuppSerial, int pm_CharacterNowAnmlSerial, char pm_Updated = 'N')
    {
        Updated = pm_Updated;
        Serial_0 = pm_Serial_0;
        Serial_1 = pm_Serial_1;
        Serial_2 = pm_Serial_2;
        Name = pm_Name;
        DateRealCreate = Convert.ToDateTime(pm_DateRealCreate);
        DateRealJoin = Convert.ToDateTime(pm_DateRealJoin);
        DateInGame = Convert.ToDateTime(pm_DateInGame);
        StorylineKind = pm_StorylineKind;
        StorylineDifficulty = pm_StorylineDifficulty;
        StorylineChallenge = pm_StorylineChallenge;
        CharacterOriginMainSerial = pm_CharacterOriginMainSerial;
        CharacterOriginSuppSerial = pm_CharacterOriginSuppSerial;
        CharacterOriginAnmlSerial = pm_CharacterOriginAnmlSerial;
        CharacterNowMainSerial = pm_CharacterNowMainSerial;
        CharacterNowSuppSerial = pm_CharacterNowSuppSerial;
        CharacterNowAnmlSerial = pm_CharacterNowAnmlSerial;
    }
}
//%_% Table_10 유저 정보 요약하여 로비에 간단히 표시할 내용

//㎪㎪㎪ 001002
public enum EM_UL
{
    CC_Nothing,
    CC_Count,
    CC_MaxSerial0,
    CC_MaxSerial1,
    CC_MaxSerial2,

    Updated,
    Serial0,
    Serial1,
    Serial2,
    Name,
    DateRealCreate,
    DateRealJoin,
    DateInGame,
    StorylineKind,
    StorylineDifficulty,
    StorylineChallenge,
    CharacterOriginMainSerial,
    CharacterOriginSuppSerial,
    CharacterOriginAnmlSerial,
    CharacterNowMainSerial,
    CharacterNowSuppSerial,
    CharacterNowAnmlSerial,
}


//㎪㎪㎪ 001001 //@_@ 일부 내용 변경됨
public class CL_UserDataStat
{
    public char Updated = 'N';
    public int Serial0;
    public int Serial1;
    public int Serial2;
    public string Name;
    public DateTime DateRealCreate;
    public DateTime DateInJoin;
    public DateTime DateInGame;
    public int CharacterKind;
    public int CharacterCostumeNormal;
    public int CharacterCostumeChoice;
    public int CharacterGender;
    public long MoneyHave;
    public long ManaHave;
    public long FameHave;
    public long RearHave;
    public int AnimalHave;
    public int AnimalLeave;
    public int AchieveHave;
    public int ExistType;
    public int SiteRegion;
    public int SiteVillage;
    public int SiteBuilding;
    public int SiteRoom;
    public int SiteBox;
    public int SitePX;
    public int SitePY;
    public int SitePZ;
    public int SiteRX;
    public int SiteRY;
    public int SiteRZ;
    public int ImpressOfficial;
    public int ImpressIntimate;
    public int ImpressFame;

    public CL_UserDataStat(int pm_Serial0, int pm_Serial1, int pm_Serial2, string pm_Name, string pm_DateRealCreate, string pm_DateInJoin, string pm_DateInGame,
                                int pm_CharacterKind, int pm_CharacterCostumeNormal, int pm_CharacterCostumeChoice, int pm_CharacterGender,
                                long pm_MoneyHave, long pm_ManaHave, long pm_FameHave, long pm_RearHave,
                                int pm_AnimalHave, int pm_AnimalLeave, int pm_AchieveHave,
                                int pm_ExistType, int pm_SiteRegion, int pm_SiteVillage, int pm_SiteBuilding, int pm_SiteRoom, int pm_SiteBox,
                                int pm_SitePX, int pm_SitePY, int pm_SitePZ, int pm_SiteRX, int pm_SiteRY, int pm_SiteRZ,
                                int pm_ImpressOfficial, int pm_ImpressIntimate, int pm_ImpressFame, char pm_Updated = 'N')
    {
        Updated = pm_Updated;
        Serial0 = pm_Serial0;
        Serial1 = pm_Serial1;
        Serial2 = pm_Serial2;
        Name = pm_Name;
        DateRealCreate = Convert.ToDateTime(pm_DateRealCreate);
        DateInJoin = Convert.ToDateTime(pm_DateInJoin);
        DateInGame = Convert.ToDateTime(pm_DateInGame);
        CharacterKind = pm_CharacterKind;
        CharacterCostumeNormal = pm_CharacterCostumeNormal;
        CharacterCostumeChoice = pm_CharacterCostumeChoice;
        CharacterGender = pm_CharacterGender;
        MoneyHave = pm_MoneyHave;
        ManaHave = pm_ManaHave;
        FameHave = pm_FameHave;
        RearHave = pm_RearHave;
        AnimalHave = pm_AnimalHave;
        AnimalLeave = pm_AnimalLeave;
        AchieveHave = pm_AchieveHave;
        ExistType = pm_ExistType;
        SiteRegion = pm_SiteRegion;
        SiteVillage = pm_SiteVillage;
        SiteBuilding = pm_SiteBuilding;
        SiteRoom = pm_SiteRoom;
        SiteBox = pm_SiteBox;
        SitePX = pm_SitePX;
        SitePY = pm_SitePY;
        SitePZ = pm_SitePZ;
        SiteRX = pm_SiteRX;
        SiteRY = pm_SiteRY;
        SiteRZ = pm_SiteRZ;
        ImpressOfficial = pm_ImpressOfficial;
        ImpressIntimate = pm_ImpressIntimate;
        ImpressFame = pm_ImpressFame;
    }
}
//%_% Table_11 유저 계정 자체에 대한 자세한 정보와 통계

//㎪㎪㎪ 001002
public enum EM_US
{
    CC_Nothing,
    CC_Count,
    CC_MaxSerial0,
    CC_MaxSerial1,
    CC_MaxSerial2,

    Updated,
    Serial0,
    Serial1,
    Serial2,
    Name,
    DateRealCreate,
    DateInJoin,
    DateInGame,
    CharacterKind,
    CharacterCostumeNormal,
    CharacterCostumeChoice,
    CharacterGender,
    MoneyHave,
    ManaHave,
    FameHave,
    RearHave,
    AnimalHave,
    AnimalLeave,
    AchieveHave,
    ExistType,
    SiteRegion,
    SiteVillage,
    SiteBuilding,
    SiteRoom,
    SiteBox,
    SitePX,
    SitePY,
    SitePZ,
    SiteRX,
    SiteRY,
    SiteRZ,
    ImpressOfficial,
    ImpressIntimate,
    ImpressFame,
}


//㎪㎪㎪ 001001
public class CL_UserDataAnimal
{
    public char Updated = 'N';
    public int Serial0;
    public int Serial1;
    public int Serial2;
    public string Name;
    public int OwnerRoot;
    public int OwnerNow;
    public int Kind0;
    public int Kind1;
    public int Kind2;
    public int Kind3;
    public int Innate;
    public int Amount;
    public DateTime DateInGame;
    public int SiteRegion;
    public int SiteVillage;
    public int SiteBuilding;
    public int SiteRoom;
    public int SiteBox;
    public int SitePX;
    public int SitePY;
    public int SitePZ;
    public int SiteRX;
    public int SiteRY;
    public int SiteRZ;
    public int ImpressOfficial;
    public int ImpressIntimate;
    public int HealthNow;
    public int WalkingNow;


    public CL_UserDataAnimal(int pm_Serial0, int pm_Serial1, int pm_Serial2, string pm_Name, int pm_OwnerRoot, int pm_OwnerNow, int pm_Kind0,
                                int pm_Kind1, int pm_Kind2, int pm_Kind3, int pm_Innate, int pm_Amount, string pm_DateInGame,
                                int pm_SiteRegion, int pm_SiteVillage, int pm_SiteBuilding, int pm_SiteRoom, int pm_SiteBox,
                                int pm_SitePX, int pm_SitePY, int pm_SitePZ, int pm_SiteRX, int pm_SiteRY, int pm_SiteRZ,
                                int pm_ImpressOfficial, int pm_ImpressIntimate,
                                int pm_HealthNow, int pm_WalkingNow, char pm_Updated = 'N')
    {
        Updated = pm_Updated;
        Serial0 = pm_Serial0;
        Serial1 = pm_Serial1;
        Serial2 = pm_Serial2;
        Name = pm_Name;
        OwnerRoot = pm_OwnerRoot;
        OwnerNow = pm_OwnerNow;
        Kind0 = pm_Kind0;
        Kind1 = pm_Kind1;
        Kind2 = pm_Kind2;
        Kind3 = pm_Kind3;
        Innate = pm_Innate;
        Amount = pm_Amount;
        DateInGame = Convert.ToDateTime(pm_DateInGame);
        SiteRegion = pm_SiteRegion;
        SiteVillage = pm_SiteVillage;
        SiteBuilding = pm_SiteBuilding;
        SiteRoom = pm_SiteRoom;
        SiteBox = pm_SiteBox;
        SitePX = pm_SitePX;
        SitePY = pm_SitePY;
        SitePZ = pm_SitePZ;
        SiteRX = pm_SiteRX;
        SiteRY = pm_SiteRY;
        SiteRZ = pm_SiteRZ;
        ImpressOfficial = pm_ImpressOfficial;
        ImpressIntimate = pm_ImpressIntimate;
        HealthNow = pm_HealthNow;
        WalkingNow = pm_WalkingNow;
    }
}
//%_% Table_12 유저 동물들의 스텟 정보

//㎪㎪㎪ 001002
public enum EM_UA
{
    CC_Nothing,
    CC_Count,
    CC_MaxSerial0,
    CC_MaxSerial1,
    CC_MaxSerial2,

    Updated,
    Serial0,
    Serial1,
    Serial2,
    Name,
    OwnerRoot,
    OwnerNow,
    Kind0,
    Kind1,
    Kind2,
    Kind3,
    Innate,
    Amount,
    DateInGame,
    SiteRegion,
    SiteVillage,
    SiteBuilding,
    SiteRoom,
    SiteBox,
    SitePX,
    SitePY,
    SitePZ,
    SiteRX,
    SiteRY,
    SiteRZ,
    ImpressOfficial,
    ImpressIntimate,
    HealthNow,
    WalkingNow,
}


//㎪㎪㎪ 001001
public class CL_UserDataStuff
{
    public char Updated = 'N';
    public int Serial0;
    public int Serial1;
    public int Serial2;
    public string Name;
    public int OwnerRoot;
    public int OwnerNow;
    public int Kind0; // StuffEncyclopediaAbsolute의 Serial0
    public int Kind1;
    public int Kind2;
    public int Kind3;
    public int Innate;
    public int Amount;
    public DateTime DateInGame;
    public int Durability;
    public int Activing;
    public int ImpressOfficial;
    public int ImpressIntimate;


    public CL_UserDataStuff(int pm_Serial0, int pm_Serial1, int pm_Serial2, string pm_Name, int pm_OwnerRoot, int pm_OwnerNow, int pm_Kind0, int pm_Kind1,
                                int pm_Kind2, int pm_Kind3, int pm_Innate, int pm_Amount, string pm_DateInGame, int pm_Durability, int pm_Activing,
                                int pm_ImpressOfficial, int pm_ImpressIntimate, char pm_Updated = 'N')
    {
        Updated = pm_Updated;
        Serial0 = pm_Serial0;
        Serial1 = pm_Serial1;
        Serial2 = pm_Serial2;
        Name = pm_Name;
        OwnerRoot = pm_OwnerRoot;
        OwnerNow = pm_OwnerNow;
        Kind0 = pm_Kind0;
        Kind1 = pm_Kind1;
        Kind2 = pm_Kind2;
        Kind3 = pm_Kind3;
        Innate = pm_Innate;
        Amount = pm_Amount;
        DateInGame = Convert.ToDateTime(pm_DateInGame);
        Durability = pm_Durability;
        Activing = pm_Activing;
        ImpressOfficial = pm_ImpressOfficial;
        ImpressIntimate = pm_ImpressIntimate;
    }
}
// Table_13

//㎪㎪㎪ 001002
public enum EM_UF
{
    CC_Nothing,
    CC_Count,
    CC_MaxSerial0,
    CC_MaxSerial1,
    CC_MaxSerial2,

    Updated,
    Serial0,
    Serial1,
    Serial2,
    Name,
    OwnerRoot,
    OwnerNow,
    Kind0,
    Kind1,
    Kind2,
    Kind3,
    Innate,
    Amount,
    DateInGame,
    Durability,
    Activing,
    ImpressOfficial,
    ImpressIntimate,
}


//㎪㎪㎪ 001001
public class CL_UserDataNotice
{
    public char Updated = 'N';
    public int Serial0;
    public int Serial1;
    public int Serial2;
    public int Kind0;
    public int Kind1;
    public int Kind2;
    public int Kind3;
    public int Kind4;
    public int Kind5;
    public int Kind6;
    public int Kind7;
    public int Innate;
    public DateTime DateInGame;
    public int NameFrom;
    public int NameWith;
    public int NameTo;
    public string Content;

    public CL_UserDataNotice(int pm_Serial0, int pm_Serial1, int pm_Serial2, int pm_Kind0, int pm_Kind1, int pm_Kind2, int pm_Kind3, int pm_Kind4, int pm_Kind5, int pm_Kind6, int pm_Kind7, int pm_Innate,
        string pm_DateInGame, int pm_NameFrom, int pm_NameWith, int pm_NameTo, string pm_Content, char pm_Updated = 'N')
    {
        Updated = pm_Updated;
        Serial0 = pm_Serial0;
        Serial1 = pm_Serial1;
        Serial2 = pm_Serial2;
        Kind0 = pm_Kind0;
        Kind1 = pm_Kind1;
        Kind2 = pm_Kind2;
        Kind3 = pm_Kind3;
        Kind4 = pm_Kind4;
        Kind5 = pm_Kind5;
        Kind6 = pm_Kind6;
        Kind7 = pm_Kind7;
        Innate = pm_Innate;
        DateInGame = Convert.ToDateTime(pm_DateInGame);
        NameFrom = pm_NameFrom;
        NameWith = pm_NameWith;
        NameTo = pm_NameTo;
        Content = pm_Content;
    }
}
// Table_14

//㎪㎪㎪ 001002
public enum EM_UN
{
    CC_Nothing,
    CC_Count,
    CC_MaxSerial0,
    CC_MaxSerial1,
    CC_MaxSerial2,

    Updated,
    Serial0,
    Serial1,
    Serial2,
    Kind0,
    Kind1,
    Kind2,
    Kind3,
    Kind4,
    Kind5,
    Kind6,
    Kind7,
    Innate,
    DateInGame,
    NameFrom,
    NameWith,
    NameTo,
    Content,
}


//㎪㎪㎪ 001001
public class CL_UserDataQuest
{
    public char Updated = 'N';
    public int Serial0;
    public int Serial1;
    public int Serial2;

    public CL_UserDataQuest(int pm_Serial0, int pm_Serial1, int pm_Serial2, char pm_Updated = 'N')
    {
        Updated = pm_Updated;
        Serial0 = pm_Serial0;
        Serial1 = pm_Serial1;
        Serial2 = pm_Serial2;
    }
}
// Table_15

//㎪㎪㎪ 001002
public enum EM_UQ
{
    CC_Nothing,
    CC_Count,
    CC_MaxSerial0,
    CC_MaxSerial1,
    CC_MaxSerial2,

    Updated,
    Serial0,
    Serial1,
    Serial2
}



//㎪㎪㎪ 001001
public class CL_UserDataDialogue
{
    public char Updated = 'N';
    public int Serial0;
    public int Serial1;
    public int Serial2;

    public CL_UserDataDialogue(int pm_Serial0, int pm_Serial1, int pm_Serial2, char pm_Updated = 'N')
    {
        Updated = pm_Updated;
        Serial0 = pm_Serial0;
        Serial1 = pm_Serial1;
        Serial2 = pm_Serial2;
    }
}
// Table_16

//㎪㎪㎪ 001002
public enum EM_UD
{
    CC_Nothing,
    CC_Count,
    CC_MaxSerial0,
    CC_MaxSerial1,
    CC_MaxSerial2,

    Updated,
    Serial0,
    Serial1,
    Serial2
}


//㎪㎪㎪ 001001
public class CL_UserDataMail
{
    public char Updated = 'N';
    public int Serial0;
    public int Serial1;
    public int Serial2;
    public int Kind0;
    public int Kind1;
    public int Kind2;
    public int Kind3;
    public int Innate;
    public DateTime DateInGame;
    public int NameFrom;
    public int NameWith;
    public int NameTo;
    public string Content;

    public CL_UserDataMail(int pm_Serial0, int pm_Serial1, int pm_Serial2, int pm_Kind0, int pm_Kind1, int pm_Kind2, int pm_Kind3, int pm_Innate,
        string pm_DateInGame, int pm_NameFrom, int pm_NameWith, int pm_NameTo, string pm_Content, char pm_Updated = 'N')
    {
        Updated = pm_Updated;
        Serial0 = pm_Serial0;
        Serial1 = pm_Serial1;
        Serial2 = pm_Serial2;
        Kind0 = pm_Kind0;
        Kind1 = pm_Kind1;
        Kind2 = pm_Kind2;
        Kind3 = pm_Kind3;
        Innate = pm_Innate;
        DateInGame = Convert.ToDateTime(pm_DateInGame);
        NameFrom = pm_NameFrom;
        NameWith = pm_NameWith;
        NameTo = pm_NameTo;
        Content = pm_Content;
    }
}
// Table_17

//㎪㎪㎪ 001002
public enum EM_UM
{
    CC_Nothing,
    CC_Count,
    CC_MaxSerial0,
    CC_MaxSerial1,
    CC_MaxSerial2,

    Updated,
    Serial0,
    Serial1,
    Serial2,
    Kind0,
    Kind1,
    Kind2,
    Kind3,
    Innate,
    DateInGame,
    NameFrom,
    NameWith,
    NameTo,
    Content,
}


//㎪㎪㎪ 001001
public class CL_UserDataCounsel
{
    public char Updated = 'N';
    public int Serial0;
    public int Serial1;
    public int Serial2;

    public CL_UserDataCounsel(int pm_Serial0, int pm_Serial1, int pm_Serial2, char pm_Updated = 'N')
    {
        Updated = pm_Updated;
        Serial0 = pm_Serial0;
        Serial1 = pm_Serial1;
        Serial2 = pm_Serial2;
    }
}
// Table_18

//㎪㎪㎪ 001002
public enum EM_UC
{
    CC_Nothing,
    CC_Count,
    CC_MaxSerial0,
    CC_MaxSerial1,
    CC_MaxSerial2,

    Updated,
    Serial0,
    Serial1,
    Serial2
}


//㎪㎪㎪ 001001
public class CL_UserDataWarning
{
    public char Updated = 'N';
    public int Serial0;
    public int Serial1;
    public int Serial2;

    public CL_UserDataWarning(int pm_Serial0, int pm_Serial1, int pm_Serial2, char pm_Updated = 'N')
    {
        Updated = pm_Updated;
        Serial0 = pm_Serial0;
        Serial1 = pm_Serial1;
        Serial2 = pm_Serial2;
    }
}
// Table_19

//㎪㎪㎪ 001002
public enum EM_UW
{
    CC_Nothing,
    CC_Count,
    CC_MaxSerial0,
    CC_MaxSerial1,
    CC_MaxSerial2,

    Updated,
    Serial0,
    Serial1,
    Serial2
}



// 옵션 저장 클래스는 보류

//&_& 엑셀에 추가 안 했음
/*
public class CL_ManagerScript
{
    public SC_SY_DB_Manager DB_Manager = null;
    public SC_SY_UI_Manager UI_Manager = null;

    public CL_ManagerScript()
    {

    }
}
*/


public class CL_VarTemp
{
    public char[] char_Array = new char[4];
    public int[] int_Array = new int[4];
    public long[] long_Array = new long[4];
    public float[] float_Array = new float[4];
    public string[] string_Array = new string[4];
    public DateTime[] DateTime_Array = new DateTime[4];


    public CL_VarTemp()
    {
        for (int i = 0; i < 4; i++)
        {
            char_Array[i] = ' ';
            int_Array[i] = 0;
            long_Array[i] = 0;
            float_Array[i] = 0.0f;
            string_Array[i] = "";
            DateTime_Array[i] = Convert.ToDateTime("00:00:00");
        }
    }

    public CL_VarTemp(char pm_a, char pm_b = ' ', char pm_c = ' ', char pm_d = ' ')
    {
        char_Array[0] = pm_a;
        char_Array[1] = pm_b;
        char_Array[2] = pm_c;
        char_Array[3] = pm_d;
    }

    public CL_VarTemp(int pm_a, int pm_b = 0, int pm_c = 0, int pm_d = 0)
    {
        int_Array[0] = pm_a;
        int_Array[1] = pm_b;
        int_Array[2] = pm_c;
        int_Array[3] = pm_d;
    }

    public CL_VarTemp(long pm_a, long pm_b = 0, long pm_c = 0, long pm_d = 0)
    {
        long_Array[0] = pm_a;
        long_Array[1] = pm_b;
        long_Array[2] = pm_c;
        long_Array[3] = pm_d;
    }

    public CL_VarTemp(float pm_a, float pm_b = 0.0f, float pm_c = 0.0f, float pm_d = 0.0f)
    {
        float_Array[0] = pm_a;
        float_Array[1] = pm_b;
        float_Array[2] = pm_c;
        float_Array[3] = pm_d;
    }

    public CL_VarTemp(string pm_a, string pm_b = "", string pm_c = "", string pm_d = "")
    {
        string_Array[0] = pm_a;
        string_Array[1] = pm_b;
        string_Array[2] = pm_c;
        string_Array[3] = pm_d;
    }
}



// --------------------------------------------------





// @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ ^_^01 클래스
// @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ ^_^02 메인


public class SC_SY_DB_Manager : MonoBehaviour
{    
    public static List<CL_TableManager> TM_List = new List<CL_TableManager>(); // 01
    public static List<CL_AnimalEncyclopedia> AE_List = new List<CL_AnimalEncyclopedia>();
    public static List<CL_StuffEncyclopedia> FE_List = new List<CL_StuffEncyclopedia>();
    public static List<CL_NoticeEncyclopedia> NE_List = new List<CL_NoticeEncyclopedia>();
    public static List<CL_QuestEncyclopedia> QE_List = new List<CL_QuestEncyclopedia>();
    public static List<CL_DialogueEncyclopedia> DE_List = new List<CL_DialogueEncyclopedia>(); // 06
    public static List<CL_MailEncyclopedia> ME_List = new List<CL_MailEncyclopedia>();
    public static List<CL_CounselEncyclopedia> CE_List = new List<CL_CounselEncyclopedia>();
    public static List<CL_WarningEncyclopedia> WE_List = new List<CL_WarningEncyclopedia>();
    public static List<CL_UserDataLobby> UL_List = new List<CL_UserDataLobby>();

    public static List<CL_UserDataStat> US_List = new List<CL_UserDataStat>(); // 11
    public static List<CL_UserDataAnimal> UA_List = new List<CL_UserDataAnimal>();
    public static List<CL_UserDataStuff> UF_List = new List<CL_UserDataStuff>();
    public static List<CL_UserDataNotice> UN_List = new List<CL_UserDataNotice>();
    public static List<CL_UserDataQuest> UQ_List = new List<CL_UserDataQuest>();
    public static List<CL_UserDataDialogue> UD_List = new List<CL_UserDataDialogue>(); // 16
    public static List<CL_UserDataMail> UM_List = new List<CL_UserDataMail>();
    public static List<CL_UserDataCounsel> UC_List = new List<CL_UserDataCounsel>();
    public static List<CL_UserDataWarning> UW_List = new List<CL_UserDataWarning>();





    private void Awake()
    {
        SC_SY_MA_Storage.OB_SY_DB = gameObject;
        SC_SY_MA_Storage.OB_SY_DB_SCRIPT = transform.GetComponent<SC_SY_DB_Manager>();
        Add_User_Stat();
        DontDestroyOnLoad(this.gameObject);
        // DB_Start();
    }



    public void SY_UserCreate(string pm_DBName, int pm_Serial_0, int pm_StorylineKind)
    {
        int k00 = pm_Serial_0;
        int k01 = pm_Serial_0;
        int k02 = pm_Serial_0;
        string k03 = "캐릭터" + pm_Serial_0.ToString();
        string k04 = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        string k05 = "2001-01-01 09:00:00";
        string k06 = "2001-01-01 09:00:00";
        int k07 = pm_StorylineKind;
        int k08 = 1;
        int k09 = 1;
        int k10 = 0;
        int k11 = -1;
        int k12 = -1;
        int k13 = 0;
        int k14 = -1;
        int k15 = -1;


        DB_VA_Add_UL_List(new CL_UserDataLobby(k00, k01, k02, k03, k04, k05, k06, k07, k08, k09, k10, k11, k12, k13, k14, k15));
    }
        //㎪㎪㎪ 001007
    public void DB_VA_Add_UL_List(CL_UserDataLobby pm_a)
    {
        UL_List.Add(pm_a);
    }


    public void Add_User_Stat()
    {
        DB_VA_Add_US_List(new CL_UserDataStat(0,0,0,"2001-01-01 09:00:00","2001-01-01 09:00:00","2001-01-01 09:00:00","2001-01-01 09:00:00",0,0,0,0,89000,2300,1200,500,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0));
        DB_VA_Add_US_List(new CL_UserDataStat(0,0,0,"2001-01-01 09:00:00","2001-01-01 09:00:00","2001-01-01 09:00:00","2001-01-01 09:00:00",0,0,0,0,124000,3500,710,2600,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0));
    }


    public void DB_VA_Add_US_List(CL_UserDataStat pm_a)
    {
        US_List.Add(pm_a);
    }




    public static int Return_UL_List_Serial_2(int pm_a)
    {
        int lc_a = -1;
        for(lc_a = 0; lc_a<UL_List.Count; lc_a++)
        {
            if(UL_List[lc_a].Serial_2 == pm_a)
            {
                return lc_a;
            }
        }
        return -1;
    }



}