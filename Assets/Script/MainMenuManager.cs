using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {

  

    public void Settings()
	{
		
	}

	public void GamePlay()
	{
		SceneManager.LoadScene ("Game Scena");
	}

	public void About()
	{

        GetComponent<TextMesh>().text = "Hello World";

    }
}
