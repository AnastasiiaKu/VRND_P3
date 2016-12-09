using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in Update() 
	public bool locked;
	public bool hasKey;
	public bool shouldOpen;

	void Start() {
		locked = true;
		hasKey = false; 
		shouldOpen = false;
	}
		

    void Update() {
		
		// If the door is unlocked and it is not fully raised
		if (shouldOpen == true) {
			Debug.Log ("We are in shouldOpen");
			if (transform.position.y < 20f) {
				// Animate the door raising up
				transform.Translate (0, 5.0f * Time.deltaTime, 0, Space.World);
			} 
		}
	}
    
	public void onDoorCliked () {
		Debug.Log ("We are in onDoorCLicked");
		//if no key. then bad sound
		if (hasKey == false) {
			
			
		}

		//if there's a key. door opens, happy sound
		if (hasKey == true) {
			shouldOpen = true;
		}
	}

	public void Unlock()
    {
        // You'll need to set "locked" to true here
		hasKey = true;
		if(hasKey){
			Debug.Log ("We have a key");
			locked = false;
		}
		//locked = false;
		//hasKey = true;
		Debug.Log ("We are in unlock()");
    }
}
