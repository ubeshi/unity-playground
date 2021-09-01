using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamageJada : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D coll) {
        // Collided with a Ship? Thne destory it.
        if (coll.gameObject.tag == "Ship")
        Destroy(coll.gameObject);

        //Destroy bullet in any case
        Destroy(gameObject);
    }
}
