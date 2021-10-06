using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{
    [SerializeField]
    private float health = 3f;
    [SerializeField]
    private float speed = 3f;
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private GameObject smoke;
    [SerializeField]
    private GameController.Enemies type;
    [SerializeField]
    private GameObject[] drops;

    public Vector3 targetPosition;
    private bool alreadyDied = false;
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip pop;
    [SerializeField]
    private AudioClip puff;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            health--;
            animator.SetTrigger("Hit");
            if (health <= 0f)
            {
                audioSource.clip = puff;
                audioSource.Play();
                GameController.Instance.AddScore(type);
                Instantiate(smoke, gameObject.transform.position, Quaternion.identity);
                if (Random.Range(1, 21) == 1)//5%
                    Instantiate(GameController.Instance.PowerUp, gameObject.transform.position, Quaternion.identity);
                if (!alreadyDied)
                    LevelController.Instance.OnEnemyKilled();
                alreadyDied = true;
                Destroy(gameObject);
            }
            else
            {
                int chance = 21;//5%
                if (type == GameController.Enemies.Pinkbug)
                    chance = 17;
                if (type == GameController.Enemies.Orangebug)
                    chance = 15;
                if (type == GameController.Enemies.Purplebug)
                    chance = 7;
                if (Random.Range(1, chance) == 1)
                    Instantiate(drops[Random.Range(0, drops.Length)], gameObject.transform.position, Quaternion.identity);
                audioSource.clip = pop;
                audioSource.Play();
            }
        }
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (targetPosition != null && targetPosition != Vector3.zero && (transform.position != targetPosition))
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
    }

    private void FixedUpdate()
    {

    }
}
