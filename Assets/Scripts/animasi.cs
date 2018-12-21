using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animasi : MonoBehaviour {
	public Animation anim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		anim = GetComponent<Animation>();
		foreach (AnimationState state in anim)
		{
			state.speed = 2F;
		}

	}
}
