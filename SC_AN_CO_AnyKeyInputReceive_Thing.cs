using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_AN_CO_AnyKeyInputReceive_Thing : SC_AL_AnyKeyInputReceive_Center
{    
    public SC_AN_AL_Thing FitComp;

    void Start()
    {
        FitComp = transform.GetComponent<SC_AN_AL_Thing>();
    }



    public override void Receiving_Keyboard_W(float pm_a)
    {
        Combining_Keyboard_WS(pm_a);
    }

    public override void Receiving_Keyboard_S(float pm_a)
    {
        Combining_Keyboard_WS(-pm_a);
    }

    public override void Receiving_Keyboard_A(float pm_a)
    {
        Combining_Keyboard_AD(pm_a);
    }

    public override void Receiving_Keyboard_D(float pm_a)
    {
        Combining_Keyboard_AD(-pm_a);
    }



    public override void Receiving_MouseClick_R(float pm_a)
    {
        FitComp.Receiving_MouseClick_R(pm_a);
    }





    public void Combining_Keyboard_WS(float pm_a)
    {
        FitComp.Receiving_Keyboard_WS(pm_a);
    }

    public void Combining_Keyboard_AD(float pm_a)
    {
        FitComp.Receiving_Keyboard_AD(pm_a);
    }
}