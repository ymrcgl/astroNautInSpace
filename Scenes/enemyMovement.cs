using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public int EnemySpeed = 20;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

    }
    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.right * EnemySpeed;
    }
}
