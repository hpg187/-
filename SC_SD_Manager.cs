using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC_SD_Manager : MonoBehaviour
{
    private void Awake()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            DontDestroyOnLoad(this.gameObject);
        }
        SC_SY_MA_Storage.OB_SD = gameObject;
    }
    
    void Start()
    {
        
    }

}
