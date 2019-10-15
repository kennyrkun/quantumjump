using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomOfWorldDetector : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("saving player from falling out of the world");


            // freeze it
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

            // then teleport it to the world origin
            other.transform.position = new Vector3(0, 1.5f, 0);
        }
    }
}
