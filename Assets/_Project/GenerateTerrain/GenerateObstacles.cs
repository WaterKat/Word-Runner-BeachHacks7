using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacles : MonoBehaviour
{
    public Transform player;
    public int latestPos;
    public float generateDistance = 5;

    public List<GameObject> obstacles;
    public GenerateTerrain terrainScript;

    // Start is called before the first frame update
    void Start()
    {
        latestPos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        int charPos = Mathf.FloorToInt(player.position.x/generateDistance) + 15;
        while (charPos > latestPos )
        {
            Generate();
            latestPos += 1;
        }
    }


    
    void Generate()
    {
        int seed = latestPos;
        if (Random.Range(0,3)>0)
            return;
        GameObject randomGO = Instantiate(obstacles[Random.Range(0,obstacles.Count)]);
        randomGO.transform.position = new Vector3((latestPos+1)*generateDistance, terrainScript.GetRandomHeight(seed)+1f, 0);
        Destroy(randomGO, 30);
    }
}
