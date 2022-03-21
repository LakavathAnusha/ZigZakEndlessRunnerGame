using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawnManager : MonoBehaviour
{
    public GameObject currentTile;
    public GameObject[] tilesPrefab;
    // Start is called before the first frame update
    private static TileSpawnManager instance;

    public static TileSpawnManager Instance
    {
        get
        {

            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<TileSpawnManager>();
            }
            return instance;
        }
    }

 

    void Start()
    {

        // Instantiate(rightTile, currentTile.transform.GetChild(1).position, Quaternion.identity);
        // Instantiate(forwardTile, currentTile.transform.GetChild(0).position, Quaternion.identity);

        for (int i = 0; i < 10; i++)
        {

            SpawnTile();
        }

    }

    public void SpawnTile()
    {
        int index = Random.Range(0, 10);
        if(index==5)
        {
            currentTile.transform.GetChild(3).gameObject.SetActive(true);
        }
        int k = Random.Range(0, 2);
        currentTile = Instantiate(tilesPrefab[k], currentTile.transform.GetChild(k).position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
