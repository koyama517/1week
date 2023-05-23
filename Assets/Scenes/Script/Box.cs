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

        Rotate rotate = GetComponent<Rotate>();
        if (!rotate.isRotate)
        {
            //ìñÇΩÇËîªíË
            //èdóÕon
            rigidbody2D.gravityScale = 5;
            rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
        }
        else
        {
            //èdóÕoff
            rigidbody2D.gravityScale = 0;
            //ìÆÇ©Ç≥Ç»Ç¢
            rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);

        }

        CheckBox checkBox = GetComponent<CheckBox>();
        if (checkBox.isGround)
        {
            col.enabled = true;
        }
        else { col.enabled = false; }

        //Debug.Log(checkBox.isGround);
    }
}
