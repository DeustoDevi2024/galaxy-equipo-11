using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraslacionS : MonoBehaviour
{

    public GameObject planet;
    public GameObject sol;
    public float speedS = 0.002f;
    public float speed = 1.03f;

    // Start is called before the first frame update
    void Start()
    {
        planet = GameObject.Find("Saturno");
        sol = GameObject.Find("S");
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
        sol.transform.rotation *= Quaternion.Euler(0, 1 * speedS, 0);
    }
}
