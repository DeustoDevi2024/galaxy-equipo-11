using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraslacionU : MonoBehaviour
{

    public GameObject planet;
    public GameObject sol;
    public float speedU = 0.001f;
    public float speed = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
        planet = GameObject.Find("Urano");
        sol = GameObject.Find("U");
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
        sol.transform.rotation *= Quaternion.Euler(0, 1 * speedU, 0);
    }
}
