using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class LineRotationController : MonoBehaviour
{
   [SerializeField] private float rotationValue;//Hangi aralıklarla rotate edeceğimiz
    private float randomRotation;

   private void Start()
   {
      GenerateRandomRotationValue();
      SetLineRotation();
   }

   private void GenerateRandomRotationValue()
   {
      randomRotation = Random.Range(-rotationValue, rotationValue);//Random olarak bir rotasyon değeri üretiyoruz.
   }

   private void SetLineRotation()
   {
      transform.rotation = Quaternion.Euler(0f, 0f, randomRotation);
   }
}
