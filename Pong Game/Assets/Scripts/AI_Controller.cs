using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Controller : MonoBehaviour
{
    [SerializeField] private float speed = 7.5f;
    [SerializeField] private GameObject Target_Ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 0) { 
            if(transform.position.y > Target_Ball.transform.position.y)
            {
                transform.Translate(Vector3.down*Time.deltaTime*speed);
            }

            if (transform.position.y < Target_Ball.transform.position.y)
            {
                transform.Translate(Vector3.up * Time.deltaTime * speed);
            }
        }
    }
}
