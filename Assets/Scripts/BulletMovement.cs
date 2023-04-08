using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private float speed = 5f;
    
    void Update()
    {
        if(SpaceshipController.bulletType == 3){
            SpreadBulletMovement(transform.rotation);
        }
        else {
            transform.position = new Vector3(transform.position.x, transform.position.y + (speed * Time.deltaTime), transform.position.z);
        }
    }

    private void SpreadBulletMovement(Quaternion rotation)
    {

        float theta = rotation.y;
        float dx = Mathf.Sin(theta);
        float dy = Mathf.Cos(theta);


        transform.position = new Vector3(transform.position.x + (dx * Time.deltaTime * speed), transform.position.y + (dy * Time.deltaTime * speed), transform.position.z );
    }

}
