using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int timeToReloadScene = 2;

    public void LoadGame()
    {
        StartCoroutine(ReloadSceneCoroutine(1));
    }

    public void LoadMenu()
    {
        StartCoroutine(ReloadSceneCoroutine(0));
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public IEnumerator ReloadSceneCoroutine(int sceneIndex)
    {
        yield return new WaitForSecondsRealtime(timeToReloadScene);

        SceneManager.LoadScene(sceneIndex);
    }
}
