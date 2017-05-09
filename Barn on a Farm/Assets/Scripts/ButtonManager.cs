using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {

    public Transform Canvas;
    public Transform Menu;
    public Transform Options;

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


}