using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraColorController : MonoBehaviour
{
   [SerializeField] private Camera mainCamera;
   [SerializeField] private Color[] colors;
   private int colorIndex;
   [SerializeField] private float lerpValue;
   [SerializeField] private float time;
   private float currentTime;

   private void Start()
   {
      mainCamera = Camera.main;//Oluşturduğumuz değişkeni oyun içerisinde ki kameraya atadık.
   }

   private void Update()
   {
      ChangeSmoothCameraColor();
      SetColorChangeTime();
   }

   private void ChangeSmoothCameraColor()
   {
      mainCamera.backgroundColor = Color.Lerp(mainCamera.backgroundColor, colors[colorIndex], lerpValue * Time.deltaTime);
   }

   private void SetColorChangeTime()
   {
      if (currentTime <= 0)
      {
         IncreaseColorIndexValue();
         CheckColorIndexValue();
         currentTime = time;
      }
      else
      {
         currentTime -= Time.deltaTime;
      }
   }

   private void IncreaseColorIndexValue()
   {
      colorIndex++;//colorIndex'i bir bir arttırıyoruz.
   }

   private void CheckColorIndexValue()
   {
      if (colorIndex >= colors.Length)
      {
         colorIndex = 0;
      }
   }

   private void OnDestroy()//Her oyun kapandığında varsayılan değerimizi tekrar ilk Color'ımıza çekiyoruz
   {
      mainCamera.backgroundColor = colors[1];
   }
}
