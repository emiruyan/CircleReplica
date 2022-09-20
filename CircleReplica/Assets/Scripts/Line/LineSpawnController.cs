using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineSpawnController : MonoBehaviour
{
    [SerializeField] private GameObject lastLineObject;
    [SerializeField] private GameObject linePrefab;
    private GameObject newLineObject;
    [SerializeField] private float spawnTime;

    private void Start()
    {
        StartCoroutine(nameof(CreateNewLineObject));
    }

    IEnumerator CreateNewLineObject()//Yeni Line objeleri üreteceğimiz fonksiyon
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            newLineObject = Instantiate(linePrefab, lastLineObject.transform.GetChild(0).transform.GetChild(0).GetComponent<Transform>().position,transform.rotation);
            lastLineObject = newLineObject;//lastLineObject'i yeni oluşacak lineObjectlere atıyoruz. Böylece sürekli son objeyi kullanmış oluyoruz
            //linePrefab'i hierarchy üzerindeki Spawn point üzerinden Instantiete ediyoruz.
        }
    }
}
