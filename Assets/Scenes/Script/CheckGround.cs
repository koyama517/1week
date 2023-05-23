using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.Image;

public class CheckGround : MonoBehaviour
{
    Rigidbody2D rb;
    private Vector2 direction;
    RaycastHit2D hit;
    RaycastHit2D leftHit;
    RaycastHit2D rightHit;
    public bool isGround;
    private bool isHit;
    public BoxCollider2D col;

    private Vector3 min;
    private Vector3 max;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>();
        direction = new Vector2(0, -1);
        max = new Vector3(transform.position.x + transform.localScale.x,
                0, 0);
    }

    // Update is called once per frame
    void Update()
    {
       
        //Debug.Log(hit.collider);
        //Debug.Log(rightHit.collider);
        //Debug.Log(leftHit.collider);
        hit = Hit();
        leftHit = LeftHit();
        rightHit = RightHit();

        if (hit.collider != col || leftHit.collider != col || rightHit.collider != col)
        {
            if (hit.collider != null || leftHit.collider != null || rightHit.collider != null)
            {
                isHit = true;
            }
            else
            {
                isHit = false;
            }
        }

        if (isHit)
        {
            isGround = true;
        }
        else
        {
            isGround = false;
        }
    }

    RaycastHit2D Hit()
    {
        Vector3 pos = new Vector3(transform.position.x, transform.position.y - transform.localScale.y / 2 - 0.05f, 0);
        RaycastHit2D resurt = Physics2D.Raycast(pos, direction, 0 );
        return resurt;
    }
    RaycastHit2D LeftHit()
    {
        Vector3 pos = new Vector3(transform.position.x - transform.localScale.x / 2, 
            transform.position.y - transform.localScale.y / 2 - 0.05f, 0);
        RaycastHit2D resurt = Physics2D.Raycast(pos, direction, 0);
        return resurt;
    }
    RaycastHit2D RightHit()
    {
        Vector3 pos = new Vector3(transform.position.x + transform.localScale.x / 2, 
            transform.position.y - transform.localScale.y / 2 - 0.05f, 0);
        RaycastHit2D resurt = Physics2D.Raycast(pos, direction, 0);
        return resurt;
    }
}
