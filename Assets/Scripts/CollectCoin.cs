using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    [SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        MasterInfo.coinCount += 1;
        this.gameObject.SetActive(false);
    }
}
