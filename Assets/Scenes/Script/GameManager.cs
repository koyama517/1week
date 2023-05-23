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
        }
        else if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            nowScene = 2;
        }
        else if(SceneManager.GetActiveScene().name == "Third")
        {
            nowScene = 3;
        }

    }
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
