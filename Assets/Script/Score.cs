using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    //スコア表示

    public Text scoreText;

    //ハイスコア表示

    public Text highScoreText;


    //スコア
    private int score;

    //ハイスコア
    private int highScore;


    private string highScoreKey = "HighScore";

    // Use this for initialization
    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        //スコアがハイスコアより大きければ
        if (highScore < score)
        {
            highScore = score;
        }

        //スコア・ハイスコアを表示

        scoreText.text = score.ToString();

        highScoreText.text = highScore.ToString();


    }

    //ゲーム開始前に戻す

    private void Initialize()
    {
        //スコアを0に戻す
        score = 0;

        //ハイスコアを取得する。保存されてなければ0を取得する。
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);

    }

    //ハイスコア保存
    public void Save()
    {

        //ハイスコアを保存する
        PlayerPrefs.SetInt(highScoreKey, highScore);
        PlayerPrefs.Save();

        //ゲーム開始の状態を戻す
        Initialize();
    }

}

