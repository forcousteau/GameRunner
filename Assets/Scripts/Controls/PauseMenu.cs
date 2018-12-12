using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour {

	public static bool GameIsPaused = false;
	public GameObject pauseMenuUI;
	public GameObject gameStatsUI;
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			if(GameIsPaused)
			{
				Resume();
			}
			else
			{
				Pause();
			}
		}
	}

	public void Resume()
	{
          try
            {
             FindObjectOfType<AudioManager>().Play("pressed");   
            }
            catch (System.Exception)
            {
                
            }
		pauseMenuUI.SetActive(false);
		gameStatsUI.SetActive(true);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}

	public void Pause()
	{
			try
            {
             FindObjectOfType<AudioManager>().Play("pressed");   
            }
            catch (System.Exception)
            {
                
            }
		gameStatsUI.SetActive(false);
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}

	public void LoadMenu()
	{
			try
            {
             FindObjectOfType<AudioManager>().Play("pressed");   
            }
            catch (System.Exception)
            {
                
            }
		Time.timeScale = 1f;
		SceneManager.LoadScene(1);
	}
	public void Quit()
	{
		    try
            {
             FindObjectOfType<AudioManager>().Play("pressed");   
            }
            catch (System.Exception)
            {
                
            }
		Time.timeScale = 1f;
		SceneManager.LoadScene(1);
	}
}
