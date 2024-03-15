using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCamara : MonoBehaviour
{
    public GameObject cube;
    public float speed = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("Camera");
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }

    private void Movimiento() {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {       
            cube.transform.position += Vector3.forward * speed;           
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            cube.transform.position += Vector3.back * speed;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            cube.transform.position += Vector3.left * speed;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            cube.transform.position += Vector3.right * speed;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            cube.transform.position += Vector3.up * speed;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            cube.transform.position += Vector3.down * speed;
        }
    }
}
