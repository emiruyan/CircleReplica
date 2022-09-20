using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleInputController : MonoBehaviour
{
    public bool isTouch = false;

    private void Update()
    {
        HandleCircleInput();
    }

    private void HandleCircleInput()
    {
        if (Input.GetMouseButtonDown(0))//Mouse sol click bir kez tıklanıyor ise;
        {
            isTouch = true;
        }else if (Input.GetMouseButtonUp(0))//Mouse sol click yukarda ise;
        {
            isTouch = false;
        }
    }
}


