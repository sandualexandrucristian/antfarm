using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodScript : MonoBehaviour {

    bool paused = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void pausUnpause(){
		this.paused = !this.paused;
	}
}