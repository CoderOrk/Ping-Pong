using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int timeToReloadScene = 2;

    public void ReloadScene()
    {
        StartCoroutine(ReloadSceneCoroutine());
    }

    public IEnumerator ReloadSceneCoroutine()
    {
        yield return new WaitForSecondsRealtime(timeToReloadScene);

        SceneManager.LoadScene(0);
    }
}
