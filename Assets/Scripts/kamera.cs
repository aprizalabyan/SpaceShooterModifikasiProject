using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour {

	[SerializeField]
	private Transform target;

	[SerializeField]
	private Vector3 offsetPosition;

	[SerializeField]
	private Vector3 offsetRotation;

	private void LateUpdate(){
		if (target == null){
			Debug.LogWarning("Missing target ref !", this);
			return;
		}
		transform.position = target.TransformPoint (offsetPosition);
		transform.rotation = Quaternion.Euler (offsetRotation);
	}
}
