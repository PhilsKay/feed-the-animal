using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalKey;
    private float speed = 20.0f;
    private float xRange = 10.0f;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        
        //Check to make sure the player does not go out of bound
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //Instantiate the horizontalKey to the Input
        horizontalKey = Input.GetAxis("Horizontal");

        //Move player left/Right
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalKey);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }
}
