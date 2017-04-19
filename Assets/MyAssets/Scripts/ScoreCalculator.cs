using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCalculator : MonoBehaviour {

    public Text scoreText;

    int score = 0;
    string text = "/15 Collected";

	void Start () {
		
	}

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString() + text;
    }
}
