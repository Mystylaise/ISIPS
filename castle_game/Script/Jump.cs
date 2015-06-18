using UnityEngine;
//8\\ Important ne pas supprimer
using System.Collections;

public class Jump : MonoBehaviour {

	bool surLeSol = false;

		
	void Update(){
		//si tu appuye sur Barre d'espace et surLeSol = true
		if(Input.GetKeyDown (KeyCode.Space) && surLeSol ){
			//sur le rigidbody2D, la velocity est remplacer par un vecteur3(0,4,0);
			GetComponent<Rigidbody2D>().velocity = new Vector3 (0,4,0);
			surLeSol = false;
		}

	}

	void OnCollisionEnter2D(Collision2D other)
	{
		//si le tag de l'objet qui rentre en collision avec This est "sol"
		if (other.gameObject.tag == "sol" )
		{
			surLeSol = true;
			Debug.Log ("tu est entrer en collision"); 
		}

		if (other.gameObject.tag == "glace" )
		{
			surLeSol = true;

			Debug.Log ("tu est entrer en collision avec la glace"); 
		}

		
		if (other.gameObject.tag == "piege" )
		{

			Destroy (gameObject);
			Debug.Log ("tu perd un point de vie"); 
		}


	}

}
