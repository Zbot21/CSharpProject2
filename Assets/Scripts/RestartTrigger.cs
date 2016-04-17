using UnityEngine;
using System.Collections;

public class RestartTrigger : MonoBehaviour {

	public GameObject platform;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.CompareTag("Player")){
			GameObject.Find("hero").transform.position = new Vector3(0, 4, -1);
			GameObject[] endObjects = GameObject.FindGameObjectsWithTag ("Respawn");
			for (int i = 0; i < endObjects.Length; i++) {
				if(endObjects[i] != null)
					Destroy(endObjects[i]);
			}
			Coin.ChangePointsPerCoin (Coin.pointsPerCoin * 2);
			Instantiate (platform, new Vector2(0, 0), Quaternion.identity);
			((SpawnMonitor)GameObject.Find ("SpawnManager").GetComponent (typeof(SpawnMonitor))).Spawn ();
		}
	}
}
