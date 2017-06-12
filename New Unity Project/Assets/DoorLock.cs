using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorLock : MonoBehaviour {


		
	public string label;
	public GUIStyle guistyle;
	public GUIText guicolor;


	// Use this for initialization
	void Start () {

		this.label = "";
		this.guistyle.fontSize = 30;
		this.guistyle.

		//this.guicolor.color = #FFFFFF ;
		//this.guistyle.fontStyle = "white";
		
	}

	public void PressKey(int nKey){

		switch (nKey)
		{
		case 1:
			label += "1";
			break;
		case 2:	
			label += "2";
			break;
		case 3:	
			label += "3";
			break;
		case 4:	
			label += "4";
			break;
		case 5:
			label += "5";
			break;
		case 6:	
			label += "6";
			break;
		case 7:	
			label += "7";
			break;
		case 8:	
			label += "8";
			break;
		case 9:
			label += "9";
			break;
		case 0:
			label += "0";
			break;
		}

	}

	void OnGUI(){
		

		GUI.Label(new Rect(0, 130, 160, 50), label, guistyle);


	}


	// Update is called once per frame
/*	void Update () {

	}*/


}
