using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	//initialize sizes and positions of bars
	Vector2 size = new Vector2 (200, 20);

	//health variables
	Vector2 healthPos = new Vector2(20, 20);
	public Texture2D healthBarEmpty;
	public Texture2D healthBarFull;
	int healthFallRate = 80;
	float health = 100;

	//stamina variables
	Vector2 staminaPos = new Vector2(20, 40);
	public Texture2D staminaBarEmpty;
	public Texture2D staminaBarFull;
	int staminaFallRate = 50;
	float stamina = 100;

	//hunger variables
	Vector2 hungerPos = new Vector2(20, 60);
	public Texture2D hungerBarEmpty;
	public Texture2D hungerBarFull;
	int hungerFallRate = 100;
	float hunger = 100;
	//private CharacterMotor chMotor;
	private CharacterController controller;
	//private FirstPersonController fpc;
	bool canJump = false;
	float jumpTimer = 0.7f;


	// Use this for initialization
	void Start () {

		controller = GetComponent <CharacterController>();

	}

	void OnGUI() {

		//Health GUI
		GUI.BeginGroup (new Rect (healthPos.x, healthPos.y, size.x, size.y));
		GUI.Box (new Rect (0, 0, size.x, size.y), healthBarEmpty); 

		GUI.BeginGroup (new Rect (0, 0, size.x * health/100, size.y));
		GUI.Box(new Rect(0, 0, size.x, size.y), healthBarFull);

		GUI.EndGroup ();
		GUI.EndGroup ();

		//Stamina GUI
		GUI.BeginGroup (new Rect (staminaPos.x, staminaPos.y, size.x, size.y));
		GUI.Box (new Rect (0, 0, size.x, size.y), staminaBarEmpty); 
		
		GUI.BeginGroup (new Rect (0, 0, size.x * stamina/100, size.y));
		GUI.Box(new Rect(0, 0, size.x, size.y), staminaBarFull);
		
		GUI.EndGroup ();
		GUI.EndGroup ();

		//Hunger GUI
		GUI.BeginGroup (new Rect (hungerPos.x, hungerPos.y, size.x, size.y));
		GUI.Box (new Rect (0, 0, size.x, size.y), hungerBarEmpty); 
		
		GUI.BeginGroup (new Rect (0, 0, size.x * hunger/100, size.y));
		GUI.Box(new Rect(0, 0, size.x, size.y), hungerBarFull);
		
		GUI.EndGroup ();
		GUI.EndGroup ();


	}
	// Update is called once per frame
	void Update () {
		//Hunger controls
		//xxBarDisplay variables should have values between 0 and 1
		if (hunger <= 0) {
			health -= (Time.deltaTime / healthFallRate * 2)*100;
			hunger = 0;
		}

		if (hunger > 0) {
			hunger -= (Time.deltaTime / hungerFallRate)*100;
		}
		if (hunger >= 100) {
			hunger = 100;
		}

		/*if (healthBarDisplay <= 0) {
			CharacterDeath ();*/

		//Stamina controls
		if (controller.velocity.magnitude > 0 && Input.GetKey(KeyCode.LeftShift)) {
			stamina -= (Time.deltaTime / staminaFallRate)*100;
			//character can run
		}
		else {
			stamina += (Time.deltaTime / staminaFallRate)*100;
			//character isn't running
		}

		if (stamina >= 100)
			stamina = 100;
		if (stamina <= 0)
			stamina = 0;
	}
		
}
