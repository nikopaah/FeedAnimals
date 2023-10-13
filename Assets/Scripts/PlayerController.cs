using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10f;
    public float xRange = 10f;

    public GameObject Food;


    void Update()
    {
        /* ## Move the player ## */
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);


        /* ## Keep the player in bounds (X-Axis) ## */
        // Left range
        if (transform.position.x < -xRange) 
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        // Right range
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        /* ## Launch a projectile from the player ## */
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Food, transform.position, Food.transform.rotation);
        }
    }
}
