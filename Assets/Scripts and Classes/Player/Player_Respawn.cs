using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Player_Respawn : NetworkBehaviour {

	private Player_Health healthScript;
	private Image crossHairImage;
	private GameObject respawnButton;
	private Button test;

	public override void PreStartClient ()
	{
		healthScript = GetComponent<Player_Health>();
		healthScript.EventRespawn += EnablePlayer;
	}

	public override void OnStartLocalPlayer ()
	{
		Debug.Log ("Player Respawn Start");
		crossHairImage = GameObject.Find("Crosshair Image").GetComponent<Image>();
		SetRespawnButton();
	}

	public void SetRespawnButton ()
	{
		if(isLocalPlayer)
		{
			respawnButton = GameObject.Find("GameManager").GetComponent<GameManager_References>().respawnButton;
			Debug.Log(respawnButton);
			test = respawnButton.GetComponent<Button>();
			Debug.Log (test);
			test.onClick.AddListener(() => CommenceRespawn());
			respawnButton.SetActive(false);
		}
	}

//	void Update ()
//	{
//		SetRespawnButton ();
//	}

	public override void OnNetworkDestroy ()
	{
		healthScript.EventRespawn -= EnablePlayer;
	}

	void EnablePlayer()
	{
		GetComponent<CharacterController>().enabled = true;
		GetComponent<Player_Shoot>().enabled = true;
		GetComponent<BoxCollider>().enabled = true;
		
		Renderer[] renderers = GetComponentsInChildren<Renderer>();
		foreach(Renderer ren in renderers)
		{
			ren.enabled = true;
		}

		if(isLocalPlayer)
		{
			GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = true;
			crossHairImage.enabled = true;
			respawnButton.SetActive(false);
		}
	}

	void CommenceRespawn()
	{
		CmdRespawnOnServer();
	}

	[Command]
	void CmdRespawnOnServer()
	{
		healthScript.ResetHealth();
	}

}
