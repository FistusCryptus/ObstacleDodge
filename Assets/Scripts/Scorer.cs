using UnityEngine;

public class Scorer : MonoBehaviour
{
    int bumpTimes = 0;
    private void OnCollisionEnter()
    {
        bumpTimes++;
        Debug.Log("You've bumped into a thing this many times: " + bumpTimes);
    }
}
