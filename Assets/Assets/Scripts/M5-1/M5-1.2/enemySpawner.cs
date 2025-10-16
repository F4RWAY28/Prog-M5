using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private List<GameObject> enemies = new List<GameObject>();

    public GameObject enemyPrefab;

    private float elapsedTime = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start!");   
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("'W' Pressed!");

            CreateWave(100);
        }

        elapsedTime += Time.deltaTime;

        if(elapsedTime > 1f)
        {
            CreateWave(3);

            elapsedTime = 0f;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log("'Q' Pressed!");
            for (int i = 0; i < enemies.Count; i++)
            {
                Destroy(enemies[i]);
            } 
            
            enemies.Clear();
        }

        Debug.Log(enemies.Count);
    }
    
    private void CreateWave(int waveSize)
    {
        for (int i = 0; i < waveSize; i++)
        {
            enemies.Add(Instantiate(enemyPrefab));    
        }
    }
}
