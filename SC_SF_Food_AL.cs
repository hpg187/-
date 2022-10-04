using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_SF_Food_AL : SC_SF_AL_Thing
{
    public float FoodAmount = -1;

    public Coroutine Update_Doing;

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


                if(FoodAmount <= 0)
                {
                    for(int lc_a = 0; lc_a < SC_SY_MA_Storage.OB_SF_SCRIPT.RemainFoodList.Count; lc_a++)
                    {
                        if(SC_SY_MA_Storage.OB_SF_SCRIPT.RemainFoodList[lc_a] == this.gameObject)
                        {
                            SC_SY_MA_Storage.OB_SF_SCRIPT.RemainFoodList.RemoveAt(lc_a);
                            Destroy(this.gameObject);
                            break;
                        }
                    }
                }
            }

            yield return null;
        }

    }
}
