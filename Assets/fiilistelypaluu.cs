using UnityEngine;
using System.Collections;

public class fiilistelypaluu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	gameObject.transform.Translate(Vector3.right* 0.1f, Space.World);
	}
}
