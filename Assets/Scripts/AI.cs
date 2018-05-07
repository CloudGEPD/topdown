using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    NavMeshAgent agent;
    GameObject player;
    Animator animator;

    void Start()
    {
        player = GameObject.Find("Player");
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        agent.destination = player.transform.position;
        Move();

    }

    void Move()
    {
        if(agent.velocity==Vector3.zero)
            animator.SetBool("IsMoving", false);
        else
            animator.SetBool("IsMoving", true);
    }
}
