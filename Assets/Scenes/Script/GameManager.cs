using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class GameManager : MonoBehaviour
{

    public bool canRotate;
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

    }
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
