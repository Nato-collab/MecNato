using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parabola : MonoBehaviour
{
    public Rigidbody mine;
    public GameObject laBola;

    public Text valores;
    public InputField velInit;
    public InputField angulo;
    public float velInicial;
    public float angle;
    float pi = 3.1416f;

    public float gravity = 9.81f;

    public float yMax;
    public float xMax;

    public float t;

    public float an;
    public float ang;

    public float xang;


    void CalculaValores()
    {

        angle = float.Parse(angulo.text);
        velInicial = float.Parse(velInit.text);

        ang = angle * Mathf.Deg2Rad;
        an = Mathf.Sin(ang);

        xang = Mathf.Cos(ang);


        t = velInicial * an / gravity;


        yMax = 0 + velInicial * an * t - 0.5f * gravity * Mathf.Pow(t, 2);
        xMax = 0 + velInicial * xang * t;

        Quaternion rot = Quaternion.Euler(-angle, 0, 0);

        mine.rotation = rot;


        valores.text = ("Altura maxima = " + yMax + "   Distancia recorrida en 1 segundo = " + xMax);
    }





    void Start()
    {
        valores.text = ("Altura maxima = 0"+ "   Distancia recorrida en 1 segundo = 0");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CalculaValores();
            Instantiate(laBola, transform.position, transform.rotation);


        }
    }
}
