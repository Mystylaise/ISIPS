#pragma strict

var guiMode : String = "InGame";

function Update()
{
  if(Input.GetKeyDown("escape"))
	{
		Time.timeScale = 0;
		guiMode = "Paused";
	}
}

function OnGUI()
{
	if(guiMode == "Paused")
	{
		if(GUI.Button(Rect(Screen.width/2-75,Screen.height/2-20,150,30),"Retour au jeu"))
		{	Time.timeScale = 1;
			guiMode = "InGame";
			print("resume...");
		}
		if(GUI.Button(Rect(Screen.width/2-75,Screen.height/2+20,150,30),"Revenir au menu"))
		{
			Application.LoadLevel(0);
			Time.timeScale = 1;
			print("quiting...");
		}
	}
}