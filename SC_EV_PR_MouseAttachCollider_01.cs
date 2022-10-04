using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_EV_PR_MouseAttachCollider_01 : MonoBehaviour
{
    private void Awake()
    {
        SC_SY_MA_Storage.OB_MouseAttachCollider = gameObject;
    }

    void Start()
    {
        
    }
}
