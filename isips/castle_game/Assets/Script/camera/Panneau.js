#pragma strict

var canvas : Canvas;

function Start () {
	canvas.enabled = false;
}

function OnTriggerEnter2D (other : Collider2D) {
	if(other.gameObject == "chevalier"){
		canvas.enabled = true;
	}
}

function OnTriggerExit2D (other : Collider2D) {
	if(other.gameObject == "chevalier"){
		canvas.enabled = false;
	}
}