﻿using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	
	public static int score;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "SCORE  " + score;
	}
	
	public static void IncreaseScore(int amount) {
		score += amount;	
	}
}