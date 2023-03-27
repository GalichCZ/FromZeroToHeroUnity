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
    }

    public void PullBall()
    {
        ChangeVelocity(Vector2.right * speed);
    }

    private float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
    {
        return (ballPos.y - racketPos.y) / racketHeight;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "LeftRacket")
        {
            ChangeDirection(-1, collision);
        }

        if(collision.gameObject.name == "RightRacket")
        {
            ChangeDirection(1, collision);
        }

        if (collision.gameObject.name == "WallLeft")
        {
            GoalScored(collision.gameObject.name);
        }

        if(collision.gameObject.name == "WallRight")
        {
            GoalScored(collision.gameObject.name);
        }
    }

    private void ChangeDirection(int vec, Collision2D collision)
    {
        float y = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);
        Vector2 dir = new Vector2(vec, y).normalized;
        ChangeVelocity(dir * speed);
        audioSource.PlayOneShot(pongSound);
    }

    private void GoalScored(string net)
    {
        transform.position = new Vector2(0,0);
        ChangeVelocity(Vector2.zero);
        gm.ScoreIncrease(net);
        Invoke("PullBall", 1f);
    }

    private void ChangeVelocity(Vector2 velocity)
    {
        GetComponent<Rigidbody2D>().velocity = velocity;
    }
}
