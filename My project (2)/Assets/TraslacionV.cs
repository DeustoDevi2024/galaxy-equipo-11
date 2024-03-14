using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraslacionV : MonoBehaviour
{

    public GameObject planet;
    public GameObject sol;
    public float speedV = 0.05f;
    public float speed = 0.0002f;

    // Start is called before the first frame update
    void Start()
    {
        planet = GameObject.Find("Venus");
        sol = GameObject.Find("V");
        planet.transform.SetParent(sol.transform);
    }

    // Update is called once per frame
    void Update()
    {
        Rotacion();
        Rotar();
    }

    private void Rotar()
    {
        this.transform.rotation *= Quaternion.Euler(0, 1 * speed, 0);
    }


    private void Rotacion()
    {
        sol.transform.rotation *= Quaternion.Euler(0, 1 * speedV, 0);
    }
}
