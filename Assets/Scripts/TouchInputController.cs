using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInputController : MonoBehaviour
{
    private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;
    BulletSpawn bulletController = null;

    void Start()
    {
        bulletController = GetComponent<BulletSpawn>();
    }

    public void TouchInput(Vector3 position, Quaternion rotation, int bulletType)
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;

            if(endTouchPosition.x < startTouchPosition.x) {
                RightSwipe();
            }

            if(endTouchPosition.x > startTouchPosition.x) {
                LeftSwipe();
            }

            if(endTouchPosition.x == startTouchPosition.x){
                Vector3 pos = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
                bulletController.FireBulletOnTouch(pos, transform.rotation, bulletType);
            }

        }
        
    }

    private void LeftSwipe()
    {
        transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
    }

    private void RightSwipe()
    {
        transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
    }
}
