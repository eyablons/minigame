using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update.
    public float speed = 25.0f;
    public Transform EnemySpawnPoint;
    private float startDelay = 3;
    private float spawnInterval = 4.0f;

    public GameObject projectilePrefab;
    void Start()
    {
        var PlayerColor = gameObject.GetComponent<Renderer>();

        PlayerColor.material.SetColor("_Color", Color.red);

        InvokeRepeating("spawnProjectile", startDelay, spawnInterval);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);

    }
    void spawnProjectile()
    {

        Instantiate(projectilePrefab, EnemySpawnPoint.position, projectilePrefab.transform.rotation);

    }
}
