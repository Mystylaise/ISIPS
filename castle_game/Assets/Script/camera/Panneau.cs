using UnityEngine;
using System.Collections;

public class Panneau : MonoBehaviour {
	public Canvas canvas;


	// Use this for initialization
	void Start () {
		canvas.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D(Collider2D other)
			{
			
		if(other.name == "Chevalier de la RoseCulotte")
					{
						canvas.enabled = true;
					}
			}
	void OnTriggerExit2D(Collider2D other) 
			{
			
		if(other.name == "Chevalier de la RoseCulotte")
					{
						canvas.enabled = false;
					}
			}
}