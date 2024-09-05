using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //initialize variables
    public float horizontalInput;
    private float speed = 20f;
    public float boundaryLeft = -18f;
    public float boundaryRight = 18f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //use left/right or a/d to move left and right
        horizontalInput = Input.GetAxis("Horizontal");

        //transform along the X axis
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        //code for keeping the player within the field/ grounds
        keepWithinGrounds();
    }

    void keepWithinGrounds()
    {
        //prevent from moving oustide field on left side
        if (transform.position.x < boundaryLeft)
        {
            transform.position = new Vector3(boundaryLeft, transform.position.y, transform.position.z);
        }

        //prevent from moving oustide field on right side
        if(transform.position.x > boundaryRight)
        {
            transform.position = new Vector3(boundaryRight, transform.position.y, transform.position.z);
        }
    }
}
