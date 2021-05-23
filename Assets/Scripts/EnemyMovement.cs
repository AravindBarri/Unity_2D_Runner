using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D enemyRB;
    float enemyspeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyRB.velocity = Vector2.left * enemyspeed;
        if(transform.position.x < -10.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
