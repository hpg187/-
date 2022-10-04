using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_ST_Floor_AL_Thing : SC_AL_AnyCollideReceive_Center
{
    public int ObjectDesignType = -1; // 1 = 1:1:1:1:1:1형 , 2 = 복합형
    public int Equipable_Max = -1;
    public Sprite ProfileIcon_Common_Poss;
    public string ThingName_Text;
    public int ThingPrice_Money = -1;
    

    [SerializeField]
    public int[] ReturnChild_Distort = new int[6];

    void Start()
    {
        
    }


    public GameObject ReturnChild_Value(int pm_a)
    {
        return transform.GetChild(0).GetChild(ReturnChild_Distort[pm_a]).gameObject;
    }




    public void ChangeObject_Try(int pm_a, GameObject pm_b)
    {
        switch(pm_a)
        {
            case -1:
                break;
            default:
                ChangeObject_Treat(pm_a, pm_b);
                break;
        }
    }


    public void ChangeObject_Treat(int pm_a, GameObject pm_b)
    {
        Destroy(transform.GetChild(0).GetChild(ReturnChild_Distort[pm_a]).GetChild(0));
        Instantiate(pm_b,transform.GetChild(0).GetChild(ReturnChild_Distort[pm_a]));
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
                /*
                if(transform.GetChild(0).GetChild(4).childCount < Equipable_Max)
                {
                */
                    SC_SY_MA_Storage.OB_MouseAttachCollidingCenter = gameObject;
                    Send_MouseAttachCollide();

                //#_# Instantiate(SC_SY_MA_Storage.__Storage.ST_Floor_Prefeb[0],new Vector3(0f, 0f, 0f), new Quaternion(0f, 0f, 0f, 0f),transform.GetChild(0).GetChild(4));
                /*
                }
                */
                break;
            default :
                break;
        }
    }







    public override void Send_MouseAttachCollide()
    {
        SC_SY_MA_Storage.OB_UI.transform.GetChild(4).GetChild(0).GetComponent<SC_UI_0004_Manager>().DetailExplain_Target = gameObject;
        SC_SY_MA_Storage.OB_UI.transform.GetChild(4).GetChild(0).GetComponent<SC_UI_0004_Manager>().DetailExplain_SetExplain(0, 3, gameObject);
    }



}
