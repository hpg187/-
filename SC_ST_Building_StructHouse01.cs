using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_ST_Building_StructHouse01 : SC_AL_AnyCollideReceive_Center
{
    void Start()
    {
        
    }

    void Update()
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
                SC_SY_MA_Storage.OB_MouseAttachCollidingCenter = gameObject;
                break;
            default :
                break;
        }

        if(SC_SY_MA_Storage.OB_UI.transform.GetComponent<SC_UI_Manager>().DoingAnyMainThing == null)
        {
            SC_SY_MA_Storage.OB_UI.transform.GetChild(2).GetChild(0).GetComponent<SC_UI_0002_Manager>().AccountMenu_SetOpen(0, 1);
        }

    }
}
