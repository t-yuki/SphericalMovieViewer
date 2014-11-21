﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class textureRenew : MonoBehaviour {
	
	private List<Texture> texList;
	private int frame;
	
	private float oldTime;
	private const float INTERVAL = 0.1f;
	
	void Start (){
		texList = new List<Texture> ();
		for (int i = 50; i <= 54; i++) {
			texList.Add (Resources.Load ("frame" + i.ToString ()) as Texture);
		}
		
		oldTime = Time.realtimeSinceStartup;
		frame = 0;
	}
	
	void Update () {
		
		float time = Time.realtimeSinceStartup - oldTime;
		if (time >= INTERVAL)
		{
			renderer.material.mainTexture = texList [frame];
			
			frame++;
			if (frame >= texList.Count) {
				frame = 0;
			}
			oldTime = Time.realtimeSinceStartup;
		}
	}
}
