using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float projectileSpeed = 0.0f;
    Vector3 playerPosition;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, 
        playerPosition, 
        Time.deltaTime * projectileSpeed);
    }

    void DestroyWhenReached()
    {
        if(transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
