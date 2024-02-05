using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane_Color : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var PlaneColor = gameObject.GetComponent<Renderer>();

        PlaneColor.material.SetColor("_Color", Color.yellow);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
