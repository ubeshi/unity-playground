using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEnemyJada : MonoBehaviour
{
    public GameObject bullet;
    
    public float interval = 2;

    void Start() {
        // Call Fire every few seconds
        InvokeRepeating("Fire", interval, interval);    //second parameter is time until the first call and third parameter is the repeating interval.
    }

    void Fire(){
        //Spaw the bullet
        GameObject g = (GameObject) Instantiate(bullet,
                                                transform.position,
                                                Quaternion.identity);

        //Ignore Bullet <--> Enemy Ship collisions
        Physics2D.IgnoreCollision(g.GetComponent<Collider2D>(),
                                    // use transform.parent bc Bullet Spawn in child of the enemyship so in order to access the enemy ship we have to use the parent property.
                                    transform.parent.GetComponent<Collider2D>());      
                                            
    }
}
