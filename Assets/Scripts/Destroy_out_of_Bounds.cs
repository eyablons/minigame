using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_out_of_Bounds : MonoBehaviour
{
    // Start is called before the first frame update

    private float topBound = 20;
    private float lowerBound = -20;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);

        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
