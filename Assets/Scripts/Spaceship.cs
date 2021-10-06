using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    private Rigidbody2D rb;
    private AudioSource audioSource;
    private float horizontal;
    private float vertical;
    private float cooldownCounter = 0f;
    private float[] firingCooldown = { 1.25f, 1.1f, 0.9f, 0.7f, 0.5f, 0.4f, 0.4f };// 7 
    private bool isDead = false;
    [SerializeField]
    private float speed = 10f;
    [SerializeField]
    private float boundLimitX = 8f;
    [SerializeField]
    private float boundLimitY = 4f;
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private Transform bulletSpawnPoint;
    [SerializeField]
    private int powerLevel = 1;
    [SerializeField]
    private GameObject smoke;
    [SerializeField]
    private GameObject sprite;
    [SerializeField]
    private AudioClip pew;
    [SerializeField]
    private AudioClip puff;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PowerUp"))
        {
            GameController.Instance.PlayTaDa();
            Destroy(collision.gameObject);
            GameController.Instance.AddScore(GameController.Enemies.PowerUp);
            if (powerLevel < 7)
                powerLevel++;
        }
        if (collision.gameObject.CompareTag("Bug"))
        {
            Instantiate(smoke, gameObject.transform.position, Quaternion.identity);
            isDead = true;
            StartCoroutine(Die());
            sprite.SetActive(false);

            audioSource.clip = puff;
            audioSource.Play();
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (GameController.Instance.GameIsPaused || isDead)
            return;

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (cooldownCounter > 0f)
        {
            cooldownCounter -= Time.deltaTime;
        }
        else
        {
            if (Input.GetButton("Fire1"))
            {
                Fire();
            }
        }
    }

    private void FixedUpdate()
    {
        if (isDead)
            return;

        float movementH = horizontal * speed;
        float movementV = vertical * (speed / 1.8f);

        if ((gameObject.transform.position.x < (boundLimitX * -1) && horizontal < 0) ||
            (gameObject.transform.position.x > boundLimitX && horizontal > 0))
            movementH = 0;

        if ((gameObject.transform.position.y < (boundLimitY * -1) && vertical < 0) ||
            (gameObject.transform.position.y > boundLimitY && vertical > 0))
            movementV = 0;

        animator.SetBool("TurningLeft", movementH != 0 && horizontal < 0);
        animator.SetBool("TurningRight", movementH != 0 && horizontal > 0);

        rb.velocity = new Vector2(movementH, movementV);
    }

    private void Fire()
    {
        Vector3 pos = bulletSpawnPoint.position;
        Vector3 newPos;
        switch (powerLevel)
        {
            case 1:
                Instantiate(bullet, pos, Quaternion.identity);
                break;
            case 2:
                newPos = new Vector3(0.2f, 0);
                Instantiate(bullet, pos - newPos, Quaternion.identity);
                Instantiate(bullet, pos + newPos, Quaternion.identity);
                break;
            case 3:
                newPos = new Vector3(0.2f, 0);
                Instantiate(bullet, pos - newPos, Quaternion.identity);
                Instantiate(bullet, pos + new Vector3(0f, 0.2f), Quaternion.identity);
                Instantiate(bullet, pos + newPos, Quaternion.identity);
                break;
            case 4:
                newPos = new Vector3(0.35f, 0);
                Instantiate(bullet, pos - newPos, Quaternion.Euler(0, 0, 15));
                Instantiate(bullet, pos + newPos, Quaternion.Euler(0, 0, -15));
                newPos = new Vector3(0.2f, 0f);
                Instantiate(bullet, pos - newPos, Quaternion.Euler(0, 0, 2));
                Instantiate(bullet, pos + newPos, Quaternion.Euler(0, 0, -2));
                break;
            case 5:
                newPos = new Vector3(0.35f, 0);
                Instantiate(bullet, pos - newPos, Quaternion.Euler(0, 0, 30));
                Instantiate(bullet, pos + newPos, Quaternion.Euler(0, 0, -30));
                newPos = new Vector3(0.27f, 0);
                Instantiate(bullet, pos - newPos, Quaternion.Euler(0, 0, 15));
                Instantiate(bullet, pos + newPos, Quaternion.Euler(0, 0, -15));
                newPos = new Vector3(0.2f, 0f);
                Instantiate(bullet, pos - newPos, Quaternion.Euler(0, 0, 2));
                Instantiate(bullet, pos + newPos, Quaternion.Euler(0, 0, -2));
                break;
            case 6:
                newPos = new Vector3(0.35f, 0);
                Instantiate(bullet, pos - newPos, Quaternion.Euler(0, 0, 30));
                Instantiate(bullet, pos + newPos, Quaternion.Euler(0, 0, -30));
                newPos = new Vector3(0.27f, 0);
                Instantiate(bullet, pos - newPos, Quaternion.Euler(0, 0, 20));
                Instantiate(bullet, pos + newPos, Quaternion.Euler(0, 0, -20));
                newPos = new Vector3(0.23f, 0);
                Instantiate(bullet, pos - newPos, Quaternion.Euler(0, 0, 10));
                Instantiate(bullet, pos + newPos, Quaternion.Euler(0, 0, -10));
                newPos = new Vector3(0.17f, 0f);
                Instantiate(bullet, pos - newPos, Quaternion.Euler(0, 0, 2));
                Instantiate(bullet, pos + newPos, Quaternion.Euler(0, 0, -2));
                break;
            case 7:
                newPos = new Vector3(0.35f, 0);
                Instantiate(bullet, pos - newPos, Quaternion.Euler(0, 0, 30));
                Instantiate(bullet, pos + newPos, Quaternion.Euler(0, 0, -30));
                newPos = new Vector3(0.27f, 0);
                Instantiate(bullet, pos - newPos, Quaternion.Euler(0, 0, 20));
                Instantiate(bullet, pos + newPos, Quaternion.Euler(0, 0, -20));
                newPos = new Vector3(0.23f, 0);
                Instantiate(bullet, pos - newPos, Quaternion.Euler(0, 0, 10));
                Instantiate(bullet, pos + newPos, Quaternion.Euler(0, 0, -10));
                newPos = new Vector3(0.17f, 0f);
                Instantiate(bullet, pos - newPos, Quaternion.Euler(0, 0, 4));
                Instantiate(bullet, pos + newPos, Quaternion.Euler(0, 0, -4));
                newPos = new Vector3(0f, 0f);
                Instantiate(bullet, pos - newPos, Quaternion.identity);
                break;
            default:
                break;
        }
        audioSource.clip = pew;
        audioSource.Play();

        cooldownCounter = firingCooldown[powerLevel - 1];
    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(1f);
        GameController.Instance.ShowDeathMenu();
    }
}
