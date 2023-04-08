using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayPause : MonoBehaviour
{
    public Sprite playSprite;
    public Sprite pauseSprite;
    public Image playPauseImage;

    bool isPaused = false;

    public void ToggleButton()
    {
        isPaused = !isPaused;

        if(isPaused){
            playPauseImage.sprite = playSprite;
            Time.timeScale = 0;

        }
        else {
            playPauseImage.sprite = pauseSprite;
            Time.timeScale = 1;
        }
    }
}
