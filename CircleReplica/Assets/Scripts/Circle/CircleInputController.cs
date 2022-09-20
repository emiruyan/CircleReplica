using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleInputController : MonoBehaviour
{
   [SerializeField] private CircleDataTransmiter circleDataTransmiter;//CircleDataTransmiter'a ulaştık
    
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
            circleDataTransmiter.IncreaseScoreValue();
            //Her tıkladığımızda circleDataTransmiter içerisinde ki IncreaseScoreValue fonksiyonunu çağırıyoruz
        }
        else if (Input.GetMouseButtonUp(0))//Mouse sol click yukarda ise;
        {
            isTouch = false;
        }
    }
}


