using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorControllerAnson : MonoBehaviour
{
    public float rotationSpeed = 40f;
    void Update() {
        float tiltAroundX = Input.GetAxis("Vertical");
        float tiltAroundZ = -Input.GetAxis("Horizontal");

        Vector3 playerPosition = GameObject.Find("Player").transform.position;
        transform.RotateAround(playerPosition, new Vector3(tiltAroundX, 0, tiltAroundZ), rotationSpeed * Time.deltaTime);

        float zeroingThreshold = 0.001f;
        if (tiltAroundX == 0) {
            returnToZeroX(playerPosition, rotationSpeed, zeroingThreshold);
        }

        if (tiltAroundZ == 0) {
            returnToZeroZ(playerPosition, rotationSpeed, zeroingThreshold);
        }

        Quaternion currentRotation = transform.rotation;
        transform.rotation = new Quaternion(currentRotation.x, 0, currentRotation.z, currentRotation.w);
    }

    void returnToZeroX(Vector3 playerPosition, float returnSpeed, float zeroingThreshold) {
        Quaternion currentRotation = transform.rotation;

        if (currentRotation.x < zeroingThreshold && currentRotation.x > -zeroingThreshold) {
            transform.rotation = new Quaternion(0, currentRotation.y, currentRotation.z, currentRotation.w);
        } else {
            if (currentRotation.x > 0) {
                transform.RotateAround(playerPosition, new Vector3(-1, 0, 0), returnSpeed * Time.deltaTime);
            }
            
            if (currentRotation.x < 0) {
                transform.RotateAround(playerPosition, new Vector3(1, 0, 0), returnSpeed * Time.deltaTime);
            }
        }
    }

    void returnToZeroZ(Vector3 playerPosition, float returnSpeed, float zeroingThreshold) {
        Quaternion currentRotation = transform.rotation;

        if (currentRotation.z < zeroingThreshold && currentRotation.z > -zeroingThreshold) {
            transform.rotation = new Quaternion(currentRotation.x, currentRotation.y, 0, currentRotation.w);
        } else {
            if (currentRotation.z > 0) {
                transform.RotateAround(playerPosition, new Vector3(0, 0, -1), returnSpeed * Time.deltaTime);
            }
            
            if (currentRotation.z < 0) {
                transform.RotateAround(playerPosition, new Vector3(0, 0, 1), returnSpeed * Time.deltaTime);
            }
        }
    }
}
