using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpaceshipController : MonoBehaviour
{
    TouchInputController inputController;
    public static int bulletType = 1;
    public static int life = 3;

    [SerializeField] Image[] heartsArray = null;
    // [SerializeField] Sprite filledHeart = null;
    [SerializeField] Sprite emptyHeart = null;

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
            heartsArray[life].sprite = emptyHeart;
            if(life == 0){
                Destroy(gameObject);
                SceneManager.LoadScene(2);
            }
        }
        else if(other.gameObject.tag == "ts") {
            bulletType = 2;
            Destroy(other.gameObject);
            StartCoroutine(PowerUpTime());
        }
        else if(other.gameObject.tag == "ms") {
            bulletType = 3;
            Destroy(other.gameObject);
            StartCoroutine(PowerUpTime());
        }
    }

    IEnumerator PowerUpTime()
    {
        yield return new WaitForSeconds(5.0f);
        bulletType = 1;
    }

    


}
