using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveJada : MonoBehaviour
{
    public float speed = 5;

  void FixedUpdate() {
    // Get Input from Arrow Keys, WSAD, Gamepads, ...
    float h = Input.GetAxis("Horizontal");
    float v = Input.GetAxis("Vertical");

    // Set the Rigidbody's Velocity
    Vector2 dir = new Vector2(h, v);
    GetComponent<Rigidbody2D>().velocity = dir.normalized * speed;

    // Set Animation Parameter
    GetComponent<Animator>().SetBool("Flying", (v > 0));
  }
}
