using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public float destroytime;

    void Start()
    {
        Destroy(gameObject, destroytime);
    }
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
	
	
}
