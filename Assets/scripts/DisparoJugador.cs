using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoJugador : MonoBehaviour
{
    [SerializeField] GameObject bolitadefuego;
    [SerializeField] Transform firePoint;

    bool mirandoDerecha = true;

    void Update()
    {
        float movimiento = Input.GetAxisRaw("Horizontal");

        if (movimiento > 0)
            mirandoDerecha = true;
        else if (movimiento < 0)
            mirandoDerecha = false;

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("¡Disparo activado!");

            GameObject nuevaBolita = Instantiate(bolitadefuego, firePoint.position, Quaternion.identity);

            nuevaBolita.GetComponent<movimientoDisparo>().SetDireccion(mirandoDerecha ? 1 : -1);

            Debug.Log("Bolita de fuego instanciada en: " + nuevaBolita.transform.position);
        }
    }
}