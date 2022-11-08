using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{



    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0)) { Debug.Log("Down."); }
    }
}
