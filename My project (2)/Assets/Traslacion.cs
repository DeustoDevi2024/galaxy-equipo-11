using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traslacion : MonoBehaviour
{

    public GameObject planet;
    public GameObject sol;
    public float speedM = 0.1f;
    public float speed = 0.0003f;

    // Start is called before the first frame update
    void Start()
    {
        planet = GameObject.Find("Mercurio");
        sol = GameObject.Find("M");
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
        sol.transform.rotation *= Quaternion.Euler(0, 1 * speedM, 0);
    }
}
