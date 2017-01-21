using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class hand : MonoBehaviour {
    Rigidbody shoulder;
    Rigidbody elbow;
    Rigidbody wrist;
    List<Quaternion> shoulderPosition;
    List<Quaternion> elbowPosition;

    List<Quaternion> shoulderPositiontmp;
    List<Quaternion> elbowPositiontmp;


	// Use this for initialization
	void Start () {
    elbowPositiontmp = new List<Quaternion>();
    shoulderPositiontmp = new List<Quaternion>();
    shoulderPosition = new List<Quaternion>();
    elbowPosition = new List<Quaternion>();
    shoulderPosition.Add(new Quaternion(-0.1f,0.7f,0.1f,0.7f));
    elbowPosition.Add(new Quaternion(0.0f,-0.7f,0.0f,0.7f));

    
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
    Debug.Log(shoulder.rotation.ToEuler().x + " "+ Quaternion.Euler(60,0,0).x);
   if(shoulder.rotation.ToEuler().x > Quaternion.Euler(60,0,0).x) {
   Debug.Log("onnistuu");
   }

   // Debug.Log("Shoulder: "+shoulder.rotation+"\nElbow"+elbow.rotation);
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
