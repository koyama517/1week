using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("TitleScene");
        }
        GameManager gameManager;
        GameObject manager = GameObject.Find("GameManager(Clone)");
        gameManager = manager.GetComponent<GameManager>();
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (gameManager.nowScene == 1)
            {
                SceneManager.LoadScene("first");
            }
            else if (gameManager.nowScene == 2)
            {
                SceneManager.LoadScene("SampleScene");
            }
            else if (gameManager.nowScene == 3)
            {
                SceneManager.LoadScene("Third");
            }
        }
    }
}