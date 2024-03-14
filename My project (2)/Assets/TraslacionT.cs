using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraslacionT : MonoBehaviour
{

    public GameObject planet;
    public GameObject sol;
    public float speedT = 0.03f;
    public float speed = 0.0465f;

    // Start is called before the first frame update
    void Start()
    {
        planet = GameObject.Find("Tierra");
        sol = GameObject.Find("T");
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
        sol.transform.rotation *= Quaternion.Euler(0, 1 * speedT, 0);
    }
}
