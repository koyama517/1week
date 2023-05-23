using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Goal goal;
        GameObject goalObj = GameObject.Find("Goal(Clone)");
        if (goalObj != null)
        {
            //Debug.Log(goalObj);

            goal = goalObj.GetComponent<Goal>();
            if (goal != null)
            {
                if (goal.isClear)
                {
                    SceneManager.LoadScene("ClearScene");
                }
            }
        }
    }
}
