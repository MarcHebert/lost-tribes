using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Player_NetworkSetup : NetworkBehaviour {

	[SerializeField] Camera FPSCharacterCam;
	[SerializeField] AudioListener audioListener;
//	[SerializeField] UnityStandardAssets.Characters.FirstPerson.FirstPersonController swag;


	// Use this for initialization
	public override void OnStartLocalPlayer ()
	{
		GameObject.Find("SceneCamera").SetActive(false);
		GetComponent<CharacterController>().enabled = true;
		GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController> ().enabled = true;
		//swag = GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController> ();
		//Debug.Log (swag);
		//swag.enabled = true;
		FPSCharacterCam.enabled = true;
		Debug.Log (FPSCharacterCam.enabled);
		audioListener.enabled = true;

//		Renderer[] rens = GetComponentsInChildren<Renderer>();
//		foreach(Renderer ren in rens)
//		{
//			ren.enabled = false;
//		}

		//GetComponent<NetworkAnimator>().SetParameterAutoSend(0, true);
	}

	public override void PreStartClient ()
	{
		//GetComponent<NetworkAnimator>().SetParameterAutoSend(0, true);
	}

	// When we are destroyed
	void OnDisable ()
	{
		//GameObject.Find("Scene Camera").SetActive(true); MAYBE
	}

}
