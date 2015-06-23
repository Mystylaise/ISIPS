using UnityEngine;
using System.Collections;

public class ZoneTower : MonoBehaviour {
	
	private checkTag player;
	public MeshRenderer RenduTour;
	// Use this for initialization
	void Start () {
		player = FindObjectOfType<checkTag> ();
		RenduTour = GetComponent<MeshRenderer> ();
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "chevalier")
		{
			player.InTower = true;
			Debug.Log (" tu entre dans la tour");
			RenduTour.enabled=false;
		}
	}
	
	void OnTriggerExit2D (Collider2D other)
	{
		if (other.gameObject.tag == "chevalier")
		{
			player.InTower = false;
			RenduTour.enabled=true;
		}
	}
}