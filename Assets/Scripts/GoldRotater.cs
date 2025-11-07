using System;
using UnityEngine;

public class GoldRotater : MonoBehaviour
{
    [SerializeField] Vector3 rotationSpeed;
    void Start()
    {
        
    }

    void Update()
    {
    //    Quaternion quaternion = transform.rotation;
    //    quaternion.eulerAngles += rotationSpeed;
    //    transform.rotation = quaternion;
        transform.Rotate(rotationSpeed);
    }
}
