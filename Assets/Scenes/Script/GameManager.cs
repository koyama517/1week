using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool canRotate;
    public int nowScene;

    public GameObject lPrefab;
    public GameObject rPrefab;
    public GameObject aPrefab;
    public GameObject dPrefab;

    GameObject leftArrow;
    GameObject rightArrow;
    GameObject aButton;
    GameObject dButton;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        CheckGround checkGround;
        GameObject player = GameObject.Find("Player(Clone)");
        if (player != null)
        {
            checkGround = player.GetComponent<CheckGround>();
            if (checkGround != null)
            {
                if (checkGround.isGround)
                {
                    canRotate = true;
                }
                else
                {
                    canRotate = false;
                }
            }
        }
        if (SceneManager.GetActiveScene().name == "first")
        {
            nowScene = 1;

            if (leftArrow == null && rightArrow == null)
            {
                rightArrow = Instantiate(rPrefab, new Vector3(-12.0f, -4.5f, 0.0f), Quaternion.identity);
            }

            if(aButton == null && dButton == null) { 
                
                aButton = Instantiate(aPrefab, new Vector3(-15.0f,4.5f,0.0f), Quaternion.identity);
                dButton = Instantiate(dPrefab, new Vector3(-11.0f, 4.5f, 0.0f), Quaternion.identity);

            }

            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (leftArrow == null)
                {
                    Destroy(rightArrow);
                    leftArrow = Instantiate(lPrefab, new Vector3(-12.0f, -4.5f, 0.0f), Quaternion.identity);
                }
            }
            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (rightArrow == null)
                {
                    Destroy(leftArrow);
                    rightArrow = Instantiate(rPrefab, new Vector3(-12.0f, -4.5f, 0.0f), Quaternion.identity);
                }
              
            }
        }
        else if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            nowScene = 2;

            if (leftArrow == null && rightArrow == null)
            {
                rightArrow = Instantiate(rPrefab, new Vector3(-12.0f, -4.5f, 0.0f), Quaternion.identity);
            }
            if (aButton == null && dButton == null)
            {

                aButton = Instantiate(aPrefab, new Vector3(-15.0f, 4.5f, 0.0f), Quaternion.identity);
                dButton = Instantiate(dPrefab, new Vector3(-11.0f, 4.5f, 0.0f), Quaternion.identity);

            }
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (leftArrow == null)
                {
                    Destroy(rightArrow);
                    leftArrow = Instantiate(lPrefab, new Vector3(-12.0f, -4.5f, 0.0f), Quaternion.identity);
                }
            }
            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (rightArrow == null)
                {
                    Destroy(leftArrow);
                    rightArrow = Instantiate(rPrefab, new Vector3(-12.0f, -4.5f, 0.0f), Quaternion.identity);
                }
            }
        }
        else if(SceneManager.GetActiveScene().name == "Third")
        {
            nowScene = 3;

            if (leftArrow == null && rightArrow == null)
            {
                rightArrow = Instantiate(rPrefab, new Vector3(-12.0f, -4.5f, 0.0f), Quaternion.identity);
            }
            if (aButton == null && dButton == null)
            {

                aButton = Instantiate(aPrefab, new Vector3(-15.0f, 4.5f, 0.0f), Quaternion.identity);
                dButton = Instantiate(dPrefab, new Vector3(-11.0f, 4.5f, 0.0f), Quaternion.identity);

            }
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (leftArrow == null)
                {
                    Destroy(rightArrow);
                    leftArrow = Instantiate(lPrefab, new Vector3(-12.0f, -4.5f, 0.0f), Quaternion.identity);
                }
            }
            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (rightArrow == null)
                {
                    Destroy(leftArrow);
                    rightArrow = Instantiate(rPrefab, new Vector3(-12.0f, -4.5f, 0.0f), Quaternion.identity);
                }
            }
        }
    }
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
