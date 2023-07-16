using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public void StartGame () {
        SceneManager.LoadScene("Level_1");
    }
    
	public void BackMenu () {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame () {
        Application.Quit();
    }
}