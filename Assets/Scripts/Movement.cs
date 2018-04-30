using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public LayerMask groundlayer;
    public Animator animator;

    private float x;
    private float y;
    private Vector3 direction;

    void Update()
    {
        Look();
        Move();

        
    }
    void Move()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        animator.SetFloat("Horizontal", x);
        animator.SetFloat("Vertical", y);

        direction = new Vector3(x, 0, y);

        if(direction == Vector3.zero)
        {
            animator.SetBool("IsRunning", false);
        }
        else
        {
            animator.SetBool("IsRunning", true);
        }
        direction = Vector3.ClampMagnitude(direction, 1);
        direction *= speed * Time.deltaTime;
        transform.position += direction;

    }
    void Look()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
       if(Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity, groundlayer))
        {
            transform.LookAt(hit.point);
        }
    }
}
