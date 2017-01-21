using UnityEngine;
using System.Collections;

public class Fiilistelyscript : MonoBehaviour {

    public float playerSpeed = 20;

    float horizontalSpeed = 2f;
    float verticalSpeed = 2f;

    float yaw = 0f;
    float pitch = 0f;

	void Update () {

        //Liikuttaa pelaajaa
        //gameObject.transform.Translate(Vector3.right * playerSpeed / 100, Space.World);

        RotateCamera();
	}

    void RotateCamera()
    {
        yaw += horizontalSpeed * Input.GetAxis("Mouse X");
        pitch -= verticalSpeed * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0f);
    }
}
