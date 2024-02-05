using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Other_projectile : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 40.0f;
    public GameObject[] Player_Cube;
    void Start()
    {
        var PlayerColor = gameObject.GetComponent<Renderer>();

        PlayerColor.material.SetColor("_Color", Color.red);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }
    void Hitplayer(Collider GameObject)
    {
        Debug.Log("Game Over");
    }
}
