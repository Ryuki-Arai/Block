using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControler : MonoBehaviour
{
    [SerializeField]
    private float speed = 100.0f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce((transform.forward + transform.right) * speed,ForceMode.VelocityChange);
    }
}
