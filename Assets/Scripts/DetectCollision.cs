using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player") return;

        Destroy(gameObject);
        
         
        if(other.gameObject.tag == "se"){
           ScoreManager.Score += 5;
           MeteorController.health--;
        }
      else  if(other.gameObject.tag == "me"){
          ScoreManager.Score += 10;
          MeteorController.health--;
      }
       else  if(other.gameObject.tag == "le"){
        ScoreManager.Score += 20;
        MeteorController.health--;

       }
    }
}
