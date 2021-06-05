using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripts : MonoBehaviour
{
    float accel = 10.0f;
    Rigidbody rb;
    [SerializeField]
    private GameObject Ball;
    [SerializeField]
    private GameObject BallPosision;

    static public bool ballExistFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * accel * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right * accel * Time.deltaTime;
        }

        //rb.AddForce(transform.right * Input.GetAxis("Horizontal") * accel ,ForceMode.Impulse);
        if (Input.GetKeyDown("space"))
        {
            if (!ballExistFlag)
            {
                Instantiate(Ball, BallPosision.transform.position, BallPosision.transform.rotation);
                ballExistFlag = true;
            }
        
        }
    }
}
