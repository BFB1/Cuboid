using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class CameraTrack : MonoBehaviour
{
	
	// Controls camera movement

	public Transform target;
	public Vector3 offset;
	public float smoothSpeed;
	
	
	public float minX;
	public float maxX;
	
	public float minY;
	public float maxY;

	public float minZ;
	public float maxZ;


	
	void Update ()
	{
		Vector3 desiredPosition = target.position + offset;
		Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
		
		smoothedPosition.x = Mathf.Clamp(smoothedPosition.x, minX, maxX);
		smoothedPosition.y = Mathf.Clamp(smoothedPosition.y, minY, maxY);
		smoothedPosition.z = Mathf.Clamp(smoothedPosition.z, minZ, maxZ);

		transform.position = smoothedPosition;
		transform.LookAt(target);
	}
}
