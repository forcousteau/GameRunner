using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

	public GameObject levelPanel;
	public GameObject loadingScreen;
	public Slider slider;


	public void LoadLevel(int sceneInd)
	{
		StartCoroutine(LoadAsyncronously(sceneInd));
	}
	
	IEnumerator LoadAsyncronously (int sceneInd)
	{
		AsyncOperation operation = SceneManager.LoadSceneAsync(sceneInd);

		loadingScreen.SetActive(true);
		levelPanel.SetActive(false);

		while (!operation.isDone)
		{
			float progress = Mathf.Clamp01(operation.progress / 9f);
			slider.value = progress;
			yield return null;
		}
	}

		public void Quit()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}
}
