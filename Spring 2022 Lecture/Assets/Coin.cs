using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] GameObject controller;
    [SerializeField] AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        if (controller == null)
        {
            controller = GameObject.FindGameObjectWithTag("GameController");
        }
        if (audio == null)
        {
            audio = GetComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D (Collider2D collider)
    {
        Debug.Log("do stuff");
        /*When Mario collides with coin: 1) score increases X
         * 2) sound effect X
         * 3) coin should be destroyed */
        controller.GetComponent<Scorekeeper>().UpdateScore();
        AudioSource.PlayClipAtPoint(audio.clip, transform.position);
        Destroy(gameObject);
    }
}
