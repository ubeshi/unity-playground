using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlayerJada : MonoBehaviour
{
    //Bullet prefab
    public GameObject bullet;

    //Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
        // Spawn the Bullet
        GameObject g = (GameObject) Instantiate(bullet,
                                                transform.position,
                                                //quaternion correseponds to 'no rotation' - the object is perfectly aligned with the world or parent axes.
                                                Quaternion.identity);
        // Ignore Bullet<->Player collisions
        Physics2D.IgnoreCollision(g.GetComponent<Collider2D>(),
                                  transform.parent.GetComponent<Collider2D>());
        }
    }
}
