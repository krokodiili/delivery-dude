using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public PlayerData pData;
    public Animator pAnim;
    public Transform mainCamera;

    private bool allowMovement = true;

    private void FixedUpdate()
    {
        MoveCameraPosition();

        if (allowMovement == true)
        {
            MovePlayer();
        }
    }

    public void SetAllowMovement(bool value)
    {
        allowMovement = value;
    }

    // Sets camera position to player's position
    private void MoveCameraPosition()
    {
        mainCamera.position = transform.position + new Vector3(0, 0, -pData.cameraHeight);
    }

    // Simple movement and rotation of the character gameobject with 8 directions, controlled with WASD. When pressing left shift, the character runs
    private void MovePlayer()
    {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            pAnim.SetBool("Moving", true);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                pAnim.SetBool("Running", true);
            }
            else
            {
                pAnim.SetBool("Running", false);
            }

            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    transform.position += new Vector3(-pData.runningSpeedX, pData.runningSpeedY, 0);
                }
                else
                {
                    transform.position += new Vector3(-pData.movementSpeedX, pData.movementSpeedY, 0);
                }

                transform.localEulerAngles = new Vector3(0, 0, 45f);
            }
            else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    transform.position += new Vector3(pData.runningSpeedX, pData.runningSpeedY, 0);
                }
                else
                {
                    transform.position += new Vector3(pData.movementSpeedX, pData.movementSpeedY, 0);
                }
                
                transform.localEulerAngles = new Vector3(0, 0, 315f);
            }
            else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    transform.position += new Vector3(-pData.runningSpeedX, -pData.runningSpeedY, 0);
                }
                else
                {
                    transform.position += new Vector3(-pData.movementSpeedX, -pData.movementSpeedY, 0);
                }

                transform.localEulerAngles = new Vector3(0, 0, 135f);
            }
            else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    transform.position += new Vector3(pData.runningSpeedX, -pData.runningSpeedY, 0);
                }
                else
                {
                    transform.position += new Vector3(pData.movementSpeedX, -pData.movementSpeedY, 0);
                }
                
                transform.localEulerAngles = new Vector3(0, 0, 225f);
            }
            else if (Input.GetKey(KeyCode.W))
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    transform.position += new Vector3(0, pData.runningSpeedY, 0);
                }
                else
                {
                    transform.position += new Vector3(0, pData.movementSpeedY, 0);
                }
                
                transform.localEulerAngles = new Vector3(0, 0, 0);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    transform.position += new Vector3(-pData.runningSpeedX, 0, 0);
                }
                else
                {
                    transform.position += new Vector3(-pData.movementSpeedX, 0, 0);
                }
                
                transform.localEulerAngles = new Vector3(0, 0, 90f);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    transform.position += new Vector3(0, -pData.runningSpeedY, 0);
                }
                else
                {
                    transform.position += new Vector3(0, -pData.movementSpeedY, 0);
                }
                
                transform.localEulerAngles = new Vector3(0, 0, 180f);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    transform.position += new Vector3(pData.runningSpeedX, 0, 0);
                }
                else
                {
                    transform.position += new Vector3(pData.movementSpeedX, 0, 0);
                }
                
                transform.localEulerAngles = new Vector3(0, 0, 270);
            }
        }
        else
        {
            pAnim.SetBool("Moving", false);
            pAnim.SetBool("Running", false);
        }
    }
}
