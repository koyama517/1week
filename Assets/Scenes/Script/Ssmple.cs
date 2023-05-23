using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.UIElements;

public class Ssmple : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject boxPrefab;
    public GameObject GoalPrefab;
    public GameObject mapPrefab;

    private GameObject box1;
    private GameObject box2;
    private GameObject box3;
    private GameObject player;
    private GameObject goalBox;
    private GameObject map;

    // Start is called before the first frame update
    void Start()
    {
        map = Instantiate(mapPrefab);
        player = Instantiate(playerPrefab);
        box1 = Instantiate(boxPrefab, new Vector3(-5f, -5f, 0), Quaternion.identity);
        box2 = Instantiate(boxPrefab, new Vector3(0, -3f, 0), Quaternion.identity);
        box3 = Instantiate(boxPrefab, new Vector3(5f, -3f, 0), Quaternion.identity);
        goalBox = Instantiate(GoalPrefab, new Vector3(0, 5.12f, 0), Quaternion.identity);
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

        if (Input.GetKeyDown(KeyCode.R))
        {
            Reset();
        }

    }
    private void Reset()
    {
        Destroy(box1);
        Destroy(box2);
        Destroy(box3);
        Destroy(player);
        Destroy(goalBox);
        Destroy(map);

        Start();
        
    }
}
