using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorController : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 4f;
    public static int health;

    void Start()
    {
        if(gameObject.tag == "le") health = 3;
        else health = 1;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - (speed * Time.deltaTime), transform.position.z);
        if(health == 0) Destroy(gameObject);
    }

}
