using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Instructions()
    {
        SceneManager.LoadScene("instructions");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("level1");

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }
}
