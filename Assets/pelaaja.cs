using UnityEngine;
using System.Collections;

public class pelaaja : MonoBehaviour {
    public float distance;
    Transform cam;
    hand asd;
    public int hp = 3;
    public int points = 0;
	// Use this for initialization
	void Start () {
    asd = gameObject.GetComponentInChildren<hand>();
	cam  = Camera.main.transform;
	}
	RaycastHit hit;
	// Update is called once per frame
	void Update () {
	if(Physics.Raycast(cam.position,cam.forward,out hit,distance) && hit.transform.tag == "kulkija" && asd.saako) {
    Debug.Log(hit.transform.name);
    int tmp = hit.collider.transform.GetComponent<kulkija>().GetMessage(asd.current);
    if(tmp == 1) {
    points++;
    }else if(tmp == -1) {hp--; }
	}
    }
}
