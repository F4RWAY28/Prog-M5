using UnityEngine;

public class balls : MonoBehaviour
{
    private Vector3 position;
    private GameObject ball;
    public GameObject prefab;
    
    private float elapsedTime = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start");

        for (int i = 0; i < 100; i++)
        {
            ball = CreateBall(-10, 10);
        }
    }

    // Update is called once per frame
    void Update()
    {
        

        elapsedTime += Time.deltaTime;

        if (elapsedTime > 1f)
        {
            ball = CreateBall(-10, 10);
            elapsedTime = 0f;
        }

        for(int i = 0; i < 100; i++)
        {
            ball = CreateBall(-10, 10);
        }

        if (elapsedTime == 3f)
        {
            DestroyBall(ball);
        }
    }



    private GameObject CreateBall(float min, float max)
    {
        GameObject bl = Instantiate(prefab, position, Quaternion.identity);
        Material material = bl.GetComponent<MeshRenderer>().material;
        
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        
        Color randColor = new Color(r, g, b, 1f);

        position = new Vector3(Random.Range(min, max), 0, Random.Range(-10.0f, 10.0f));

        if (material.shader.name == "Universal Render Pipeline/Lit")
        {
            material.SetColor("_BaseColor", randColor);
        }

        return bl;
    }

    private void DestroyBall(GameObject ball)
    {
        Destroy(ball);
    }


    
    
}
