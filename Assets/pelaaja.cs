using UnityEngine;
using System.Collections;

public class pelaaja : MonoBehaviour {
    public float distance;
    Transform cam;
    hand asd;
	// Use this for initialization
	void Start () {
    asd = GetComponent<hand>();
	cam  = Camera.main.transform;
	}
	RaycastHit hit;
	// Update is called once per frame
	void Update () {
	if(Physics.Raycast(cam.position,cam.forward,out hit,distance) && hit.transform.tag == "kulkija") {
    Debug.Log(hit.transform.name);
    if( hit.collider.transform.GetComponent<kulkija>().GetMessage(asd.current)) {
    Debug.Log("YOU GOT MAIL!");

    
    }
	}
    }
}
