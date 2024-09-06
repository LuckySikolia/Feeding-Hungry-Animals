using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //initialize variables
    public float boundaryTop = 24f;
    public float boundaryBottom = -8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > boundaryTop)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < boundaryBottom)
        {
            Debug.Log(transform.position.z);
            //end game here
            Debug.Log("Game Over");
            Destroy(gameObject);

            
        }
        
    }
}
