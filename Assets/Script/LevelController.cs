using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject looseLabel;
    [SerializeField] GameObject winLabel;
    [SerializeField] AudioClip winSound;
    [SerializeField] float soundVolume = 0.5f;
    [SerializeField] float waitForNextScene = 5f;
    int numberOfAttackers = 0;
    bool levelTimerFinished = false;

    private void Start()
    {
        winLabel.SetActive(false);
        looseLabel.SetActive(false);

    }
    public void AttackerSpawned()
    {
        numberOfAttackers++;
    }
    public void AttackerKilled()
    {
        numberOfAttackers--;
        if (numberOfAttackers <= 0 && levelTimerFinished)
        {
            StartCoroutine(HandleWinCondition());
        }
    }

    IEnumerator HandleWinCondition()
    {
        winLabel.SetActive(true);
        AudioSource.PlayClipAtPoint(winSound, Camera.main.transform.position, soundVolume);
        yield return new WaitForSeconds(waitForNextScene);
        FindObjectOfType<Level>().LoadNextScene();
    }


    public void LevelTimerFinished()
    {
        levelTimerFinished = true;
        StopSpawners();
    }
    private void StopSpawners()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in spawnerArray)
        {
            spawner.StopSpawning();
        }
    }

    public void HandleLooseCondition()
    {
        looseLabel.SetActive(true);
        Time.timeScale = 0;
    }





}

