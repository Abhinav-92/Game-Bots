using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    void Update()
    {
        if(transform.position.y > 8.0f || transform.position.y < -6.0f){
            if(gameObject.tag == "se" || gameObject.tag == "me" || gameObject.tag == "le") ScoreManager.Score += 5;
            Destroy(gameObject);
        }
    }
}
