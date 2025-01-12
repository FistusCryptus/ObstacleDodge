using Unity.VisualScripting;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float projectileSpeed = 0.0f;
    Vector3 playerPosition;
    
    void Awake()
    {
        gameObject.SetActive(false);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();   
    }

    void MoveToPlayer()
    {
        playerPosition = player.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, 
        playerPosition, 
        Time.deltaTime * projectileSpeed);
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
