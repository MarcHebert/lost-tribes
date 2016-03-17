using UnityEngine;
using System.Collections;

public class Boar : AbstractEnemy {
	
	//TODO: movement, attacks, etc..

	public GameObject player;

	NavMeshAgent agent;

	// Use this for initialization
	void Start () {

		//FOR NAVMESH
		//move to Patrol()
		agent = GetComponent<NavMeshAgent> ();
		if (tag.Equals ("Boar")) {
			//Issue: boar's rotation isn't preserved while navigating
			agent.updateRotation = false;
		}


		player = GameObject.FindGameObjectWithTag ("Player");

	}

	void Update() {

		//test - random location
		agent.destination = new Vector3 (2949, 350, 816);

	}

	//TODO:

	//Controls movement and plays walking animations
	public override void Patrol(){
		//borrowing from: http://answers.unity3d.com/questions/429623/enemy-movement-from-waypoint-to-waypoint.html
		//nvm use navmesh

	}
	
	//Inflicts attack damage on player
	public override void Attack(){}

	public override void ChangeBehavior(){}
	
	public override bool isHostile(){
		//TODO
		return false;
	}
	
	public override bool isDormant() {
		//TODO
		return false;
	}
	
	//NPC death - sets animations and spawns new enemy player after a delay
	public override void Die() {}
	
	public override void setHealth(float health){}
	
	//Set enemy weapon
	public override void ChooseWeapon() {}
	
	public override void Despawn() {}
	
	//Returns true if player is within a certain range of the enemy
	public override bool SeesPlayer() {
		//TODO
		return false;
	}
}
