using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorControllerAnson : MonoBehaviour
{

    public float torque;
    public Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        float tiltHorizontal = Input.GetAxis("Horizontal");
        float tiltVertical = Input.GetAxis("Vertical");
        // Vector3 turn = new Vector3(tiltHorizontal, 0.0f, tiltVertical);
        // rb.AddRelativeTorque(tiltHorizontal * torque, 0.0f, tiltVertical * torque, ForceMode.Acceleration);
	// rb.AddTorque(transform.up * torque * tiltHorizontal);
	// rb.AddRelativeTorque(100.0f, 0.0f, 0.0f, ForceMode.Acceleration);
	// rb.Rotate(0, Input.GetAxis("Horizontal")*Time.deltaTime*torque, 0);

	rb.angularVelocity = Vector3.zero;
        rb.AddTorque(tiltVertical * torque, 0.0f, tiltHorizontal * torque * -1.0f);
    }

}
