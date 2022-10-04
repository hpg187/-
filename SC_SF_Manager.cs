using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_SF_Manager : MonoBehaviour
{
    public List<GameObject> RemainFoodList = new List<GameObject>();
    public List<GameObject> RemainBallList = new List<GameObject>();

    public void FindAndRemoveFood(GameObject pm_a)
    {
        for(int lc_a = 0; lc_a < RemainFoodList.Count; lc_a++)
        {
            if(RemainFoodList[lc_a] == pm_a)
            {
                RemainFoodList.RemoveAt(lc_a);
                break;
            }
        }
    }



    void Awake()
    {
        SC_SY_MA_Storage.OB_SF = gameObject;
        SC_SY_MA_Storage.OB_SF_SCRIPT = transform.GetComponent<SC_SF_Manager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
