using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    void Update()
    {
        if(transform.position.y > 8.0f || transform.position.y < -6.0f){
            Destroy(gameObject);
        }
    }
}
