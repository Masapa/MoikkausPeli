using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour {

    public float playerSpeed = 20;

    float horizontalSpeed = 2f;
    float verticalSpeed = 2f;
    float maxYaw = 30;
    float minYaw = -30;
    float maxPitch = 13;
    float minPitch = -13;
    float yaw = 0f;
    float pitch = 0f;

    List<Sprite> ImageList = new List<Sprite>();

	void Update () {

        //Liikuttaa pelaajaa
        gameObject.transform.Translate(Vector3.right * playerSpeed / 100, Space.World);
        ImageList.Add(Resources.Load<Sprite>("Sprites/uispritesheet01/uispritesheet01_31"));
        Debug.Log(ImageList[0]);

        RotateCamera();
	}

    void RotateCamera()
    {
        yaw += horizontalSpeed * Input.GetAxis("Mouse X");
        yaw = Mathf.Clamp(yaw, minYaw, maxYaw);

        pitch -= verticalSpeed * Input.GetAxis("Mouse Y");
        pitch = Mathf.Clamp(pitch, minPitch, maxPitch);

        transform.localEulerAngles = new Vector3(pitch, yaw + 90, 0);
    }
}
