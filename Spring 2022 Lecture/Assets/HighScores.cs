using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScores : MonoBehaviour
{
    const int NUM_HIGH_SCORES = 5;
    const string NAME_KEY = "Player";
    const string SCORE_KEY = "Score";

    [SerializeField] string playerName;
    [SerializeField] int playerScore;

    [SerializeField] Text[] nameTxts;
    [SerializeField] Text[] scoreTxts;

    // Start is called before the first frame update
    void Start()
    {
        playerName = PersistentData.Instance.GetName();
        playerScore = PersistentData.Instance.GetScore();

        SaveScore();
        ShowHighScores();
    }

    void SaveScore()
    {
        for (int i = 1; i <= NUM_HIGH_SCORES; i++)
        {
            string currentNameKey = NAME_KEY + i;
            string currentScoreKey = SCORE_KEY + i;

            if (PlayerPrefs.HasKey(currentScoreKey))
            {
                int currentScore = PlayerPrefs.GetInt(currentScoreKey);
                if (playerScore > currentScore)
                {
                    int tempScore = currentScore;
                    string tempName = PlayerPrefs.GetString(currentNameKey);

                    PlayerPrefs.SetString(currentNameKey, playerName);
                    PlayerPrefs.SetInt(currentScoreKey, playerScore);

                    playerName = tempName;
                    playerScore = tempScore;
                }

            }
            else
            {
                PlayerPrefs.SetString(currentNameKey, playerName);
                PlayerPrefs.SetInt(currentScoreKey, playerScore);
                return;
            }
        }
    }

    void ShowHighScores()
    {
        for (int i = 0; i <  NUM_HIGH_SCORES; i++)
        {
            nameTxts[i].text = PlayerPrefs.GetString(NAME_KEY + (i+1));
            scoreTxts[i].text = PlayerPrefs.GetInt(SCORE_KEY + (i+1)).ToString();
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
