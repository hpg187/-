using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_EV_PR_MouseDragCollider_01 : MonoBehaviour
{
    public float RemoveTimer = 1f;
    public Coroutine SuturePacking_Doing = null;


    void Start()
    {
        
    }



    public void SuturePackingTry()
    {
        SuturePacking_Doing = StartCoroutine(SuturePacking_Going());
    }

    IEnumerator SuturePacking_Going()
    {
        Renderer lc_a = transform.GetComponent<Renderer>();
        float lc_b = lc_a.material.color.a;
        while(RemoveTimer > 0)
        {
            lc_a.material.color = new Color(lc_a.material.color.r, lc_a.material.color.g, lc_a.material.color.b, Mathf.Lerp(0, lc_b, RemoveTimer));

            RemoveTimer -= Time.deltaTime * 1f;
            yield return null;
        }

        SuturePacking_Doing = null;

        Destroy(gameObject);

        yield break;
    }

}