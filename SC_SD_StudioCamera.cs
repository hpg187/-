using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_SD_StudioCamera : MonoBehaviour
{
    public Coroutine Update_Doing;

    public int AttachRole = -1;


    void Start()
    {
        Update_Doing = StartCoroutine(Update_Going());
    }

    IEnumerator Update_Going()
    {
        while(true)
        {
            switch(AttachRole)
            {
                case 1:
                case 2:
                    transform.position = new Vector3(SC_SY_MA_Storage.OB_MainCameraFreePoint.transform.position.x, transform.position.y, SC_SY_MA_Storage.OB_MainCameraFreePoint.transform.position.z);
                    break;
                case 3:
                    // if(SC_SY_MA_Storage.OB_EV_SCRIPT.CameraMonopod_Animal != null && SC_SY_MA_Storage.OB_EV_SCRIPT.CameraMonopod_Animal.GetComponent<SC_EV_CA_Thing>().AttachTarget != null)
                    if(SC_SY_MA_Storage.OB_UI.transform.GetChild(4).GetChild(0).GetComponent<SC_UI_0004_Manager>().DetailExplain_Target != null)
                    {
                        transform.position = new Vector3(SC_SY_MA_Storage.OB_UI.transform.GetChild(4).GetChild(0).GetComponent<SC_UI_0004_Manager>().DetailExplain_Target.transform.position.x+1, SC_SY_MA_Storage.OB_UI.transform.GetChild(4).GetChild(0).GetComponent<SC_UI_0004_Manager>().DetailExplain_Target.transform.position.y+2, SC_SY_MA_Storage.OB_UI.transform.GetChild(4).GetChild(0).GetComponent<SC_UI_0004_Manager>().DetailExplain_Target.transform.position.z-1);
                    }
                    break;
                default:
                    break;
            }
            
            
            yield return null;
        }
    }
    

}
