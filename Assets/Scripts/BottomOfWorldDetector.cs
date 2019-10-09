using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomOfWorldDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("saving player from falling out of the world");

        // then freeze it
        other.GetComponent<Rigidbody>().velocity = Vector3.zero;
        other.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        // teleport it to the world origin
        other.transform.position = new Vector3(0, 1.5f, 0); 
    }
}
