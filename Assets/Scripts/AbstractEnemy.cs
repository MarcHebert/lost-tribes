using UnityEngine;
using System.Collections;

public abstract class AbstractEnemy : MonoBehaviour {

	//Controls enemy movement based on behavior
	public abstract void Patrol();

	//Inflicts attack damage on player
	public abstract void Attack();

	//Change behavior - dormant, static, hostile
	public abstract void ChangeBehavior();
	
	public abstract bool isHostile();

	public abstract bool isDormant();

	//NPC death - sets animations and spawns new enemy player after a delay
	public abstract void Die();

	//Spawns enemy in random location based on enemy type
	
	public abstract void setHealth(float health);

	//Set enemy weapon
	public abstract void ChooseWeapon();
	
	public abstract void Despawn();

	//Returns true if player is within a certain range of the enemy
	public abstract bool SeesPlayer();
}
