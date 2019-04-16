using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFunctionsScript : MonoBehaviour
{
    public void RestartGame()
    {
        ScoreManager.resetScores();
    }
}
