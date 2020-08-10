using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Rotator : MonoBehaviour
{
	float RotationSpeed = 3f;

	private void Update()
	{
		if (Input.GetKey(KeyCode.Mouse0))
		{
			float XAxis = Input.GetAxis("Mouse X") * RotationSpeed;
			transform.Rotate(Vector3.down, XAxis);
		}
	}
}