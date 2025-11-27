using UnityEngine;

public class DikenController : MonoBehaviour
{
    [SerializeField] float damage = 10;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(collision.gameObject.GetComponent<HealtController>().healt <= 0)
            {
                return;
            }
            Debug.Log("PLay Dikene Carpti");
            collision.gameObject.GetComponent<HealtController>().healt -= damage;
            if(collision.gameObject.GetComponent<HealtController>().healt <= 0)
            {
                collision.gameObject.GetComponent<HealtController>().healt = 0;
                Debug.Log("Player Oldu.");
            }
        }
    }
}
