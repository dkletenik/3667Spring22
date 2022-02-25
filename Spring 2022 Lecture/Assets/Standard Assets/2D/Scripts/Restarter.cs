using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        [SerializeField] int score = 0;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                // SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
                Debug.Log("You won!");
            }

            else if (other.tag == "Crate")
            {
                Debug.Log("crate fell");
                score++;
                Debug.Log("score: " + score);
            }
        }
    }
}
