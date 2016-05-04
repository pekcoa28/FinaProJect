
using UnityEngine;
using System.Collections;

public class UPDOWN : MonoBehaviour {
	 Rigidbody rb;
	public float lastVelocity;


	 int tion;
	void Start()
	{
		tion = 1; //ตัวแปรไว้เช็ค
		rb = GetComponent<Rigidbody> ();

		rb.velocity = new Vector3 (0, 2, 0); //เซ็ทความเร็วขึ้น บน2
	}
	void Update ()
	{		
		if (rb != null && rb.velocity.x != 0 ) {
			lastVelocity = rb.velocity.x;

		}
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag== "Cube" ) 
		{
			if(tion == 1)// เมื่อชนกำแพงใสด้านบน ให้ความขึ้นติดลบลง 
			{
				rb.velocity = new Vector3 (0, -2, 0);

				tion = 0;//เซ็ทค่าตัวแปรเป็น

			}
			else // พอชนกำแพงใสข้างล่างอีกทีเข้าelseและให้ความเป็น2
			{
				rb.velocity = new Vector3 (0, 2, 0);
				tion = 1;
			}
		}

	}

}
