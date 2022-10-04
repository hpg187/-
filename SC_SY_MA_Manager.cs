using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SC_SY_MA_Manager : MonoBehaviour
{
    public SC_SY_MA_Storage Storage;

    private void Awake()
    {
        SC_SY_MA_Storage.__Storage = Storage;
        DontDestroyOnLoad(this.gameObject);
        // DB_Start();
    }

}
