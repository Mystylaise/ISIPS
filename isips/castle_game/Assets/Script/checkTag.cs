using UnityEngine;
using System.Collections;

public class checkTag : MonoBehaviour {

	public bool SurEchelle;
	public bool InTower;
	public bool bordLevier;
	public BoxCollider2D edgefini;
	public SpriteRenderer AnimLevier;
	public MeshRenderer RenduTour;
	public float climbSpeed;
	private float climbVelocity;
	private float gravityStore;
	private Rigidbody2D myrigidbody2d;

	// Use this for initialization
	void Start () {

		myrigidbody2d = GetComponent<Rigidbody2D> ();
		gravityStore = myrigidbody2d.gravityScale;
		RenduTour = GetComponent<MeshRenderer> ();
		AnimLevier = GetComponent<SpriteRenderer> ();

	}
	
	// Update is called once per frame
	void Update () {
		if(this.CompareTag("sol")){
			Debug.Log ("tu es sur le sol");}

		if (SurEchelle) {
			myrigidbody2d.gravityScale = 0f;
			climbVelocity = climbSpeed * Input.GetAxisRaw("Vertical");
			myrigidbody2d.velocity = new Vector2(myrigidbody2d.velocity.x, climbVelocity);

		}

		if (!SurEchelle) {
			myrigidbody2d.gravityScale = gravityStore;
		}





	}

	void OnCollisionEnter2D(Collision2D other)
	{
		//tu peux tester de différentes manieres

		// 1- Soit l'objet avec lequel la collision s'effectue est taggé, dans ce cas tu peux utiliser son tag comme condition :
		if (other.gameObject.tag == "sol")
		{
			Debug.Log ("tu es entrer en collision"); // attention: gameObject et pas GameObject
		}
	}


}
