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

    public float gravity = 9.8f;

    public float yMax;
    public float xMax;


    void CalculaValores()
    {

        angle = float.Parse(angulo.text);
        velInicial = float.Parse(velInit.text);


        yMax = 0 + velInicial * Mathf.Sin(angle) * 0.5f - 0.5f * 10 * 0.5f * 0.5f;
        xMax = 0 + velInicial * Mathf.Cos(angle) * 1;

        Quaternion rot = Quaternion.Euler(-angle, 0, 0);

        mine.rotation = rot;

        float xMaxi = 0 - xMax;
        float yMaxi = 0 - yMax;

        valores.text = ("Altura maxima = " + yMaxi + "   Distancia recorrida en 1 segundo = " + xMaxi);
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
