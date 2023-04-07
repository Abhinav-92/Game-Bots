using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorController : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - (speed * Time.deltaTime), transform.position.z);
    }

    // void OnTriggerEnter2D(Collider2D other)
    // {
    //     Debug.Log("triggered");
    //     if(other.gameObject.tag == "bullet"){
    //         Debug.Log("destroy");
    //         Destroy(other.gameObject);
    //         Destroy(gameObject);
    //     }
    // }
}
