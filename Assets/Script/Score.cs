using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    //スコア表示

    public Text scoreText;

    
    //ハイスコア表示
    //
    public Text highScoreText;//一位
    public Text highScoreaText;//二位
    public Text highScorebText;//三位
    public Text highScorecText;//四位
    public Text highScoredText;//五位

    //スコア
    public static int score;

    //ハイスコア
    public static int highScore;//1位
    public static int highScorea;//2位
    public static int highScoreb;//3位
    public static int highScorec;//4位
    public static int highScored;//5位

    private string highScoreKey = "HighScore";

   

    // Use this for initialization
    void Start()
    {
       Initialize();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))score= 10000;

      if (Input.GetKeyDown(KeyCode.Tab)) highScore = 500;
        if (Input.GetKeyDown(KeyCode.LeftShift)) highScorea = 400;
        if (Input.GetKeyDown(KeyCode.RightShift)) highScoreb = 200;
        if (Input.GetKeyDown(KeyCode.LeftAlt)) highScorec = 100;
        if (Input.GetKeyDown(KeyCode.RightAlt)) highScored = 50;

            //スコアがハイスコアより大きければ
            if (highScore < score)
        {
            highScore = score;
         
        }
      

        //スコア・ハイスコアを表示

        scoreText.text = score.ToString();

        highScoreText.text = highScore.ToString();//1位
        highScoreaText.text = highScorea.ToString();//2位
        highScorebText.text = highScoreb.ToString();//3位
        highScorecText.text = highScorec.ToString();//4位
        highScoredText.text = highScored.ToString();//5位
    }

    //ゲーム開始前に戻す

    private void Initialize()
    {
        //スコアを0に戻す
        score = 0;

        //ハイスコアを取得する。保存されてなければ0を取得する。
     //   highScore = PlayerPrefs.GetInt(highScoreKey, 0);

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


    //ランキング


}

