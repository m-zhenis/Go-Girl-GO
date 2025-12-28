using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    [SerializeField] GameObject player;
    void OnTriggerEnter(Collider other)
    {
        player.GetComponent<PlayerMovement>().enabled = false;
    }
}
