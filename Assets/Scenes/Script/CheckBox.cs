using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBox : MonoBehaviour
{
    Rigidbody2D rb;
    private Vector2 direction;
    RaycastHit2D hit;
    public bool isGround;
    public BoxCollider2D col;

    private Vector3 min;
    private Vector3 max;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>();
        direction = new Vector2(0, -1);
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(hit.collider);
        //Debug.Log(rightHit.collider);
        //Debug.Log(leftHit.collider);
        hit = Hit();

        if (hit.collider != col)
        {
            if (hit.collider != null)
            {
                isGround = true;
            }
            else
            {
                isGround = false;
            }
        }
    }

    RaycastHit2D Hit()
    {
        Vector3 pos = new Vector3(transform.position.x, transform.position.y - transform.localScale.y / 2, 2);
        RaycastHit2D resurt = Physics2D.Raycast(pos, direction, 0);
        return resurt;
    }
}
