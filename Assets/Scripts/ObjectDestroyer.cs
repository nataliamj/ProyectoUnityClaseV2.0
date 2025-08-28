using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar si el jugador tocó la caja
        if (collision.gameObject.CompareTag("Player"))
        {
            // Imprimir mensaje en consola
            Debug.Log("El jugador destruyó: " + gameObject.name);

            // Destruir la caja
            Destroy(gameObject);
        }
    }
}