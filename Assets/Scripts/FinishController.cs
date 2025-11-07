using UnityEngine;

public class FinishController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Bitiþe Ulaþtý !!");
        }
    }
}
