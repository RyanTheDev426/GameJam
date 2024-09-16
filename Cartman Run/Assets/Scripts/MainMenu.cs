using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string playGameScene;
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene(playGameScene);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
