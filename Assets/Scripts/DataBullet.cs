using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBullet : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField]
    private float bulletSpeed = 8f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.up * bulletSpeed;

    }
}
