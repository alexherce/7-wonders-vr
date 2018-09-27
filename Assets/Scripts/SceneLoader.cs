using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour {
	
	public Object scene;

	void OnTriggerEnter(Collider other)
     {
         if (other.tag == "Player") 
         {
			Application.LoadLevel(scene.name);
         }
     }
}
