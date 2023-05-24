using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{

    public BoxCollider2D col;

    Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.gravityScale = 3;
    }

    // Update is called once per frame
    void Update()
    {

        CheckBox checkBox = GetComponent<CheckBox>();
        if (checkBox.isGround)
        {
            col.enabled = true;
        }
        else { col.enabled = false; }

        Rotate rotate = GetComponent<Rotate>();
        if (!rotate.isRotate)
        {
            //当たり判定
            //重力on

            rigidbody2D.gravityScale = 5;

            rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
        }
        else
        {
            //重力off
            rigidbody2D.gravityScale = 0;
            //動かさない
            rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);

        }

        //回転倉庫

        //Debug.Log(checkBox.isGround);
    }
}
