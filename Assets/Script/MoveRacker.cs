using UnityEngine;
using System.Collections;

public class MoveRacker : MonoBehaviour {

    public float speed = 30;
    public string axis = "Vertical";

	void FixedUpdate()
    {
        //float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw(axis);

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, vertical) * speed ;
    }
}
