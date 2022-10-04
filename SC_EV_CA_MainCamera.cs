using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_EV_CA_MainCamera : MonoBehaviour
{
    private void Awake()
    {
        SC_SY_MA_Storage.OB_MainCameraHead = gameObject;
        SC_SY_MA_Storage.OB_MainCameraHead_CAMERA = transform.GetComponent<Camera>();
    }

    void Start()
    {

    }


}
