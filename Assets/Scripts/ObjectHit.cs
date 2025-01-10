using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    MeshRenderer meshRenderer;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.material.color = Color.red;

            gameObject.tag = "Hit";
        }
    }
}
