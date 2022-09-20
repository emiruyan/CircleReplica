using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleDataTransmiter : MonoBehaviour//Bu classın görevi diğer classların birbiri ile haberleşmesini sağlamak
{
    [SerializeField] private CircleInputController circleInputController;//CircleInputController'a ulaştık
    [SerializeField] private CircleScoreController circleScoreController;//CircleScoreController'a ulaştık

    public bool GetIsTouch()
    {
        return circleInputController.isTouch;//circleInputController içindeki isTouch değişkenini bu class'ta döndürdük.
    }

    public void IncreaseScoreValue()
    {
        circleScoreController.IncreaseScoreValue();
    }
}
