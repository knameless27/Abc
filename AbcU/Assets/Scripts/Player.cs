using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float velocidad = 10f;

    private Vector3 posicionObjetivo;

    private void Start()
    {
        posicionObjetivo = this.transform.position;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            posicionObjetivo = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            posicionObjetivo.z = this.transform.position.z;
        }
        this.transform.position = Vector3.MoveTowards(this.transform.position, posicionObjetivo, velocidad * Time.deltaTime);
    }
}
