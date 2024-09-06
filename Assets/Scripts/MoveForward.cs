using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    //initialize speed of projectile
    public float speed = 5f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move projectile foward (along z axis)
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
    }
}
