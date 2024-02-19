using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] float loadStartMenuDelay = 3f;
    private int currentSceneIndex;
    [SerializeField] int loadSceneIndex;

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(LoadStartScene());
        }
    }

    IEnumerator LoadStartScene()
    {
        yield return new WaitForSeconds(loadStartMenuDelay);
        SceneManager.LoadScene(loadSceneIndex);
    }

    public void LoadSceneMode()
    {
        SceneManager.LoadScene(loadSceneIndex);
    }
}
