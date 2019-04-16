using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    bool wasJustClicked = true;
    bool canMove;
    Vector2 playerSize;

    public Transform BoundaryPointUp;
    public Transform BoundaryPointDown;
    public Transform BoundaryPointLeft;
    public Transform BoundaryPointRight;

    public Collider2D PlayerCollider { get; private set; }

    public PlayerController Controller;

    public int? LockedFingerID { get; set; }

    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        playerSize = gameObject.GetComponent<SpriteRenderer>().bounds.extents;
        rb = gameObject.GetComponent<Rigidbody2D>();
        PlayerCollider = GetComponent<Collider2D>();
    }

    private void OnEnable()
    {
        Controller.Players.Add(this);
    }

    private void OnDisable()
    {
        Controller.Players.Remove(this);
    }

    public void MoveToPosition(Vector2 position)
    {
        Vector2 clampedMousePos = new Vector2(Mathf.Clamp(position.x, BoundaryPointLeft.position.x,
                                                                  BoundaryPointRight.position.x),
                                                      Mathf.Clamp(position.y, BoundaryPointDown.position.y,
                                                                  BoundaryPointUp.position.y));

        rb.MovePosition(clampedMousePos);
    }
}
