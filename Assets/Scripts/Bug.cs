using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{
    [SerializeField]
    private float Health = 3f;
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private GameObject smoke;
    [SerializeField]
    private GameController.Enemies type;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            Health--;
            animator.SetTrigger("Hit");
            if (Health <= 0f)
            {
                Destroy(gameObject);
                GameController.Instance.AddScore(type);
                Instantiate(smoke, gameObject.transform.position, Quaternion.identity);
            }
        }
    }
    void Start()
    {

    }


    void Update()
    {

    }

    private void FixedUpdate()
    {

    }
}
