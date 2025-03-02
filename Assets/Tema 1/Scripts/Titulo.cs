using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Titulo : MonoBehaviour
{
    public float velocidad = 5f;
    public GameObject cubo1;
    public GameObject cubo2;
    public GameObject cubo3;


    public Text textoUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textoUI.text = "Transformaciones";
    }

    void Update()
    {
        //rotamos los cubos 1 y 2
        cubo1.transform.Rotate(0, velocidad * Time.deltaTime, 0);
        cubo2.transform.Rotate(0, velocidad * Time.deltaTime, 0);

    }

    void FixedUpdate()
    {
        //rotamos cubo3
        cubo3.transform.Rotate(0, velocidad * Time.deltaTime, 0);
    }

}
