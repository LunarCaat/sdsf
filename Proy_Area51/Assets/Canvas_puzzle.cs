﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas_puzzle : MonoBehaviour {
	public Canvas canvas_puz;
	// Use this for initialization
	void Start () {
		canvas_puz.enabled=false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag =="Player"){
			 canvas_puz.enabled=true;
			 Movement.isPuzzleNotActive=true;
			 Destroy(gameObject);

		}
	}
}
