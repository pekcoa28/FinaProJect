using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class P1 : MonoBehaviour {


	public GameObject hazard;
	public float delta = 1.5f;
	public float speed = 2.0f;
	//public Vector3 spawnValues;
	public int hazardCount = 1;
	public int count;
	public int c;
	private Corttor corttor;	
	private Shoot shoot;	
	void Start(){
		

		GameObject gameControllerObject = GameObject.FindWithTag("Corttor");
		if (gameControllerObject != null)
		{
			corttor = gameControllerObject.GetComponent <Corttor>();
		}
		if (corttor == null)
		{
			Debug.Log ("Cannot find 'Corttor' script");
		}

		GameObject ShootObject = GameObject.FindWithTag("Shoot");
		if (ShootObject != null)
		{
			shoot = ShootObject.GetComponent <Shoot>();
		}
		if (shoot == null)
		{
			Debug.Log ("Cannot find 'Corttor' script");
		}


	}


	void OnCollisionEnter (Collision other) {
		
		if (other.gameObject.tag=="C1") 
		{
			


				

					
						float haza = Random.Range (8.0f, 11f);
						GameObject hazard2 = (GameObject)Instantiate (hazard, new Vector3 (14.06f, haza, 15.01f), Quaternion.identity);
						hazard2.transform.Rotate (0, 0, 0);

			Destroy (other.gameObject);
			Destroy (gameObject);
				
				
				}

		corttor.AddScore (count);
		c = 0;
		shoot.sup (c);
			}

				








	}

		


		



