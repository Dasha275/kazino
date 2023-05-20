using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;

public class Player : MonoBehaviour
{
    public Transform[] coleso;
    public TextMeshPro Count;
    public bool Checker;

    private IEnumerator qwe()
    {
        for (var i = 0; i < coleso.Length; i++)
        { 
            StartCoroutine(RotateColeso(coleso[i], Random.Range(3,8)));
        }
        return null;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) StartCoroutine("qwe");
    }

    IEnumerator RotateColeso(Transform o, float mytime)
    {
        float timer = 0;
        while (timer < mytime )
        {
            timer += Time.deltaTime;
            o.Rotate(Vector3.forward,1);
            yield return null;
        }
       
    }

}
