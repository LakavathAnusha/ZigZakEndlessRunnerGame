using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    //TileSpawnManager spawnManager;
    // Start is called before the first frame update
    void Start()
    {
        
        //spawnManager = GameObject.Find("TileSpawnManager").GetComponent<TileSpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
           //if Player moving forward then move him left
           if(direction==Vector3.forward)
            {
                direction = Vector3.left;
            }
            else
            {
                direction = Vector3.forward;
            }
        }
        transform.Translate(direction * Time.deltaTime * speed);
    }

    public void OnTriggerExit(Collider other)
    {

        // spawnManager.SpawnTile();
        if (other.gameObject.CompareTag("Player"))
        {
            TileSpawnManager.Instance.SpawnTile();
        }
        
    }
   
    private void OnCollisionEnter(Collision collision)
    {
        ScoreManager score;
        if (collision.gameObject.tag == "coin")
        {
            collision.gameObject.SetActive(false);
            score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
            score.ScoreCalculator(10);
        }
    }

}
