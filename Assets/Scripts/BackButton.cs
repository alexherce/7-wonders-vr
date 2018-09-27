﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (OVRInput.Get(OVRInput.Button.Two)) {
			SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
		}
	}
}
