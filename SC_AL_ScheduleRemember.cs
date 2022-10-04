using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_AL_ScheduleRemember : MonoBehaviour
{
    public List<bool> Schedule_Important = new List<bool>();
    public List<GameObject> Schedule_Target = new List<GameObject>();
    public List<int> Schedule_Purpose = new List<int>();
    public List<float> Schedule_Amount = new List<float>();

    public void Add_First(bool pm_a = false, GameObject pm_b = null, int pm_c = 0, float pm_d = 0)
    {
        if(Schedule_Target.Count == 0)
        {
            Add_Last(pm_a, pm_b, pm_c, pm_d);
        }
        else
        {
            Schedule_Important.Insert(0,pm_a);
            Schedule_Target.Insert(0,pm_b);
            Schedule_Purpose.Insert(0,pm_c);
            Schedule_Amount.Insert(0,pm_d);
        }
    }

    public void Add_Last(bool pm_a = false, GameObject pm_b = null, int pm_c = 0, float pm_d = 0)
    {
        Schedule_Important.Add(pm_a);
        Schedule_Target.Add(pm_b);
        Schedule_Purpose.Add(pm_c);
        Schedule_Amount.Add(pm_d);
    }

    void Start()
    {
        
    }
}