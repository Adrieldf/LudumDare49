using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDrop : MonoBehaviour
{
    private Rigidbody2D rb;

    private float fallSpeed = 0.8f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        fallSpeed = Random.Range(0.8f, 1.6f);
    }

    private void FixedUpdate()
    {
        rb.velocity = (transform.up * -1) * fallSpeed;

    }
}
