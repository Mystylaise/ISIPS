using UnityEngine;
using System.Collections;

public class checkTagSol : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(this.CompareTag("sol")){
			Debug.Log ("tu est sur le sol");}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		//tu peux tester de différentes manieres

		// 1- Soit l'objet avec lequel la collision s'effectue est taggé, dans ce cas tu peux utiliser son tag comme condition :
		if (other.gameObject.tag == "sol")
		{
			Debug.Log ("tu est entrer en collision"); // attention: gameObject et pas GameObject
		}
	}
}
