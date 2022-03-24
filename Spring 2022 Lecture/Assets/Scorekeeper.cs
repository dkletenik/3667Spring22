using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scorekeeper : MonoBehaviour
{
    [SerializeField] int score = 0;
    const int DEFAULT_POINTS = 1;
    [SerializeField] Text scoreTxt;
    [SerializeField] Text levelTxt;
    [SerializeField] int level;
    const int SCORE_THRESHOLD = 10;

    // Start is called before the first frame update
    void Start()
    {
        level = SceneManager.GetActiveScene().buildIndex;

        //display score
        DisplayScore();
        DisplayLevel();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateScore(int addend)
    {
        score += addend;
        Debug.Log("score" + score);
        //display score
        DisplayScore();

        if (score > SCORE_THRESHOLD)
        {
            //move on to next level
            SceneManager.LoadScene(level + 1);
        }
    }

    public void UpdateScore()
    {
        UpdateScore(DEFAULT_POINTS);
    }

    public void DisplayScore()
    {
        scoreTxt.text = "Score: " + score;
    }

    public void DisplayLevel()
    {
        int levelToDisplay = level + 1;
        levelTxt.text = "Level " + levelToDisplay;
    }
}
