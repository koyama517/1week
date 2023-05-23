using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Player player;
        GameObject pObj = GameObject.Find("Player(Clone)");
        if (pObj != null)
        {
            //Debug.Log(goalObj);

            player = pObj.GetComponent<Player>();
            if (player != null)
            {
                if (player.isDead)
                {
                    SceneManager.LoadScene("OverScene");
                }
            }
        }
    }
}
