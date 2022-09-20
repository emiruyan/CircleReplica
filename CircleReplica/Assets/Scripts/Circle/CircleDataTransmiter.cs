using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleDataTransmiter : MonoBehaviour
{
    [SerializeField] private CircleInputController circleInputController;//CircleInputController'a ulaştık

    public bool GetIsTouch()
    {
        return circleInputController.isTouch;//circleInputController içindeki isTouch değişkenini bu class'ta döndürdük.
    }
}
