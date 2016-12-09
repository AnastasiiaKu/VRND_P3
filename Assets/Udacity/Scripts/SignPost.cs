using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour
{	
	public void ResetScene() {
        // Reset the scene when the user clicks the sign post
		Debug.Log ("My method was called!");
		SceneManager.LoadScene ("Maze");
	}
}