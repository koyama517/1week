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
            //�ړ�
            Move();
        }
        RaycastHit2D hit;
        CheckGround checkGround = GetComponent<CheckGround>();
        Rotate rotate = GetComponent<Rotate>();
        if (checkGround.isGround && !rotate.isRotate)
        {
            //���S����
            hit = Hit();
            //�����Ă�
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
            //�T�C�Y��0�Ŏ��S
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
        ///Rotate�̃X�N���v�g����
        Rotate rotate = GetComponent<Rotate>();
        CheckGround checkGround = GetComponent<CheckGround>();
        //��]�����ᖳ��
        if (!rotate.isRotate)
        {
            //�����蔻��
            col.enabled = true;
            //�d��on
            rigidbody2D.gravityScale = 2;
            if (checkGround.isGround)
            {
                //���ړ�
                if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                {
                    playerSpeed = -speed;
                }
                //�E�ړ�
                if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                {
                    playerSpeed = speed;
                }

            }
            //if (rigidbody2D.velocity.y > 1) { }
            //�ړ�
            rigidbody2D.velocity = new Vector2(playerSpeed, rigidbody2D.velocity.y);

        }
        //��]��
        else
        {
            //�d��off
            rigidbody2D.gravityScale = 0;
            //�������Ȃ�
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
