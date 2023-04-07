using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceshipController : MonoBehaviour
{
    TouchInputController inputController = null;
    public int bulletType = 1;
    private int life = 3;

    void Start()
    {
        inputController = GetComponent<TouchInputController>();
    }

    // Update is called once per frame
    void Update()
    {
        inputController.TouchInput(transform.position, transform.rotation, bulletType);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "se" || other.gameObject.tag == "me" || other.gameObject.tag == "le")
        {
            life--;
            if(life == 0){
                Destroy(gameObject);
            }
        }
    }


}
