using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Third : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject boxPrefab;
    public GameObject GoalPrefab;
    public GameObject mapPrefab;

    private GameObject box1;
    private GameObject box2;
    private GameObject player;
    private GameObject goalBox;
    private GameObject map;

    // Start is called before the first frame update
    void Start()
    {
        map = Instantiate(mapPrefab);
        goalBox = Instantiate(GoalPrefab, new Vector3(0, 0, 1), Quaternion.identity);
        player = Instantiate(playerPrefab, new Vector3(0, -5.12f, 0), Quaternion.identity);
        box1 = Instantiate(boxPrefab, new Vector3(-2.56f, 5.12f, 0), Quaternion.identity);
        box2 = Instantiate(boxPrefab, new Vector3(-5.12f, -3f, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reset();
        }

    }
    private void Reset()
    {
        Destroy(box1);
        Destroy(box2);
        Destroy(player);
        Destroy(goalBox);
        Destroy(map);

        Start();

    }
}
