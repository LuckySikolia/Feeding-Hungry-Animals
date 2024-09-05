using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //initialize variables
    public float horizontalInput;
    public float speed = 20f;

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
    }
}
