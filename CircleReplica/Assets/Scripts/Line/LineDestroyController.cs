using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDestroyController : MonoBehaviour
{
    [SerializeField] private float endXValue;

    private void Update()
    {
        CheckLinePositionX();
    }

    private void CheckLinePositionX()
    {
        if (transform.position.x <= endXValue)//endXValue büyük eşit ise tranform.position.x'e
        {
            Destroy(gameObject);//Bu scriptin bağlı olduğu objeyi yok et.
        }
    }
}
