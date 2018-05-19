using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public PlayerData pData;
    public Animator pAnim;
    public Transform mainCamera;

    private void FixedUpdate()
    {
        MovePlayer();
    }

    // Simple movement of 8 directions, controlled with WASD
    private void MovePlayer()
    {
        mainCamera.position = transform.position + new Vector3(0,0,-pData.cameraHeight);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            pAnim.SetBool("Moving", true);

            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
            {
                transform.position += new Vector3(-pData.movementSpeedX, pData.movementSpeedY, 0);
                transform.localEulerAngles = new Vector3(0, 0, 45f);
            }
            else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(pData.movementSpeedX, pData.movementSpeedY, 0);
                transform.localEulerAngles = new Vector3(0, 0, 315f);
            }
            else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
            {
                transform.position += new Vector3(-pData.movementSpeedX, -pData.movementSpeedY, 0);
                transform.localEulerAngles = new Vector3(0, 0, 135f);
            }
            else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(pData.movementSpeedX, -pData.movementSpeedY, 0);
                transform.localEulerAngles = new Vector3(0, 0, 225f);
            }
            else if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, pData.movementSpeedY, 0);
                transform.localEulerAngles = new Vector3(0, 0, 0);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.position += new Vector3(-pData.movementSpeedX, 0, 0);
                transform.localEulerAngles = new Vector3(0, 0, 90f);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.position += new Vector3(0, -pData.movementSpeedY, 0);
                transform.localEulerAngles = new Vector3(0, 0, 180f);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(pData.movementSpeedX, 0, 0);
                transform.localEulerAngles = new Vector3(0, 0, 270);
            }
        }
        else
        {
            pAnim.SetBool("Moving", false);
        }
    }
}
