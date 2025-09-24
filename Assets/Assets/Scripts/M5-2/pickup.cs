using System;
using Unity.VisualScripting;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public int points = 0;

    public static event Action<int> PickedUp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Begin");
        if (collision.CompareTag("Player"))
        {
            PickedUp?.Invoke(points);

            Debug.Log("collision detected");
            Destroy(gameObject);
        }
    }
}
