using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SC_AL_MouseCollideReceive_Center : MonoBehaviour
{
    public int DepthFromCenter = 0;


    /*%_%
    private void OnMouseDown()
    {
        if(EventSystem.current.IsPointerOverGameObject() == false)
        {
            SC_SY_MA_Storage.FindCenterByDepth(DepthFromCenter+1, transform).GetComponent<SC_ST_Floor_Node>().Test_Change();
        }
    }
    */






    public void MouseTouchCollideReceiving(int pm_a, RaycastHit pm_b)
    {
        switch(pm_a)
        {
            case -1 :
                break;
            case 0 :
                break;
            case 1 :
                SC_SY_MA_Storage.OB_MouseTouchCollidingPart = gameObject;
                break;
            default :
                break;
        }

        SC_SY_MA_Storage.FindCenterByDepth(DepthFromCenter, transform).GetComponent<SC_AL_AnyCollideReceive_Center>().Receive_MouseTouchCollide(pm_a, pm_b);
    }

    public void MouseChooseCollideReceiving(int pm_a, RaycastHit pm_b)
    {
        switch(pm_a)
        {
            case -1 :
                break;
            case 0 :
                break;
            case 1 :
                SC_SY_MA_Storage.OB_MouseChooseCollidingPart = gameObject;
                break;
            default :
                break;
        }

        SC_SY_MA_Storage.FindCenterByDepth(DepthFromCenter, transform).GetComponent<SC_AL_AnyCollideReceive_Center>().Receive_MouseChooseCollide(pm_a, pm_b);
    }

    public void MouseAttachCollideReceiving(int pm_a, RaycastHit pm_b)
    {
        switch(pm_a)
        {
            case -1 :
                break;
            case 0 :
                break;
            case 1 :
                SC_SY_MA_Storage.OB_MouseAttachCollidingPart = gameObject;
                break;
            default :
                break;
        }

        SC_SY_MA_Storage.FindCenterByDepth(DepthFromCenter, transform).GetComponent<SC_AL_AnyCollideReceive_Center>().Receive_MouseAttachCollide(pm_a, pm_b);
    }

    public void MouseDetachCollideReceiving(int pm_a, RaycastHit pm_b)
    {
        switch(pm_a)
        {
            case -1 :
                break;
            case 0 :
                break;
            case 1 :
                SC_SY_MA_Storage.OB_MouseDetachCollidingPart = gameObject;
                break;
            default :
                break;
        }

        SC_SY_MA_Storage.FindCenterByDepth(DepthFromCenter, transform).GetComponent<SC_AL_AnyCollideReceive_Center>().Receive_MouseDetachCollide(pm_a, pm_b);
    }







    //*_* 아마도 제외

    /*
    public Coroutine MouseTouchDoing = null;
    public Coroutine MouseChooseDoing = null;


    public void MouseTouchTry()
    {
        if(MouseTouchDoing != null)
        {
            StartCoroutine(MouseTouchGoing());
        }
    }

    IEnumerator MouseTouchGoing()
    {
        while (

            SC_SY_MA_Storage.OB_MouseTouchCollidingPart == gameObject)
        {

            yield return null;
        }

        MouseTouchDoing = null;

        yield break;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
    */









    /*
    // Update is called once per frame
    void Update()
    {
        

        
        if(SC_SY_MA_Storage.MouseCollideFrame == 0)
        {
            // 아무것도 안 함
        }
        else if(SC_SY_MA_Storage.MouseCollideFrame > 1)
        {
            SC_SY_MA_Storage.MouseCollideFrame = 1;
            SC_SY_MA_Storage.MouseCollideEndure += 1;

            if (SC_SY_MA_Storage.MouseCollideCondition == 1)
            {
                // 마우스 충돌중

            }
            else if (SC_SY_MA_Storage.MouseCollideCondition == 4)
            {
                // 마우스 클릭다운됨
            }
            else if (SC_SY_MA_Storage.MouseCollideCondition == 7)
            {
                // 마우스 누르는 중
            }
            else if (SC_SY_MA_Storage.MouseCollideCondition == 10)
            {
                // 마우스 클릭업됨
            }

        }
        else
        {
            // 충돌 취소됨
            SC_SY_MA_Storage.MouseCollideFrame = 0;

            if (SC_SY_MA_Storage.MouseCollideCondition == 1)
            {
                // 마우스 충돌중
            }
            else if (SC_SY_MA_Storage.MouseCollideCondition == 4)
            {
                // 마우스 클릭다운됨
            }
            else if (SC_SY_MA_Storage.MouseCollideCondition == 7)
            {
                // 마우스 누르는 중
            }
            else if (SC_SY_MA_Storage.MouseCollideCondition == 10)
            {
                // 마우스 클릭업됨
            }

            SC_SY_MA_Storage.MouseCollideCondition = 0;

        }
        
    }


    public void MouseTouchCollideReceiving(RaycastHit pm_a)
    {
        SC_SY_MA_Storage.OB_MouseTouchCollidingPart = gameObject;

        SC_SY_MA_Storage.MouseCollideFrame = 2;
        SC_SY_MA_Storage.MouseCollideCondition = 1;
        // 충돌 즉석 이벤트
    }

    public void MouseClickDownCollideReceiving(RaycastHit pm_a)
    {
        SC_SY_MA_Storage.OB_MouseTouchCollidingPart = gameObject;

        SC_SY_MA_Storage.MouseCollideFrame = 2;
        SC_SY_MA_Storage.MouseCollideCondition = 4;
    }

    public void MouseClickPushCollideReceiving(RaycastHit pm_a)
    {
        SC_SY_MA_Storage.OB_MouseTouchCollidingPart = gameObject;

        SC_SY_MA_Storage.MouseCollideFrame = 2;
        SC_SY_MA_Storage.MouseCollideCondition = 7;
    }

    public void MouseClickUpCollideReceiving(RaycastHit pm_a)
    {
        SC_SY_MA_Storage.OB_MouseTouchCollidingPart = gameObject;

        SC_SY_MA_Storage.MouseCollideFrame = 2;
        if (SC_SY_MA_Storage.MouseCollideCondition != 4)
        {
            SC_SY_MA_Storage.MouseCollideCondition = 10;
        }
        else
        {
            SC_SY_MA_Storage.MouseCollideCondition = 13;
        }
    }
    */
}
