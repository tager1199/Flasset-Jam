using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour
{


	void Start()
	{
		
	}

	void Update()
	{
		int speed = 2;
		Vector3 point = new Vector3 (3, 3, 3);

		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.RotateAround(point, Vector3.down, speed);
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.RotateAround(point, Vector3.up, speed);
		}
		
	}
}
