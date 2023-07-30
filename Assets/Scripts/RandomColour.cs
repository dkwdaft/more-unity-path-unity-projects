using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomColour : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Color NewColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            gameObject.transform.GetComponent<MeshRenderer>().material.color = NewColor;
        }
    }
}
