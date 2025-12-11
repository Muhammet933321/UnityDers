using UnityEngine;

public class AuioSorceWİthSpeed : MonoBehaviour
{
    Rigidbody rb;
    public AudioController audioController;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<Rigidbody>(out Rigidbody rb2))
        {
            Vector3 speed = rb.linearVelocity - rb2.linearVelocity;
            float speedTotal = speed.magnitude;

            float t = Mathf.InverseLerp(0f, 22f, speedTotal);
            Debug.Log($"Speed: {speedTotal}, Normalized: {t}");

            audioController.PlayAuidoWithVolume(t);
        }
        else
        {
            Vector3 speed = rb.linearVelocity;
            float speedTotal = speed.magnitude;

            float t = Mathf.InverseLerp(0f, 22f, speedTotal);
            Debug.Log($"Speed: {speedTotal}, Normalized: {t}");

            audioController.PlayAuidoWithVolume(t);
        }
    }
}
