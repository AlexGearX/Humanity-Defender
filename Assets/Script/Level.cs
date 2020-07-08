using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] int timeToWait = 4;
    int currentSceneIndex;
    void Start()
    {

        currentSceneIndex = SceneManager.GetActiveScene().buildIndex ;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(LoadMenuScreenAfterSplash());
        }
    }

    void Update()
    {
        
    }

    IEnumerator LoadMenuScreenAfterSplash()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadGameOver()
    {   
       
    }

    public void LoadYouLoose()
    {
        SceneManager.LoadScene("Lose Screen");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
