using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{

    public Rigidbody rig;

    public float g = 9.81f;

    private void Start()
    {
        StartCoroutine("DestroyThis");
    }

    void FixedUpdate()
    {
        rig.AddForce(Vector3.down * g);
    }

    IEnumerator DestroyThis()
    {
        yield return new WaitForSeconds(4f);
        Destroy(this.gameObject);
    }
}
