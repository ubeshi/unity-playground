using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveJada : MonoBehaviour
{
    public float speed = 5;

    void FixedUpdate() 
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(h, v);
        GetComponent<Rigidbody2D>().velocity = direction.normalized * speed;

        GetComponent<Animator>().SetBool("Flying", (v > 0));
    }
}
