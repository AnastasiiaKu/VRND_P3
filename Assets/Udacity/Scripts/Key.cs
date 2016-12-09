using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door

	public GameObject keyPoof;
	public Door door;

	public void OnKeyClicked() {

		Debug.Log ("We have clicked this key");
		
        // Instatiate the KeyPoof Prefab where this key is located, poof animated vertically
		Instantiate(keyPoof, transform.position,Quaternion.Euler(270, 0, 0));

        // Call the Unlock() method on the Door
		//door.Unlock();
		door.GetComponent<Door> ().hasKey = true;
		//door.GetComponent<Door>().Unlock();

        // Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy(gameObject, 1.0f);
    }

}
