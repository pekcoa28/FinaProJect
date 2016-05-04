using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Shoot : MonoBehaviour {
	bool Shootss;
	public GameObject shot;
	public Transform shotSpawn;
	private int ctn;
	private int j;
	private int sus;
	public Button Button;
	public Button Buttons;
	public Text GameOver;
	public GameObject BG;
	public Text BText;
	private Transform Shootr;
	private float ro;
	void Start ()
	{
		//Rigidbody rb = GetComponent<Rigidbody> ();
		Button.gameObject.SetActive (false);
		Buttons.gameObject.SetActive (false);
		GameOver.gameObject.SetActive (false);
		BG.gameObject.SetActive (false);
		ro = -50.00f;
		ctn = 0;
		j = 5;
		BText.text = "Bullet :" + j.ToString();
		UpdateScore ();
		sus = 0;
	}


	// Update is called once per frame
	public  void Shoots () {
		
		if (Shootss || ctn  == 0) {
		Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
			Shootss = false;
			ctn++;
			j = j - 1;
			UpdateScore ();
				Debug.LogFormat("j >> j = {0}",j);

	}
		if (j == 0){
			BG.gameObject.SetActive (true);
			Button.gameObject.SetActive (true);
			Buttons.gameObject.SetActive (true);
			GameOver.gameObject.SetActive (true);
		}



	}


	public void sup(int cnt){
		
		Shootss = true;
	}
	public void su(int c){

		Shootss = true;
	}
	void UpdateScore ()
	{
		BText.text = "Bullet :" + j.ToString();

	}
	public void clickup()
	{

		if (Input.GetButtonDown ("Fire1")) {
			var newRot = Quaternion.RotateTowards (transform.rotation, Quaternion.Euler (0.0f, 0.0f, 250.0f), Time.deltaTime * 250);

		
			transform.rotation = newRot;
			shotSpawn.rotation = newRot;	
			Debug.LogFormat("ro >> ro = {0}",ro);

		}
	}
	public void clickdown()
	{			

		if (Input.GetButtonDown ("Fire1")) {
			
			var newRot = Quaternion.RotateTowards (transform.rotation, Quaternion.Euler (0.0f, 0.0f, 320.0f), Time.deltaTime * 320);


			transform.rotation = newRot;
			shotSpawn.rotation = newRot;	
			Debug.LogFormat("ro >> ro = {0}",ro);

		}
	}
}


