using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOController : MonoBehaviour {

    public float forceValue; // 控制加速度的數值

    private Rigidbody2D rigibody2D = null; // Rigidbody2Dk的元件

    public ScoreManager scoremanager; //  呼叫ScoreManager的程式

    // Use this for initialization
    void Start () {
        rigibody2D = this.GetComponent<Rigidbody2D>(); // 指定UFO物件中的Rigidbody2D進來
    }

   // public float speed = 10;
	
	// Update is called once per frame
	void Update () {
        Vector2 force2D = Vector2.zero; // 加速度 一開始設定為0

        if (Input.GetKey(KeyCode.W))
        {
            force2D.y += forceValue; // 按下W鍵 往Y軸上方加速前進
        }
        if (Input.GetKey(KeyCode.S))
        {
            force2D.y -= forceValue; // 按下S鍵 往Y軸下方加速前進
        }
        if (Input.GetKey(KeyCode.A))
        {
            force2D.x -= forceValue; // 按下A鍵 往X軸左方加速前進
        }
        if (Input.GetKey(KeyCode.D))
        {
            force2D.x += forceValue; // 按下S鍵 往X軸右方加速前進
        }

        rigibody2D.AddForce(force2D); // 利用Rigidbody2D的AddForce功能，向某個軸向施力
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        scoremanager.AddScore(100); // 碰到金塊時就呼叫AddScore，引數為100，代表加100分
        other.gameObject.SetActive(false); // 當碰到isTrigger打勾的2D物件時 把那一個被碰到的物件關閉
    }
}
