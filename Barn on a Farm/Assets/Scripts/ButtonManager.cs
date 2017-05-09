using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {

    public Transform Canvas;
    public Transform Menu;
    public Transform Options;
    public Transform Audio;


    public void Update()
    {
        if (Input.anyKeyDown)
        {
            Canvas.gameObject.SetActive(false);
            Menu.gameObject.SetActive(true);

        }
            
    }

    public void NewGameBtn(string NewGameLevel)
    {
        SceneManager.LoadScene(NewGameLevel);
    
    }

    public void OptionsBtn(string Options_Button)
    {
        if (Options.gameObject.activeInHierarchy == false)
        {
            Options.gameObject.SetActive(true);

        }
        else
        {
            Options.gameObject.SetActive(false);
        }

    }



    public void ExitGameBtn()
    {
        Application.Quit();
    }

    public void BackBtn()
    {
        if (Audio.gameObject.activeInHierarchy == true)
        {
            Audio.gameObject.SetActive(false);
            Options.gameObject.SetActive(true);
        }
        else
        {
            Options.gameObject.SetActive(false);
        }
    }

    public void AudioBtn()
    {
        Options.gameObject.SetActive(false);
        Audio.gameObject.SetActive(true);
    }


}