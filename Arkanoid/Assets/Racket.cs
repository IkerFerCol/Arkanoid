using UnityEngine;

public class Racket : MonoBehaviour
{
    public float speed = 200.0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalDirection = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().linearVelocity = Vector2.right * horizontalDirection * speed;
    }
}