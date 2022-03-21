using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
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
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="tile")
        {
            Destroy(collision.gameObject, 3.0f);
        }
    }
}