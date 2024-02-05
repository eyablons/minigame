using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Controller : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 40.0f;
    
    void Start()
    {
        var PlayerColor = gameObject.GetComponent<Renderer>();

        PlayerColor.material.SetColor("_Color", Color.green);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }
}
