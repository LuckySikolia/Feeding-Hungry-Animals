using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //initialize variables
    public float boundaryTop = 24f;

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
        
    }
}
