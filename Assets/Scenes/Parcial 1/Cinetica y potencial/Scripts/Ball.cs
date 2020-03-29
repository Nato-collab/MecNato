using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public float thrust = 10.0f;
    float k;
    float x = 10;
    float ep;
    float ec;
    float m = 3;
    float v;
    float rotY, rotX;
    Quaternion rota;
    public Rigidbody rig;
    public Text valores;

    void EnergiaPotElastica()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rotY++;
            rota = Quaternion.Euler(-rotY, 0, 0);
            rig.rotation = rota;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotX++;
            rota = Quaternion.Euler(0, -rotX, 0);
            rig.rotation = rota;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotX++;
            rota = Quaternion.Euler(0, rotX, 0);
            rig.rotation = rota;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rotY++;
            rota = Quaternion.Euler(rotY, 0, 0);
            rig.rotation = rota;
        }
        if (Input.GetKey(KeyCode.K))
        {
            k += 1;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            k = 0;
            ep = 0;
            ec = 0;
            v = 0;
            rotY = 0;
            rotX = 0;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rig.AddForce(transform.forward * v * thrust);


        }

        ep = x * x * k;
        ec = ep;
        v = ec * 2 / m;

        valores.text = ("Ep = " + ep + "J" + " Ec = " + ec + "J" + "   x = " + x + "m" + "   v = " + v + "m/s" + "   k = " + k + "N/m" + "   m = " + m + "kg");

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnergiaPotElastica();
    }
}
