#pragma strict
@script ExecuteInEditMode()

function OnGUI()
{
	if(GUI.Button(Rect(Screen.width/2-75,Screen.height/2.5-20,150,30),"Jouer"))
	{
		Application.LoadLevel(1);
		print("starting new game...");
	}
}