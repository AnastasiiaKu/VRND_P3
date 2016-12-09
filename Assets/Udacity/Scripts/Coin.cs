using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
	// public Coin coin;
	public GameObject coinPoof;

    public void OnCoinClicked() {
        
		// Instantiate the CoinPoof Prefab where this coin is located, poof particles moving vertically
		Instantiate(coinPoof, transform.position,Quaternion.Euler(270, 0, 0));
        
		// Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy(gameObject, 1.0f);
    }

}
