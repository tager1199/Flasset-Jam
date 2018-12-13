using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;


public class Birds : MonoBehaviour {
	int lives = 5;
	bool IsUp = false;
	float timer = 0;
	// Use this for initialization
	void Start () {

	}


	void Play()
	{
		
		
		Debug.Log("play");
		Vector3 up = new Vector3(0, 2);
		Vector3 down = new Vector3(0, -2);

		float gametime = Time.time;
		//bool clicked = false;
		if (IsUp == false)
		{
			transform.Translate(up);
			IsUp = true;
		}

		int WaitTime = 3;

		if (gametime < 60 && gametime >20)
		{
			WaitTime = 2;
		}
		else if (gametime > 60)
		{
			WaitTime = 1;
		}

		if (timer >= WaitTime && IsUp == true)
		{
			Debug.Log("timerMax reached !");
			transform.Translate(down);
			IsUp = false;
			timer = 0;

		}

		//transform.Translate(down);
		//if (clicked == false)
		//{
		//	lives -= 1;
		//}
	}
	
	// Update is called once per frame
	void Update () {

		if (lives > 0)
		{
			
			int rand = UnityEngine.Random.Range(1, 1000);
			if (rand < 5)
			{
				Play();
				lives = 0;
			}
								
		}
		timer += Time.deltaTime;
		


	}
}
