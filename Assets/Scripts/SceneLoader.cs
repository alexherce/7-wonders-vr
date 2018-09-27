using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	public string scene;
	private bool collided = false;

	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.name == "OVRPlayerController")
		{
			// Application.LoadLevel(scene.name);

			if(OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger)) {
				SceneManager.LoadScene(scene, LoadSceneMode.Single);
			}
		}
	}
}
