using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	public void PlayGame () {

		SceneManager.LoadScene("MainScene");
	}
	
	public void Rate()
    {
     
    }

	public void More()
    {

    }
	

    	public void Home () {

		SceneManager.LoadScene("Main Menu");
	}

	 	public void ExitThisGame () {

		Application.Quit();
	}
}
