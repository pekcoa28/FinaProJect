
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Corttor : MonoBehaviour {


	public GameObject hazard;

	//public Vector3 spawnValues;

	public Text countText;
	private int count1;
	int tion;

	void Start(){
		

		count1 = 0;
		countText.text = "Score :" + count1.ToString();
		UpdateScore ();

			
	}



	public void AddScore (int newScoreValue)
	{
		count1 += newScoreValue;
		Debug.LogFormat("count >> count = {0}",count1);

		UpdateScore ();

	}

	void UpdateScore ()
	{
		countText.text = "Score: " + count1.ToString ();
	}




}

