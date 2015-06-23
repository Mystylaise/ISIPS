#pragma strict

var drap :int;
var Timer :int;
var MaxTimer :int;
var fade : boolean=false;
var img : Sprite;
var imgBlank : Sprite;


function Update () {

	if (drap == 0)
	{
	Timer+=1;
	
		if(Timer>=MaxTimer)
		{
		Timer = 0;
	
		if (fade == true)
		{
		fade=false;
		GetComponent(SpriteRenderer).sprite = imgBlank;
		GetComponent.<Collider2D>().enabled=false;
		return;
		}
		
		if (fade == false)
		{
		fade=true;
		GetComponent(SpriteRenderer).sprite = img;
		GetComponent.<Collider2D>().enabled=true;
		return;
		}
		
		}
	}
		



}