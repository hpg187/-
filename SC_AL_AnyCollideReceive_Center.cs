using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_AL_AnyCollideReceive_Center : MonoBehaviour
{




    void Start()
    {
        
    }



    public virtual void Receive_MouseTouchCollide(int pm_a, RaycastHit pm_b)
    {        
        switch(pm_a)
        {
            case -1 :
                break;
            case 0 :
                break;
            case 1 :
                SC_SY_MA_Storage.OB_MouseTouchCollidingCenter = gameObject;
                break;
            default :
                break;
        }
    }

    public virtual void Receive_MouseChooseCollide(int pm_a, RaycastHit pm_b)
    {
        switch(pm_a)
        {
            case -1 :
                break;
            case 0 :
                break;
            case 1 :
                SC_SY_MA_Storage.OB_MouseChooseCollidingCenter = gameObject;
                break;
            default :
                break;
        }
    }

    public virtual void Receive_MouseAttachCollide(int pm_a, RaycastHit pm_b)
    {
        switch(pm_a)
        {
            case -1 :
                break;
            case 0 :
                break;
            case 1 :
                SC_SY_MA_Storage.OB_MouseAttachCollidingCenter = gameObject;
                Send_MouseAttachCollide();
                break;
            default :
                break;
        }
    }

    public virtual void Receive_MouseDetachCollide(int pm_a, RaycastHit pm_b)
    {
        switch(pm_a)
        {
            case -1 :
                break;
            case 0 :
                break;
            case 1 :
                SC_SY_MA_Storage.OB_MouseDetachCollidingCenter = gameObject;
                break;
            default :
                break;
        }
    }



    public virtual void Send_MouseAttachCollide()
    {
        // SC_SY_MA_Storage.OB_UI.transform.GetChild(4).GetChild(0).GetChild(2).gameObject.SetActive(false);
    }
}