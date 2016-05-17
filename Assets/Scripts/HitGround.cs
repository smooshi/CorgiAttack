using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class HitGround : MonoBehaviour {
	private Canvas canvas;
	private Menu menu;
	private EdgeCollider2D edgy;

	// Use this for initialization
	void Awake () {
		canvas = GameObject.Find ("Canvas").GetComponent<Canvas>();
		menu = canvas.GetComponent<Menu> ();
		edgy = GetComponent<EdgeCollider2D> ();
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.layer == 10) { //player
			edgy.enabled = false;
			Debug.Log("Corgi hit edge of platform");
			other.GetComponent<PlatformerCharacter2D> ().CorgiCollision ();
			int playerScore = other.GetComponent<PlatformerCharacter2D> ().GetPoints ();
			menu.Death(playerScore);
			//täällä vois esim soittaa musaa tjsp
		}
	}
}
