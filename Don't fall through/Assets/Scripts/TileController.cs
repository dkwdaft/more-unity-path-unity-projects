using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{
    [SerializeField] Material startColour;
    [SerializeField] Material safeColour;
    [SerializeField] Material unsafeColour;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material = startColour;
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().isKinematic = true;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (gameObject.tag == "Safe")
        {
            rend.sharedMaterial = safeColour;
        }
        else if (gameObject.tag == "Tile")
        {
            rend.sharedMaterial = unsafeColour;
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
