using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bola : MonoBehaviour
{
    public Rigidbody rig;

    public InputField velInit;

    public float g = 9.81f;

    public float velInicial;

    void Start()
    {
        velInit = FindObjectOfType<InputField>();

        velInicial = float.Parse(velInit.text);

        StartCoroutine("DestroyThis");
        rig.AddForce(transform.forward * velInicial * 50f);
    }


    void FixedUpdate()
    {
        rig.AddForce(Vector3.down * g);
    }

    IEnumerator DestroyThis()
    {
        yield return new WaitForSeconds(5f);
        Destroy(this.gameObject);
    }
}
