using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scorekeeper : MonoBehaviour
{
    [SerializeField] int score;
    const int DEFAULT_POINTS = 1;
    [SerializeField] Text scoreTxt;
    [SerializeField] Text levelTxt;
    [SerializeField] Text nameTxt;
    [SerializeField] int level;
    const int SCORE_THRESHOLD_PER_LEVEL = 10;
    [SerializeField] int scoreThresholdForThisLevel;

    // Start is called before the first frame update
    void Start()
    {
        score = PersistentData.Instance.GetScore();
        level = SceneManager.GetActiveScene().buildIndex;
        scoreThresholdForThisLevel = SCORE_THRESHOLD_PER_LEVEL * level;

        //display score
        DisplayScore();
        DisplayLevel();
        DisplayName();
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
        PersistentData.Instance.SetScore(score);

        if (score >= scoreThresholdForThisLevel)
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
        int levelToDisplay = level;
        levelTxt.text = "Level " + levelToDisplay;
    }

    public void DisplayName()
    {
        nameTxt.text = "Hi, " + PersistentData.Instance.GetName();
    }
}
