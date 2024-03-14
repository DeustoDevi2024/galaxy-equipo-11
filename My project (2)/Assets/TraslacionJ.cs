using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraslacionJ : MonoBehaviour
{

    public GameObject planet;
    public GameObject sol;
    public float speedJ = 0.003f;
    public float speed = 1.26f;

    // Start is called before the first frame update
    void Start()
    {
        planet = GameObject.Find("Jupiter");
        sol = GameObject.Find("J");
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
        sol.transform.rotation *= Quaternion.Euler(0, 1 * speedJ, 0);
    }
}
