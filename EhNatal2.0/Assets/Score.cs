using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    public Text highScore;
    public Text scoreText;
    Text text;
    private void Awake()
    {
        text = GetComponent<Text>();
        score = 0;
    }
    private void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    void Update ()
    {
        text.text = "Score:" + score;
	}
    void HighScore()
    {
        int HI = score;
        scoreText.text = HI.ToString();
        if (HI > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", HI);
            highScore.text = HI.ToString();
        }
        
    }
}
