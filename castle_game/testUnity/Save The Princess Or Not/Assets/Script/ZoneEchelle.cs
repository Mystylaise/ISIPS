using UnityEngine;
using System.Collections;

public class ZoneEchelle : MonoBehaviour {

	private checkTag player;
	// Use this for initialization
	void Start () {
		player = FindObjectOfType<checkTag> ();
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "chevalier")
		{
			player.SurEchelle = true;
		}
	}

	void OnTriggerExit2D (Collider2D other)
	{
		if (other.gameObject.tag == "chevalier")
		{
			player.SurEchelle = false;
		}
	}
}
