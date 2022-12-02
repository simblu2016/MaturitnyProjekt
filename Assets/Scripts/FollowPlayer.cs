using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public Camera mainCamera;


    void Update()
    {
            mainCamera.transform.position = player.position + offset;       
    }
}