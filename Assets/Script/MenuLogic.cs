using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuLogic : MonoBehaviour {
	public GameObject menuARPanel;
	public GameObject virtualisasiPanel;
	public GameObject bantuanPanel;
	public GameObject aboutPanel;
	public GameObject fasilitasPanel;
	public GameObject infoPanel;
	public GameObject panggungPanel;
	public GameObject tengahPanel;
	public GameObject depanPanel;
	public LoadSceneMode loadMode = LoadSceneMode.Single;


	public void LoadScene(string sceneName){
		SceneManager.LoadScene (sceneName, loadMode);	
	}

	// Use this for initialization
	void Start () {
		Screen.autorotateToLandscapeRight = true;
		menuARPanel.SetActive (true);
		bantuanPanel.SetActive (false);
		aboutPanel.SetActive (false);
	}

	public void BantuanClicked(){
		bantuanPanel.SetActive (true);
		menuARPanel.SetActive (false);
		aboutPanel.SetActive (false);
	}

	public void AboutClicked(){
		aboutPanel.SetActive (true);
		menuARPanel.SetActive (false);
		bantuanPanel.SetActive (false);
	}

	public void QuitClicked(){
		Application.Quit ();
	}

	public void FasilitasClicked(){
		fasilitasPanel.SetActive (true);
		infoPanel.SetActive (false);
	}

	public void TengahClicked(){
		tengahPanel.SetActive (true);
		panggungPanel.SetActive (false);
		depanPanel.SetActive (false);
	}

	public void PanggungClicked(){
		panggungPanel.SetActive (true);
		tengahPanel.SetActive (false);
		depanPanel.SetActive (false);
	}

	public void DepanClicked(){
		depanPanel.SetActive (true);
		panggungPanel.SetActive (false);
		tengahPanel.SetActive (false);
	}
}