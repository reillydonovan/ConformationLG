﻿using UnityEngine;

public class Rotate : MonoBehaviour
{
	void Update()
	{
		// Rotate the object around its local X axis at 1 degree per second
		transform.Rotate(Time.deltaTime, Time.deltaTime, Time.deltaTime);

		// ...also rotate around the World's Y axis
	//transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
	}
}