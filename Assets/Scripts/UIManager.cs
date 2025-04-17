using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void PlayButton()
    {
        Debug.Log("Play button çalıştı!");
        
        SceneManager.LoadScene("GameScene");
    }
    
    public void OptionsButton()
    {
        Debug.Log("options button çalıştı!");
    }

    public void ExitButton()
    {
        Debug.Log("exit button çalıştı!");

        Application.Quit();
    }
}
