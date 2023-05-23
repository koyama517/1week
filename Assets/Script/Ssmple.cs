using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Ssmple : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject boxPrefab; 
    public GameObject GoalPrefab;
    public GameObject mapPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(playerPrefab);
        boxPrefab = Instantiate(boxPrefab, new Vector3(-5f, -5f,0),Quaternion.identity);
        boxPrefab = Instantiate(boxPrefab, new Vector3(0, -3f,0),Quaternion.identity);
        boxPrefab = Instantiate(boxPrefab, new Vector3(5f, -3f, 0), Quaternion.identity);
        GoalPrefab = Instantiate(GoalPrefab, new Vector3(0,5.12f,0), Quaternion.identity);
        mapPrefab = Instantiate(mapPrefab, new Vector3(0f, 0f, 0), Quaternion.identity);
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
//                Debug.Log(goal.isClear);

            }
        }

        if (Input.GetKey(KeyCode.R)) 
        { 
        
        }
    }
}
