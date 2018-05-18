using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public PlayerData pData;

    private void FixedUpdate()
    {
        MovePlayer();
    }

    // Simple movement of 8 directions, controlled with WASD
    private void MovePlayer()
    {
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-pData.movementSpeedX, pData.movementSpeedY, 0);
        }
        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(pData.movementSpeedX, pData.movementSpeedY, 0);
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-pData.movementSpeedX, -pData.movementSpeedY, 0);
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(pData.movementSpeedX, -pData.movementSpeedY, 0);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, pData.movementSpeedY, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-pData.movementSpeedX, 0, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, -pData.movementSpeedY, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(pData.movementSpeedX, 0, 0);
        }
    }
}
