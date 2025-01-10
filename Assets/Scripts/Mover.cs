using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10.0f;
    Vector3 playerMovement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move using arrow keys or wasd");
        Debug.Log("Don't bump into objects!");
    }

    void MovePlayer()
    {
        playerMovement = new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed, 
        0.00f, 
        Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed);
        transform.Translate(playerMovement);
    }
}
