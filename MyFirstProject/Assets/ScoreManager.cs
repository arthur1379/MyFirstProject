using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    private Text _text; // 宣告 Text 元件
    private float _CurrentScore = 0; // 設定目前的分數  值為0
    const string ScorePrefix = "Score : ";  // 設定字串

    // Use this for initialization
    void Start () {
        _text = this.GetComponent<Text>(); // 擷取在物件上的Text元件
        _text.text = ScorePrefix + _CurrentScore;  // 物件Text.text (Text的顯示文字) 為 ScorePrefix 和 _CurrentScore 兩個字串疊加
    }

    public void AddScore(int score) // 自行宣告函式 AddScore 並且設為Public 讓外部程式可以呼叫
    {
        _CurrentScore += score; // 目前分數 加上 score
        _text.text = ScorePrefix + _CurrentScore; // 物件Text.text (Text的顯示文字) 為 ScorePrefix 和 _CurrentScore 兩個字串疊加
    }

    // Update is called once per frame
    void Update () {
		
	}
}
