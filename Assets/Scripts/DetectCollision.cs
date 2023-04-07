using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
