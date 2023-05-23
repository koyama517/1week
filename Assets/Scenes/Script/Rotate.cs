using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject TargetObj_;
    private Vector3 RotateAxis = new Vector3(0.0f, 0.0f, 1.0f);
    public bool isRotate;
    public bool isLeft;

    public bool isOdd;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameManager gameManager;
        GameObject manager = GameObject.Find("GameManager(Clone)");
        gameManager = manager.GetComponent<GameManager>();

        if (gameManager != null)
        {
            if (gameManager.canRotate)
            {
                if (TargetObj_ == null) return;

                if (!isRotate)
                {
                    if (Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow)) { isLeft = false; }
                    if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow)) { isLeft = true; }

                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        isRotate = true;
                        if (isLeft)
                        {
                            StartCoroutine(RightRotate());
                        }
                        else
                        {
                            StartCoroutine(LeftRotate());
                        }

                        //“ü—Í‰ñ”‚ªŠï”‚©‹ô”‚©
                        if (isOdd) { isOdd = false; }
                        else { isOdd = true; }
                    }
                }
            }
        }
    }

    IEnumerator RightRotate()
    {
        for (int i = 0; i < 90; i++)
        {
            transform.RotateAround(TargetObj_.transform.position, RotateAxis, 1);
            yield return new WaitForSeconds(0.01f);
        }
        isRotate = false;

    }
    IEnumerator LeftRotate()
    {
        for (int i = 0; i < 90; i++)
        {
            transform.RotateAround(TargetObj_.transform.position, RotateAxis, -1);
            yield return new WaitForSeconds(0.01f);
        }
        isRotate = false;

    }
}
