using UnityEngine;
using System.Collections;

public class ZoneLevier : MonoBehaviour {

	private checkTag player;
	public Animator AnimLevier;
	public BoxCollider2D edgefini;


	// Use this for initialization
	void Start () {
		player = FindObjectOfType<checkTag> ();
		AnimLevier = GetComponent<Animator> ();
		edgefini = GetComponent<BoxCollider2D> ();
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "chevalier")
		{
			player.bordLevier = true;

			Debug.Log("tu est pres du levier");
			AnimLevier.enabled = true;
			edgefini.enabled=false;


		}


	}
	
	void OnTriggerExit2D (Collider2D other)
	{
		if (other.gameObject.tag == "chevalier")
		{
			player.bordLevier = false;
		}
	}
}
