using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownWall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            Destroy(collision.gameObject);
            PlayerScripts.ballExistFlag = false;
        }
    }
}
