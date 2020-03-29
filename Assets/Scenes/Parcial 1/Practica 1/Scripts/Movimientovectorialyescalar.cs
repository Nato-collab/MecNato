using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movimientovectorialyescalar : MonoBehaviour
{

    public Text escalar;

    public Text vectorial;

    public float velocidadCubo;

    public float rotacionCubo;

    public Transform[] posiciones;

    public float metrosX;

    public float metrosZ;

    float totalMetros;

    bool norte;
    bool sur;
    bool este;
    bool oeste;

    void Start()
    {
        posiciones[0].position = transform.position;
        escalar.text = ("Te moviste 0 metros");
        vectorial.text = ("Te moviste 0 metros");
    }

    void Update()
    {

        //ME DISCULPO POR USAR CODIGO DE FUERZA BRUTA

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * velocidadCubo * Time.deltaTime, Space.Self);

            if (posiciones[0].position.x < transform.position.x)
            {
                metrosX = transform.position.x - posiciones[0].position.x;
            }
            else if (posiciones[0].position.x > transform.position.x)
            {
                metrosX = posiciones[0].position.x - transform.position.x;
            }
            else
            {

            }

            if (posiciones[0].position.z < transform.position.z)
            {
                metrosZ = transform.position.z - posiciones[0].position.z;
            }
            else if (posiciones[0].position.z > transform.position.z)
            {
                metrosZ = posiciones[0].position.z - transform.position.z;
            }
            else
            {

            }

            totalMetros = metrosX + metrosZ;

            escalar.text = ("Te moviste " + totalMetros + " metros");
            if (posiciones[0].position.x < transform.position.x)
            {
                if (posiciones[0].position.z < transform.position.z)
                {
                    vectorial.text = ("Te moviste " + totalMetros + " metros al noreste");
                }
                else if (posiciones[0].position.z > transform.position.z)
                {
                    vectorial.text = ("Te moviste " + totalMetros + " metros al noroeste");
                }
                else
                {
                    vectorial.text = ("Te moviste " + totalMetros + " metros al norte");
                }
            }
            else
            {
                if (posiciones[0].position.z < transform.position.z)
                {
                    vectorial.text = ("Te moviste " + totalMetros + " metros al sureste");
                }
                else if (posiciones[0].position.z > transform.position.z)
                {
                    vectorial.text = ("Te moviste " + totalMetros + " metros al suroeste");
                }
                else
                {
                    vectorial.text = ("Te moviste " + totalMetros + " metros al sur");
                }
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
           
            transform.Translate(-Vector3.forward * velocidadCubo * Time.deltaTime, Space.Self);
            if (posiciones[0].position.x < transform.position.x)
            {
                metrosX = transform.position.x - posiciones[0].position.x;
            }
            else if (posiciones[0].position.x > transform.position.x)
            {
                metrosX = posiciones[0].position.x - transform.position.x;
            }
            else
            {

            }

            if (posiciones[0].position.z < transform.position.z)
            {
                metrosZ = transform.position.z - posiciones[0].position.z;
            }
            else if (posiciones[0].position.z > transform.position.z)
            {
                metrosZ = posiciones[0].position.z - transform.position.z;
            }
            else
            {

            }

            totalMetros = metrosX + metrosZ;

            escalar.text = ("Te moviste " + totalMetros + " metros");

            if (posiciones[0].position.x < transform.position.x)
            {
                if (posiciones[0].position.z < transform.position.z)
                {
                    vectorial.text = ("Te moviste " + totalMetros + " metros al noreste");
                }
                else if (posiciones[0].position.z > transform.position.z)
                {
                    vectorial.text = ("Te moviste " + totalMetros + " metros al noroeste");
                }
                else
                {
                    vectorial.text = ("Te moviste " + totalMetros + " metros al norte");
                }
            }
            else
            {
                if (posiciones[0].position.z < transform.position.z)
                {
                    vectorial.text = ("Te moviste " + totalMetros + " metros al sureste");
                }
                else if (posiciones[0].position.z > transform.position.z)
                {
                    vectorial.text = ("Te moviste " + totalMetros + " metros al suroeste");
                }
                else
                {
                    vectorial.text = ("Te moviste " + totalMetros + " metros al sur");
                }
            }

            
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, rotacionCubo * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -rotacionCubo * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            posiciones[0].position = transform.position;
            escalar.text = ("Te moviste 0 metros");
            vectorial.text = ("Te moviste 0 metros");
        }
    }

}
