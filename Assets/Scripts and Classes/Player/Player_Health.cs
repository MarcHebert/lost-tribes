using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Player_Health : NetworkBehaviour {

	[SerializeField] private int fullHealth = 100;

	[SyncVar (hook = "OnHealthChanged")][SerializeField]private int health = 100;
	private Text healthText;
	private bool shouldDie = false;
	public bool isDead = false;

	public delegate void DieDelegate();
	public event DieDelegate EventDie;

	public delegate void RespawnDelegate();
	public event RespawnDelegate EventRespawn;

	public override void OnStartLocalPlayer ()
	{
		healthText = GameObject.Find("Health Text").GetComponent<Text>();
		SetHealthText();
	}

	// Update is called once per frame
	void Update () 
	{
		CheckCondition();
	}

	void CheckCondition()
	{
		if(health <= 0 && !shouldDie && !isDead)
		{
			shouldDie = true;
		}

		if(health <= 0 && shouldDie)
		{
			if(EventDie != null)
			{
				EventDie();
			}

			shouldDie = false;
		}

		if(health > 0 && isDead)
		{
			if(EventRespawn != null)
			{
				EventRespawn();
			}

			isDead = false;
		}
	}

	void SetHealthText()
	{
		if(isLocalPlayer)
		{
			healthText.text = "Health " + health.ToString();
		}
	}

	public void DeductHealth (int dmg)
	{
		health -= dmg;
	}

	void OnHealthChanged(int hlth)
	{
		health = hlth;
		SetHealthText();
	}

	public void ResetHealth() //Called Player_Respawn
	{
		Debug.Log ("Reset Health");
		health = fullHealth;
	}

}
