using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenuManager : MonoBehaviour {

    public Transform PauseMenu;
    public Transform Options;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Options.gameObject.activeInHierarchy == true)
            {
                PauseMenu.gameObject.SetActive(false);
                Options.gameObject.SetActive(false);
            }else
            {
                if (PauseMenu.gameObject.activeInHierarchy == false)
                {
                    PauseMenu.gameObject.SetActive(true);
                    Options.gameObject.SetActive(false);
                }
                else
                {
                    PauseMenu.gameObject.SetActive(false);
                }
            }

            
            
            

        }
    }
    public void OptionsBtn(string Options_Button)
    {
        if (Options.gameObject.activeInHierarchy == false)
        {
            Options.gameObject.SetActive(true);
            PauseMenu.gameObject.SetActive(false);
        }
        else
        {
            Options.gameObject.SetActive(false);
        }

    }

    public void MainMenuBtn(string MainMenu)
    {
        SceneManager.LoadScene(MainMenu);

    }

    public void ExitGameBtn()
    {
        Application.Quit();
    }


    public void ResumeGameBtn()
    {
        Options.gameObject.SetActive(false);
        PauseMenu.gameObject.SetActive(false);
    }

}

