using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Rigidbody Player;

    private float playerSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerSpeed = 40f; 

        Player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            Player.AddForce(transform.right * -playerSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Player.AddForce(transform.right * playerSpeed);
        }
    }
}
