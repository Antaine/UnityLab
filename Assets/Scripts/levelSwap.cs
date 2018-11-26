using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSwap : MonoBehaviour {
public string levelToLoad;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.C)) {
       SceneManager.LoadScene(levelToLoad);
	   	Debug.Log("Test");
     }
}

}
