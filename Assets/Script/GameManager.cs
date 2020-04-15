using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //スコアテキストを取得
    public Text scoreText;
    
    //スコア変数
    int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //スコアを追加するメソッド
    public void AddScore()
    {
        //スコアを加算する
        score++;

        //スコアテキストの表示を変更
        scoreText.text = "SCORE:" + score;

    }

}
