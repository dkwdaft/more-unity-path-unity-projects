using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightController : MonoBehaviour
{

    [SerializeField] private GameObject Spotlight;
     Vector3 spotOffset;

    // Start is called before the first frame update
    void Start()
    {
        spotOffset = Spotlight.transform.position - this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Spotlight.transform.position = this.transform.position + spotOffset;
    }
}
