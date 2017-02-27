using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    private Text _text;
    private float _CurrentScore = 0;
    const string ScorePrefix = "Score : ";

	// Use this for initialization
	void Start () {
        _text = this.GetComponent<Text>();
        _text.text = ScorePrefix + _CurrentScore;
	}

    public void AddScore(int score)
    {
        _CurrentScore += score;
        _text.text = ScorePrefix + _CurrentScore;
    }

	// Update is called once per frame
	void Update () {
		
	}
}
