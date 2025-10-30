using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField] float Speed = 10;
    [SerializeField] float jumpForce = 1;
    [SerializeField] GameObject cam;
    Rigidbody rb;
    Vector3 speedVector;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            speedVector = cam.transform.forward;
            speedVector.y = 0;
            speedVector.Normalize();
            rb.AddForce(speedVector  * Speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            speedVector = -cam.transform.forward;
            speedVector.y = 0;
            speedVector.Normalize();
            rb.AddForce(speedVector * Speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            speedVector = -cam.transform.right;
            speedVector.y = 0;
            speedVector.Normalize();
            rb.AddForce(speedVector * Speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            speedVector = cam.transform.right;
            speedVector.y = 0;
            speedVector.Normalize();
            rb.AddForce(speedVector * Speed);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 jumpSpeedVector;
            jumpSpeedVector = rb.linearVelocity;
            jumpSpeedVector.y = jumpForce;
            rb.linearVelocity = jumpSpeedVector;
        }


    }
}
