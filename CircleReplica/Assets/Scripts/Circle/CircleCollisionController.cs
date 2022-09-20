using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CircleCollisionController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Line"))//Çarptığımız nesnenin tag'ı "Line" ise;
        {
            SceneManager.LoadScene(0);//0 indexli sahneyi yükle
        }
    }
}
