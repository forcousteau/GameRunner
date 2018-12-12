using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public GameObject mainM;
	public GameObject options;
	public void PlayGame()
	{
		    try
            {
             FindObjectOfType<AudioManager>().Play("pressed");   
            }
            catch (System.Exception)
            {
                
            }
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void OptionsPressed()
	{
			try
            {
             FindObjectOfType<AudioManager>().Play("pressed");   
            }
            catch (System.Exception)
            { 
            }
			mainM.SetActive(false);
			options.SetActive(true);
	}

	public void GuitGame()
	{
			 try
            {
             FindObjectOfType<AudioManager>().Play("pressed");   
            }
            catch (System.Exception)
            {
                
            }
		Debug.Log("Quit Game");
		Application.Quit();
	}
}
