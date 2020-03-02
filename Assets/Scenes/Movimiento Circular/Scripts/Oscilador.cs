using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Oscilador : MonoBehaviour
{
    float timeCounter = 0;
    public float radious;
    public float speed;

    public Text mc;


    void Start()
    {
        
    }

    void Update()
    {
        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Cos(timeCounter) * radious * 2/10;
        float y = Mathf.Sin(timeCounter) * radious * 2/10;

        mc.text = "Aceleracion circular = " + speed * speed / radious;

        transform.position = new Vector3(x, y, 0);
    }
}
