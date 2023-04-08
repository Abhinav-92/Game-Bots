using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
   public static int Score =0;
    public TextMeshProUGUI scoreText;
    
    // void Start()
    // {
    //     Score=0;
        
    // }

    void Update(){
        scoreText.text = "Score : " + Score.ToString();
    }

}

    // Update is called once per frame
   
