using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBird : MonoBehaviour
{
    public float movementSpeed = 150f;
    public float flapSpeed = 180f;

    public Rigidbody2D playerRigidbody;

    private void Start()
    {
        // set initial velocity along +x
        playerRigidbody.velocity = new Vector2(movementSpeed * Time.deltaTime, 0f);
    }

    private void Update()
    {
        // if space is pressed, flap
        if (Input.GetKey(KeyCode.Space))
        {
            Flap();
        }
    }

    private void Flap()
    {
        playerRigidbody.velocity = new Vector2(playerRigidbody.velocity.x, flapSpeed * Time.deltaTime);
    }
}
