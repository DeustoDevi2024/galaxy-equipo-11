using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraslacionN : MonoBehaviour
{

    public GameObject planet;
    public GameObject sol;
    public float speedN = 0.001f;
    public float speed = 0.54f;

    // Start is called before the first frame update
    void Start()
    {
        planet = GameObject.Find("Neptuno");
        sol = GameObject.Find("N");
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
        sol.transform.rotation *= Quaternion.Euler(0, 1 * speedN, 0);
    }
}