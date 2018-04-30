using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AI : MonoBehaviour
{
    NavMeshAgent agent;
    GameObject player;
	void Start ()
    {
        player = GameObject.Find("Player");
        agent = GetComponent<NavMeshAgent>();
	}
	
	void Update ()
    {
        agent.destination = player.transform.position;
	}
}
