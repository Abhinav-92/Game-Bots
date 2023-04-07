using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceshipController : MonoBehaviour
{
    TouchInputController inputController = null;
    public int bulletType = 1;

    void Start()
    {
        inputController = GetComponent<TouchInputController>();
    }

    // Update is called once per frame
    void Update()
    {
        inputController.TouchInput(transform.position, transform.rotation, bulletType);
    }

    


}
