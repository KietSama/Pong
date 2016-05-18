using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public float speed = 30;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // Hit the left Racket ?
        if (col.gameObject.name == "Wall_East")
        {
            // calculator hit factor
            float y = HitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);

            // calculator direction, make lenght=1 via Normalized
            Vector2 dir = new Vector2(1, y).normalized;

            // Set veclocity with dir * speed;
            GetComponent<Rigidbody2D>().velocity = dir * speed;

            // Hit the Right Racket ?
            if (col.gameObject.name == "Wall_East")
            {
                // calculator hit factor
                float y1 = HitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);

                // calculator direction, make lenght=1 via Normalized
                Vector2 dir1 = new Vector2(-1, y).normalized;

                // Set veclocity with dir * speed;
                GetComponent<Rigidbody2D>().velocity = dir * speed;
            }
        }
    }

    float HitFactor(Vector2 ballPos, Vector2 racket, float racketHeight)
    {
        return (ballPos.y - racket.y) / racketHeight;
    }
}
