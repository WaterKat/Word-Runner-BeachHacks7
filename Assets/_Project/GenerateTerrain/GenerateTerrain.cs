using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTerrain : MonoBehaviour
{
    public Transform player;
    public int latestPos;
    public float generateDistance = 5;

    public List<GameObject> terrains;

    public Dictionary<int, float> randomPos = new Dictionary<int, float>();

    // Start is called before the first frame update
    void Start()
    {
        latestPos = -3;
    }

    // Update is called once per frame
    void Update()
    {
        int charPos = Mathf.FloorToInt(player.position.x / generateDistance) + 15;
        while (charPos > latestPos)
        {
            Generate();
            latestPos += 1;
        }
    }

    public float GetRandomHeight(int _input)
    {
        
        if (!randomPos.ContainsKey(_input))
        {
            randomPos.Add(_input, Random.Range(-0.1f, 0.1f));
        }
       // Debug.Log(_input + " " + randomPos[_input]);
        return randomPos[_input];
        
    }

    void Generate()
    {
        int seed = latestPos;
        GameObject randomGO = Instantiate(terrains[Random.Range(0, terrains.Count)]);
        randomGO.transform.position = new Vector3((latestPos + 1) * generateDistance, GetRandomHeight(seed), 0);
        Destroy(randomGO, 15);
    }
}
