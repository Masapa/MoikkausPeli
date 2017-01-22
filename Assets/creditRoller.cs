using UnityEngine;
using System.Collections;

public class creditRoller : MonoBehaviour {
	
    public float rollSpeed = 1;

	void Update () {
        gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + rollSpeed, transform.position.z);
	if(gameObject.transform.position.y > 2000) {
    Application.LoadLevel(0);
    }
        }
}
