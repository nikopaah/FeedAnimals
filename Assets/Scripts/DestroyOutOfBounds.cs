using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 30f;
    public float lowerBound = -10f;


    // Update is called once per frame
    void Update()
    {
        /* ## Keep the player in bounds (X-Axis) ## */
        // Left range
        if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        } 
        else if (transform.position.z > topBound) 
        { 
            Destroy(gameObject); 
        }
    }
}
