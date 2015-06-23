using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Mouvement player;

	public bool isFollowing;

	public float XOffset;
	public float YOffset;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<Mouvement> ();
		isFollowing = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (isFollowing)
			transform.position = new Vector3 (player.transform.position.x + XOffset, player.transform.position.y + YOffset, transform.position.z);
	}
}
