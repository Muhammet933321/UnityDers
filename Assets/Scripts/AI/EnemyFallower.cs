using UnityEngine;

public class EnemyFallower : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, speed);
        
    }
}
