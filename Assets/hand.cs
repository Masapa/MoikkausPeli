using UnityEngine;
using System.Collections;

public class hand : MonoBehaviour {
    Rigidbody shoulder;
    Rigidbody elbow;
    Rigidbody wrist;

	// Use this for initialization
	void Start () {

    
     Transform[] transsi = gameObject.GetComponentsInChildren<Transform>();
     foreach (Transform t in transsi)
 {
// Debug.Log(t.name);
     if(t.name == "shoulder")
     {
     Debug.Log("osui");
     shoulder = t.GetComponent<Rigidbody>();
     }
     if(t.name == "elbow") {
     elbow = t.GetComponent<Rigidbody>();
     }
     if(t.name == "wrist") {
     wrist = t.GetComponent<Rigidbody>();
     }
 }

	}
	
	// Update is called once per frame
	void FixedUpdate () {
    Debug.Log("Shoulder: "+shoulder.rotation+"\nElbow"+elbow.rotation);
    if(Input.GetKey(KeyCode.A)) {
    //Debug.Log("asd");
    shoulder.velocity = Vector3.up * 5;
   
    }

      if(Input.GetKey(KeyCode.S)) {
    elbow.velocity = Vector3.up * 5;
    }

      if(Input.GetKey(KeyCode.D)) {
    // * 100);
    }
	

    if(Input.GetKey(KeyCode.Space)) {


    }

	}
}
