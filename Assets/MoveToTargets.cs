using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToTargets : MonoBehaviour
{

	public GameObject targetsParent;
	private Transform[] targets;
	public int currentIndex;

	private NavMeshAgent agent;

	// Use this for initialization
	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
		targets = targetsParent.GetComponentsInChildren<Transform>();
		currentIndex = Random.Range(0, targets.Length);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (agent.remainingDistance < 2)
		{
			/*currentIndex++;
			if (currentIndex >= targets.Length)
			{
				currentIndex = 0;
			}*/
			currentIndex = Random.Range(0, targets.Length);
			agent.SetDestination(targets[currentIndex].position);
		}
	}
}
