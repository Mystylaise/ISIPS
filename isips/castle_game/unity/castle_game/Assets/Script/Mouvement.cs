using UnityEngine;
using System.Collections;

public class Mouvement : MonoBehaviour {

	public float vitesse = 1f;

	private Animator anim;


	void Start () {
		anim = GetComponent<Animator> ();

	
	}
	

	void Update () {

		transform.rotation = Quaternion.Euler (0, 0, 0);	

			if (Input.GetKey (KeyCode.LeftArrow)) {
			//transform.position += new Vector3(-0.05f,0,0);
			transform.position -= new Vector3 (vitesse * Time.deltaTime, 0, 0);
			transform.localScale = new Vector3 (-1, 1, 1);


			anim.SetFloat ("vitesse", 2);
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			//this.GetComponent<Rigidbody2D>().AddForce(new Vector2(4,0));/
			//Time.deltaTime = regule La vitesse peu importe LayerMask puissance du pc
			transform.position += new Vector3 (vitesse * Time.deltaTime, 0, 0);
			transform.localScale = new Vector3 (1, 1, 1);

			anim.SetFloat ("vitesse", 2);
		} 



		else {
			anim.SetFloat ("vitesse", 0);
		}

		}//finUpdate

	void OnCollisionEnter2D(Collision2D other)
	{
		//si le tag de l'objet qui rentre en collision avec This est "sol"
		if (other.gameObject.tag == "glace")
		{
			if (Input.GetKey (KeyCode.LeftArrow)){
			this.GetComponent<Rigidbody2D>().AddForce(new Vector2(-50,0));
			}
			if (Input.GetKey (KeyCode.RightArrow)){
				this.GetComponent<Rigidbody2D>().AddForce(new Vector2(50,0));
			}
			Debug.Log ("tu est entrer en collision avec la glace"); 
		}



			
	}



} 