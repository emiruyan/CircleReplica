using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleJumpController : MonoBehaviour
{
    [SerializeField] private CircleDataTransmiter circleDataTransmiter;//CircleDataTransmiter'a eriştik
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float jumpForce;

    private void FixedUpdate()//Fizik işlemlerimizi Update yerine FixedUpdate içinde yapmamız tavsiye edilir
    {
        SetCircleJump();
    }

    private void SetCircleJump()
    {
        if (circleDataTransmiter.GetIsTouch())//CircleDataTransmiter içerisindeki GetIsTouch fonksiyonu aktif ise;
        {
            rb.velocity = Vector2.up * jumpForce * Time.fixedDeltaTime;//Velocity'e bu değerleri atayarak bir zıplama hareketi sağladık
        }
        
    }
}
