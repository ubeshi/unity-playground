using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnJada : MonoBehaviour
{
    // The Enemy Ship
    public GameObject ship;

    // The Interval
    public float interval = 1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnNext", interval, interval);
    }

   void SpawnNext() 
   {
       Instantiate(ship, transform.position, Quaternion.identity);
   }
}
