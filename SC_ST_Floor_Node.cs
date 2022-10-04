using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SC_ST_Floor_Node : MonoBehaviour
{

    public void Test_Change()
    {
        Destroy(transform.GetChild(0).gameObject);
        int lc_a = Random.Range(1,9);
        Debug.Log(lc_a);
        Instantiate(SC_SY_MA_Storage.__Storage.ST_Floor_Prefeb[lc_a], transform);
        SC_SY_DB_Manager.US_List[SC_SY_MA_Storage.LogInUserStatSerial].MoneyHave -= 1000;
        transform.parent.GetComponent<NavMeshSurface>().BuildNavMesh();
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
