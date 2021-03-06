﻿using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    public float playerSpeed = 20;

    float horizontalSpeed = 2f;
    float verticalSpeed = 2f;

    float maxYaw = 40;
    float minYaw = -40;
    float maxPitch = 13;
    float minPitch = -13;

    float yaw = 0f;
    float pitch = 0f;

    UIScript UIref;

    void Start()
    {
        UIref = FindObjectOfType<UIScript>();
    }

	void Update () {

        //Liikuttaa pelaajaa
        if (!UIref.gamePaused) {
            gameObject.transform.Translate(Vector3.right * playerSpeed / 100, Space.World);
            RotateCamera();
        }
	}

    void RotateCamera()
    {
        yaw += horizontalSpeed * Input.GetAxis("Mouse X");
        yaw = Mathf.Clamp(yaw, minYaw, maxYaw);

        pitch -= verticalSpeed * Input.GetAxis("Mouse Y");
        pitch = Mathf.Clamp(pitch, minPitch, maxPitch);

      //  Debug.Log("Yaw: " + yaw + "  " + "Pitch: " + pitch);

        transform.localEulerAngles = new Vector3(pitch, yaw + 90, 0);
    }
}
