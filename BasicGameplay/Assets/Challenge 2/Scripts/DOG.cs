using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOG : MonoBehaviour
{
    public float leftLimit = 40;
    public float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.z < leftLimit)
        {
            Destroy(gameObject);
        }
        // Destroy balls if y position is less than bottomLimit
        
    }
}
