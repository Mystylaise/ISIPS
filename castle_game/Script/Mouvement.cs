using UnityEngine;
using System.Collections;

public class Mouvement : MonoBehaviour {

	public float vitesse = 1f;
	private CharacterController body;
	private Animator anim;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKey(KeyCode.LeftArrow)){
			//transform.position += new Vector3(-0.05f,0,0);
			transform.position -= new Vector3(vitesse * Time.deltaTime ,0,0);
			Debug.Log("gauche");
		}

	else if (Input.GetKey(KeyCode.RightArrow)){
			//this.GetComponent<Rigidbody2D>().AddForce(new Vector2(4,0));/
			//Time.deltaTime = regule La vitesse peu importe LayerMask puissance du pc
			transform.position += new Vector3(vitesse * Time.deltaTime ,0,0);
			Debug.Log("droite");
		}

		}//finUpdate

	void OnCollisionEnter2D(Collision2D other)
	{
		//si le tag de l'objet qui rentre en collision avec This est "sol"
		if (other.gameObject.tag == "glace")
		{
			this.GetComponent<Rigidbody2D>().AddForce(new Vector2(70,0));

			Debug.Log ("tu est entrer en collision avec la glace"); 
		}
		
		
	}
} 