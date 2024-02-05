using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update.
    public float speed = 25.0f;
    void Start()
    {
        var PlayerColor = gameObject.GetComponent<Renderer>();

        PlayerColor.material.SetColor("_Color", Color.red);


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
