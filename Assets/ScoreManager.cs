using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public Text scoreText;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ScoreCalculator(int value)
    {
        score = score + value;
        Debug.Log("Score" + score);
        scoreText.text = score.ToString();
    }
}
