using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [SerializeField] private float speed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //��Ҥ����
        /*
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 1, 0)*Time.deltaTime*speed);
            //transform.Translate(Vector3.up);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * speed);
            //transform.Translate(Vector3.down);
        }
        */
        //�����褧���
        float vertical = Input.GetAxis("Vertical");
        //Debug.Log(vertical);
        transform.Translate(0, vertical * Time.deltaTime * speed, 0);

    }
}
