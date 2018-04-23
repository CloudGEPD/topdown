using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public float destroytime;
    public int damage;

    void Start()
    {
        Destroy(gameObject, destroytime);
    }
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Enemy")
        {
            other.gameObject.GetComponent<Health>().TookDamage(damage);
            Destroy(gameObject);
            
        }
    }

}
