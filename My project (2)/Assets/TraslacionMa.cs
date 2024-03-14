using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraslacionMa : MonoBehaviour
{

    public GameObject planet;
    public GameObject sol;
    public float speedMa = 0.02f;
    public float speed = 0.024f;

    // Start is called before the first frame update
    void Start()
    {
        planet = GameObject.Find("Marte");
        sol = GameObject.Find("Ma");
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
        sol.transform.rotation *= Quaternion.Euler(0, 1 * speedMa, 0);
    }
}
