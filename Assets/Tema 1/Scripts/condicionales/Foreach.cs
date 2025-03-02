using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Foreach : MonoBehaviour
{
    public Vector3[] posicionesObjetivo =
    {
        new Vector3(0,0,0),
        new Vector3(1,1,0),
        new Vector3(2,0,2),
    };
    public float tiempoEntrePosiciones = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Mover());
    }

    IEnumerator Mover()
    {
        while (true) //bucle infinito para reiniciar la secuencia
        {
            foreach (Vector3 posicionObjetivo in posicionesObjetivo)
            {
                transform.position = posicionObjetivo;
                yield return new WaitForSeconds(tiempoEntrePosiciones);
            }
        }

    }
}
