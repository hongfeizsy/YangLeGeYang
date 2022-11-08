using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    //private void Update()
    //{
    //    foreach (Touch touch in Input.touches)
    //    {
    //        print("Haha");
    //        if (touch.phase == TouchPhase.Began)
    //        {
    //            //Ray ray = GetTouchRay(touch);
    //            print(touch);
    //        }
    //        print(touch.tapCount);
    //    }
    //}

    //private static Ray GetTouchRay(Touch touch)
    //{
    //    return Camera.main.ScreenPointToRay(new Vector3(touch.position.x, touch.position.y, 0));
    //}

    private void OnMouseDown()
    {
        Debug.Log("Mouse down.");
    }
}
