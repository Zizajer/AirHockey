using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class SceneManager : MonoBehaviour
{
    public Rigidbody2D RedPlayer;
    public Rigidbody2D BluePlayer;
    public Rigidbody2D Puck;
    public ScoreManager scoreManager;

    public GameObject EndGamePanel;

    Vector2 redPlayerStartPosition;
    Vector2 bluePlayerStartPosition;
    Vector2 puckStartPosition;

    // Start is called before the first frame update
    void Start()
    {
        redPlayerStartPosition = RedPlayer.position;
        bluePlayerStartPosition = BluePlayer.position;
        puckStartPosition = Puck.position;
    }
    private void Update()
    {
        if (ScoreManager.isAWinner)
        {
            EndGamePanel.active = true;
            Time.timeScale = 0;
        }
        else
        {
            EndGamePanel.active = false;
            Time.timeScale = 1;
        }
    }

    public IEnumerator ResetRound()
    {
        yield return new WaitForSecondsRealtime(1);
        RedPlayer.position = redPlayerStartPosition;
        RedPlayer.velocity = new Vector2(0, 0);
        BluePlayer.position = bluePlayerStartPosition;
        BluePlayer.velocity = new Vector2(0, 0);
        Puck.position = puckStartPosition;
        Puck.velocity = new Vector2(0, 0);
    }


}
