using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody2D rBody;
    private Animator anim;
    Vector2 movement = new Vector2(0, 0);

	void FixedUpdate () {

        float horizonal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        rBody = this.gameObject.GetComponent<Rigidbody2D>();
        anim = this.gameObject.GetComponent<Animator>();

        if (horizonal == 1)
        {
            movement = new Vector2(1, 0);
            anim.SetInteger("x", 1);
            anim.SetInteger("y", 0);
        }
        else if (horizonal == -1)
        {
            movement = new Vector2(-1, 0);
            anim.SetInteger("x", -1);
            anim.SetInteger("y", 0);
        }
        else if (vertical == 1)
        {
            movement = new Vector2(0, 1);
            anim.SetInteger("x", 0);
            anim.SetInteger("y", 1);
        }
        else if (vertical == -1)
        {
            movement = new Vector2(0, -1);
            anim.SetInteger("x", 0);
            anim.SetInteger("y", -1);
        }
        else
            movement = new Vector2(0, 0);

            rBody.velocity = movement * speed;
        }
}
