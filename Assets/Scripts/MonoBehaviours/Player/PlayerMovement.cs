using UnityEngine.AI;
using System.Collections;
using UnityEngine.EventSystems; //To use event systems
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Animator animator;
	public NavMeshAgent agent;
	public float inputHoldDelay = 0.5f; // How long to hold the character from moving during animation
	public float turnSpeedThreshold = 0.5f;


	private WaitForSeconds inputHoldWait;
	private Vector3 destinationPosition;

	private const float stopDistanceProportion = 0.1f;

	private void Start()
	{
		agent.updateRotation = false; //Don't want the agent to updates it's rotation

		inputHoldWait = new WaitForSeconds (inputHoldWait);

		destinationPosition = transform.position;

	}



	private void OnAnimatorMove()
	{

		//Setting the agents velocity based off it's position from the last evaluated frame
		agent.velocity = animator.deltaPosition / Time.deltaTime; 
	}



	private void Update ()
	{
		//Path is being computed but not ready yet for the agent
		if (agent.pathPending) 
		{
			return;
		}
	
		float speed = agent.desiredVelocity.magnitude;
	
	
		if (agent.remainingDistance <= agent.stoppingDistance * stopDistanceProportion) 
		{
			//Call the Stopping function
			Stopping(out speed);
		}
	
		else if(agent.remainingDistance <= agent.stoppingDistance)
		{
			//Call the Slowing down function
			Slowing(out speed, agent.remainingDistance);
		}
	
		else if (speed > turnSpeedThreshold)
		{
			//FINISH CODE HERE!!!!
		}
	
	}

	//Stopping Function
	private void Stopping(out float speed)
	{

	}

	//Slowing Function
	private void Slowing(out float speed,float distanceToDestination)
	{

	}

	
	private void Moving()
	{

	}

}
