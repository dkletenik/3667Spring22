using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    const int NUM_COINS = 10;
    [SerializeField] GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    { 
   
        int xMin = -21;
        int xMax = 0;
        int yMin = 0;
        int yMax = 8;

        for (int i = 0; i < NUM_COINS; i++)
        {
            Vector2 position = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
            Instantiate(coin, position, Quaternion.identity);
        }
    }
}
