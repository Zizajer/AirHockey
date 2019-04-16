using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public Rigidbody2D RedPlayer;
    public Rigidbody2D BluePlayer;
    public Rigidbody2D Puck;

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
