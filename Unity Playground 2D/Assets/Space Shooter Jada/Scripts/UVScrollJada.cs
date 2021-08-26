using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UVScrollJada : MonoBehaviour
{
    // we used a Vector2 for our speed variable to make sure that we can modify the x (horizontal) and y (vertical) speed
    public Vector2 speed;

    void LateUpdate() {
        GetComponent<Renderer>().material.mainTextureOffset = speed * Time.time;
    }
}
