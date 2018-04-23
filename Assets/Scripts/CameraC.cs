using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraC : MonoBehaviour
{
    public float speed;
    public Vector3 offset;
    private Vector3 velocity;
    private Transform player;

    private void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    void FixedUpdate()
    {
        transform.position = Vector3.SmoothDamp(transform.position, player.position + offset, ref velocity, speed);
    }

}
