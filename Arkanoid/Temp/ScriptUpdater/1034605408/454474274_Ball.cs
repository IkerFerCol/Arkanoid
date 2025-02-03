using UnityEngine;

public class Ball : MonoBehaviour
{

    public float speed = 100.0f;
    
    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth) {
        return (ballPos.x - racketPos.x) / racketWidth;
    }
    
    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.name == "racket") {          
            float x=hitFactor(transform.position,      
            col.transform.position,
            col.collider.bounds.size.x);

            Vector2 dir = new Vector2(x, 1).normalized; 

            GetComponent<Rigidbody2D>().linearVelocity = dir * speed; 
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = Vector2.up * speed;
    }
    
    
}