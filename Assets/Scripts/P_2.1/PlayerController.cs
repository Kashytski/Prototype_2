using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    private float horizontalInput;
    private float speed = 25f;
    private float xRange = 25f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Left bound
        if (transform.position.x < -xRange)
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        //Right bound
        if (transform.position.x > xRange)
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        //move player
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        //Launch projectile from the player
        if (Input.GetKeyDown(KeyCode.Space)) 
            Instantiate(projectilePrefab,transform.position, projectilePrefab.transform.rotation);
    }
}
