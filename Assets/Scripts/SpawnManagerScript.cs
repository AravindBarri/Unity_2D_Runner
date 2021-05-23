using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerScript : MonoBehaviour
{
    public GameObject[] obstacles;
    // Start is called before the first frame update
    void Start()
    {
        int y = Random.Range(2, 7);
        InvokeRepeating("Spawn", 2.0f, y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        int x = Random.Range(0, obstacles.Length);
        Instantiate(obstacles[x], transform.position, Quaternion.identity);
    }
}
