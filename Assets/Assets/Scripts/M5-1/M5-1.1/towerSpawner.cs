using UnityEngine;
using UnityEngine.UIElements;

public class towerSpawner : MonoBehaviour
{
    private GameObject tower;
    public GameObject towerPrefab;

    private float elapsedTime = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {


        elapsedTime += Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            tower = CreateTower(-10, 10);
        }
    }



    private GameObject CreateTower(float min, float max)
    {

        Vector3 position = new Vector3(Random.Range(min, max), Random.Range(0f, 0f), Random.Range(-10.0f, 10.0f));

        GameObject twr = Instantiate(towerPrefab, position, Quaternion.identity);

        float randomScale = Random.Range(1f, 2f);

        twr.transform.localScale = new Vector3 (randomScale, randomScale, randomScale);
        
        return twr;
    }
}


