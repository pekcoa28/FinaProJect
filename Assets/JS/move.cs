using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	
	Rigidbody rd;
	private Shoot shoot;	

	float oo;
	int cnt;
	void Start(){


		GameObject gameControllerObject = GameObject.FindWithTag("Shoot");
		if (gameControllerObject != null)
		{
			shoot = gameControllerObject.GetComponent <Shoot>();
		}
		if (shoot == null)
		{
			Debug.Log ("Cannot find 'Corttor' script");
		}
	

		rd = GetComponent<Rigidbody> ();
		rd.velocity = new Vector3 (10, 5, 0);

	}

	void OnCollisionEnter (Collision other) {
		
		if (other.gameObject.tag=="Cubered") 
		{
			
			Destroy (this.gameObject);
			cnt = 0;
			shoot.sup (cnt);
		}



	

		else if (other.gameObject.tag == "Plane")
		{
			Debug.LogFormat("Update >> lastVelocity = {0}",lastVelocity);

			rd.velocity = new Vector3 (0, -lastVelocity, 0);
			if(lastVelocity > -11){
				Destroy (this.gameObject);
				cnt = 0;
				shoot.sup (cnt);
			}
		}

	}




	float lastVelocity;
	void Update ()
	{
		

		if (rd != null && rd.velocity.y < 0 ) {
			lastVelocity = rd.velocity.y;
		//	Debug.LogFormat("Update >> lastVelocity = {0}",lastVelocity);
		}
	}
	void OnCollisionExit(Collision other)
	{
		if (other.gameObject.tag== "Plane")
		{

			rd.velocity = new Vector3 (0, rd.velocity.y, 0);
		}
	}

}
	