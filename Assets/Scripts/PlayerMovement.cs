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

    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        playerSize = gameObject.GetComponent<SpriteRenderer>().bounds.extents;
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (wasJustClicked)
            {
                wasJustClicked = false;

                if ((mousePos.x >= transform.position.x && mousePos.x < transform.position.x + playerSize.x ||
                mousePos.x <= transform.position.x && mousePos.x > transform.position.x - playerSize.x) &&
                (mousePos.y >= transform.position.y && mousePos.y < transform.position.y + playerSize.y ||
                mousePos.y <= transform.position.y && mousePos.y > transform.position.y - playerSize.y))
                {
                    canMove = true;
                }
                else
                {
                    canMove = false;
                }
            }

            if (canMove)
            {
                Vector2 clampedMousePos = new Vector2(Mathf.Clamp(mousePos.x, BoundaryPointLeft.position.x,
                                                                  BoundaryPointRight.position.x),
                                                      Mathf.Clamp(mousePos.y, BoundaryPointDown.position.y,
                                                                  BoundaryPointUp.position.y));

                rb.MovePosition(clampedMousePos);
            }
        }
        else
        {
            wasJustClicked = true;
        }
    }
}
