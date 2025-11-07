using UnityEngine;

public class GoldController : MonoBehaviour
{
    public ScoreController scoreController;
    private void Start()
    {
        scoreController = GetComponent<ScoreController>();
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("OnCollisionEnter Tetiklendi !");
        
    //    if (collision.gameObject.CompareTag("Gold"))
    //    {
    //        scoreController.score++;
    //        //Altýný yoket
    //        Destroy(collision.gameObject);
    //    }
        
    //}
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnCollisionEnter Tetiklendi !");

        if (other.gameObject.CompareTag("Gold"))
        {
            scoreController.score++;
            //Altýný yoket
            Destroy(other.gameObject);
        }
    }

}
