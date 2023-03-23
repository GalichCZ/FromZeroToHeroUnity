using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField] GameManager gm;
    public AudioClip pongSound;
    private AudioSource audioSource;
    public float speed = 30;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (gm.Started)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        }
    }

    private float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
    {
        return (ballPos.y - racketPos.y) / racketHeight;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "LeftRacket")
        {
            float y = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);
            Vector2 dir = new Vector2(-1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
            audioSource.PlayOneShot(pongSound);
        }

        if(collision.gameObject.name == "RightRacket")
        {
            float y = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);
            Vector2 dir = new Vector2(1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
            audioSource.PlayOneShot(pongSound);
        }

        if (collision.gameObject.name == "WallLeft")
        {
            gm.ScoreIncrease(collision.gameObject.name);
        }

        if(collision.gameObject.name == "WallRight")
        {
            gm.ScoreIncrease(collision.gameObject.name);
        }
    }
}
