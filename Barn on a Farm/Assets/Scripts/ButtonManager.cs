using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {

    public Transform Canvas;
    public Transform Menu;

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

    public void ExitGameBtn()
    {
        Application.Quit();
    }


}