using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text RedPlayerScoreText;
    public Text BluePlayerScoreText;
    
    static int redPlayerScore = 0;
    static int bluePlayerScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        RedPlayerScoreText.text = redPlayerScore.ToString();
        BluePlayerScoreText.text = bluePlayerScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        RedPlayerScoreText.text = redPlayerScore.ToString();
        BluePlayerScoreText.text = bluePlayerScore.ToString();
    }

    public static void incrementRedPlayerScore()
    {
        redPlayerScore++;
    }

    public static void incrementBluePlayerScore()
    {
        bluePlayerScore++;
    }
}
