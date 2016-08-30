using UnityEngine;
using System.Collections;

public class MenuAR : MonoBehaviour {

	//variable resize layar
	public GUISkin guiSkin;
	private float guiRatio;
	private float sWidth;
	private Vector3 GuisF;

	public GameObject askripsi;
	public float kecepatanRotasi = 10f;
	bool statusRotasi = false;

	void awake(){
		sWidth = Screen.width;
		guiRatio = sWidth / 1920;
		GuisF = new Vector3 (guiRatio,guiRatio, 1);
	}

	void onGUI(){
		GUI.skin = guiSkin;
	}


	void Rotasi(){
		GUI.matrix = Matrix4x4.TRS (new Vector3 (Screen.width-258*GuisF.x,GuisF.y, 0),Quaternion.identity,GuisF);

		if (statusRotasi==false){
			if(GUI.Button(new Rect(-208,10,238,59),"Rotasi")){
				statusRotasi = true;
			}
		}else{
			if (GUI.Button (new Rect (-208, 10, 238, 59), "Stop Rotasi")) {
				statusRotasi = false;
			}
		}
		if(GUI.Button(new Rect(40,10,208,59),"Keluar")){
			Application.Quit();
		}
	}


}