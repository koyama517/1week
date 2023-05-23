using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    private float playerSpeed;
    public BoxCollider2D col;
    public bool isDead;
    Rigidbody2D rigidbody2D;
    private Vector3 scale;

    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        scale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
            //移動
            Move();
        }
        RaycastHit2D hit;
        CheckGround checkGround = GetComponent<CheckGround>();
        Rotate rotate = GetComponent<Rotate>();
        if (checkGround.isGround && !rotate.isRotate)
        {
            //死亡処理
            hit = Hit();
            //生きてる
            if (!isDead)
            {
                if (hit.collider != null)
                {
                    if (hit.collider.tag == "Box")
                    {
                        if (rotate.isOdd)
                        {
                            scale.x -= 0.5f;
                        }
                        else
                        {
                            scale.y -= 0.5f;
                        }
                        //Debug.Log(scale.y);
                    }
                }
            }
            //サイズが0で死亡
            if (transform.localScale.y <= 0)
            {
                isDead = true;
            }
            else
            {
                isDead = false;
            }
        }

        if (scale.x <= 0 || scale.y <= 0)
        {
            scale = new Vector3(0, 0, 0);
        }
        transform.localScale = scale;
    }

    void Move()
    {
        playerSpeed = 0;
        ///
        ///Rotateのスクリプト入手
        Rotate rotate = GetComponent<Rotate>();
        CheckGround checkGround = GetComponent<CheckGround>();
        //回転中じゃ無い
        if (!rotate.isRotate)
        {
            //当たり判定
            col.enabled = true;
            //重力on
            rigidbody2D.gravityScale = 2;
            if (checkGround.isGround)
            {
                //左移動
                if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                {
                    playerSpeed = -speed;
                }
                //右移動
                if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                {
                    playerSpeed = speed;
                }

            }
            //if (rigidbody2D.velocity.y > 1) { }
            //移動
            rigidbody2D.velocity = new Vector2(playerSpeed, rigidbody2D.velocity.y);

        }
        //回転中
        else
        {
            //重力off
            rigidbody2D.gravityScale = 0;
            //動かさない
            rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);

        }
    }

    RaycastHit2D Hit()
    {
        Vector3 pos = new Vector3(transform.position.x, transform.position.y + transform.localScale.y / 2 + 0.05f, 0);
        RaycastHit2D resurt = Physics2D.Raycast(pos, new Vector2(0, 1), 0);
        return resurt;
    }
}
