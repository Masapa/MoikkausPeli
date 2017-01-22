using UnityEngine;
using System.Collections;

public class Rotater : MonoBehaviour {

    GameObject target;

    void Start()
    {
        target = FindObjectOfType<PlayerScript>().gameObject;
    }

    void Update()
    {
        var targetPosition = target.transform.position;
        targetPosition.y = transform.position.x;
        transform.LookAt(targetPosition);
        transform.eulerAngles = new Vector3(
        270,
        transform.eulerAngles.y,
        transform.eulerAngles.z
        );
    }
}
