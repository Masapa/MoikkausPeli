using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class hand : MonoBehaviour {
    Rigidbody shoulder;
    Rigidbody elbow;
    Rigidbody wrist;

    SkinnedMeshRenderer bs;


	// Use this for initialization
	void Start () {
    bs = GetComponentInChildren<SkinnedMeshRenderer>();

    
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
   // Debug.Log(shoulder.rotation.eulerAngles.x + " ");
   if(shoulder.rotation.eulerAngles.x > 330) {
  // Debug.Log("onnistuu");
   }

    Debug.Log("Shoulder: "+shoulder.velocity+"\nElbow"+elbow.rotation);
    if(Input.GetKey(KeyCode.A)) {
    //Debug.Log("asd");
    elbow.velocity= Vector3.up * 5;
    
    }

      if(Input.GetKey(KeyCode.S)) {
    wrist.velocity = Vector3.up * 5;
    }

      if(Input.GetKey(KeyCode.D)) {
        for(int i = 0;i<6;i++) {
    bs.SetBlendShapeWeight(i,0);
    }
    bs.SetBlendShapeWeight(1,100);
    }
	

    if(Input.GetKey(KeyCode.E)) {
    for(int i = 0;i<6;i++) {
    bs.SetBlendShapeWeight(i,0);
    }
    bs.SetBlendShapeWeight(0,100);
    }

        if(Input.GetKey(KeyCode.C)) {
    for(int i = 0;i<6;i++) {
    bs.SetBlendShapeWeight(i,0);
    }
    bs.SetBlendShapeWeight(2,100);
    }


        if(Input.GetKey(KeyCode.R)) {
    for(int i = 0;i<6;i++) {
    bs.SetBlendShapeWeight(i,0);
    }
    bs.SetBlendShapeWeight(3,100);
    }

        if(Input.GetKey(KeyCode.F)) {
    for(int i = 0;i<6;i++) {
    bs.SetBlendShapeWeight(i,0);
    }
    bs.SetBlendShapeWeight(4,100);
    }

        if(Input.GetKey(KeyCode.V)) {
    for(int i = 0;i<6;i++) {
    bs.SetBlendShapeWeight(i,0);
    }
    bs.SetBlendShapeWeight(5,100);
    }



	}
}
