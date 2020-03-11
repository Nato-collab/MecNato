using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{

    public GameObject cursor;
    public Transform puntoDeDisparo;
    public Rigidbody rig;
    public LayerMask layer;
    public LineRenderer lineaVisual;
    public int segmentoDeLinea = 8;

    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        lineaVisual.positionCount = segmentoDeLinea;
    }

    // Update is called once per frame
    void Update()
    {
        LaunchProjectile();
    }

    void LaunchProjectile()
    {
        Ray camRay = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(camRay, out hit, 100f, layer))
        {
            cursor.SetActive(true);
            cursor.transform.position = hit.point + Vector3.up * 0.1f;

            Vector3 vo = CalculateVelocty(hit.point, puntoDeDisparo.position, 1f);

            Visualize(vo);

            transform.rotation = Quaternion.LookRotation(vo);

            if (Input.GetMouseButtonDown(0))
            {
                Rigidbody obj = Instantiate(rig, puntoDeDisparo.position, Quaternion.identity);
                obj.velocity = vo;
            }
        }
    }

    void Visualize(Vector3 vo)
    {
        for (int i = 0; i < segmentoDeLinea; i++)
        {
            Vector3 pos = CalculatePosInTime(vo, i / (float)segmentoDeLinea);
            lineaVisual.SetPosition(i, pos);
        }
    }

    Vector3 CalculateVelocty(Vector3 target, Vector3 origin, float time)
    {
        Vector3 distance = target - origin;
        Vector3 distanceXz = distance;
        distanceXz.y = 0f;

        float sY = distance.y;
        float sXz = distanceXz.magnitude;

        float Vxz = sXz * time;
        float Vy = (sY / time) + (0.5f * Mathf.Abs(Physics.gravity.y) * time);

        Vector3 result = distanceXz.normalized;
        result *= Vxz;
        result.y = Vy;

        return result;
    }

    Vector3 CalculatePosInTime(Vector3 vo, float time)
    {
        Vector3 Vxz = vo;
        Vxz.y = 0f;

        Vector3 result = puntoDeDisparo.position + vo * time;
        float sY = (-0.5f * Mathf.Abs(Physics.gravity.y) * (time * time)) + (vo.y * time) + puntoDeDisparo.position.y;

        result.y = sY;

        return result;
    }
}
