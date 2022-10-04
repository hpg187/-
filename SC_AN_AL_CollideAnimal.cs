using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_AN_AL_CollideAnimal : SC_AL_AnyCollideReceive_Center
{




    public override void Send_MouseAttachCollide()
    {
        SC_SY_MA_Storage.OB_UI.transform.GetChild(4).GetChild(0).GetComponent<SC_UI_0004_Manager>().DetailExplain_Target = gameObject;
        SC_SY_MA_Storage.OB_UI.transform.GetChild(4).GetChild(0).GetComponent<SC_UI_0004_Manager>().DetailExplain_SetExplain(0, 1, gameObject);

        SC_SY_MA_Storage.OB_EV_SCRIPT.CameraMonopod_Animal.GetComponent<SC_EV_CA_Thing>().AttachTarget = transform;
        


        // SC_SY_MA_Storage.OB_UI.transform.GetChild(4).GetChild(0).GetChild(2).gameObject.GetComponent<Image>().sprite = transform.GetComponent<SC_AN_AL_Status>().ProfileIcon;
        // SC_SY_MA_Storage.OB_EV.transform.GetChild(0).GetChild(2).GetComponent<SC_EV_CA_Thing>().AttachTarget = transform;
        // SC_SY_MA_Storage.OB_UI.transform.GetChild(4).GetChild(0).GetChild(2).gameObject.SetActive(true);
    }
}