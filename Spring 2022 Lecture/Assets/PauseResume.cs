using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseResume : MonoBehaviour
{
    GameObject[] pauseMode;
    GameObject[] resumeMode;

    // Start is called before the first frame update
    void Start()
    {
        pauseMode = GameObject.FindGameObjectsWithTag("ShowInPauseMode");
        resumeMode = GameObject.FindGameObjectsWithTag("ShowInResumeMode");

        //buttons that should only be showed in pause mode should start off as inactive
        foreach (GameObject g in pauseMode)
            g.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause()
    {
        Time.timeScale = 0.0f;

        foreach (GameObject g in resumeMode)
            g.SetActive(false);

        foreach (GameObject g in pauseMode)
            g.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1.0f;

        //buttons that should only be showed in pause mode should start off as inactive
        foreach (GameObject g in pauseMode)
            g.SetActive(false);

        foreach (GameObject g in resumeMode)
            g.SetActive(true);

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }

}
