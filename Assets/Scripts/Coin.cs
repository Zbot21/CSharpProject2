using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	public static int pointsPerCoin = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void ChangePointsPerCoin(int points){
		pointsPerCoin = points;
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.CompareTag("Player")){
			((Scoring)GameObject.Find ("SpawnManager").GetComponent (typeof(Scoring))).score += pointsPerCoin;
			Destroy (gameObject);
		}
	}
}
