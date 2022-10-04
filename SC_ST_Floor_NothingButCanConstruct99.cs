using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_ST_Floor_NothingButCanConstruct99 : SC_AL_AnyCollideReceive_Center
{
    void Start()
    {
        
    }




        public override void Receive_MouseAttachCollide(int pm_a, RaycastHit pm_b)
    {
        switch(pm_a)
        {
            case -1 :
                break;
            case 0 :
                break;
            case 1 :
                
                if(transform.GetChild(0).GetChild(4).childCount == 0)
                {
                    SC_SY_MA_Storage.OB_MouseAttachCollidingCenter = gameObject;
                    Send_MouseAttachCollide();

                //#_# Instantiate(SC_SY_MA_Storage.__Storage.ST_Floor_Prefeb[0],new Vector3(0f, 0f, 0f), new Quaternion(0f, 0f, 0f, 0f),transform.GetChild(0).GetChild(4));
                }
                break;
            default :
                break;
        }
    }
}
