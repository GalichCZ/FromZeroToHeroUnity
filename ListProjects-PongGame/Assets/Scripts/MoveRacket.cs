using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRacket : MonoBehaviour
{

    public float speed = 20;
    public string axis = "Vertical";

    private void FixedUpdate()
    {
        float verticalInput = Input.GetAxisRaw(axis);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, verticalInput) * speed;
    }
}
