using UnityEngine;

public class SeguimientoyEvasion : MonoBehaviour
{
    public Transform objetivo;
    public float velocidad = 2f, distanciaSeguimiento = 5f, distanciaEvasion = 2f;

    

    // Update is called once per frame
    void Update()
    {
        float distanciaObjetivo = Vector3.Distance(transform.position, objetivo.position);
        
        //condicional para seguir o evitar al objetivo
        if(distanciaObjetivo < distanciaEvasion)
        {
            //evitar al objetivo
            Vector3 direccion = (transform.position - objetivo.position).normalized;
            transform.position += direccion * velocidad * Time.deltaTime;
            GetComponent<Renderer>().material.color = Color.blue;
        }
        else if(distanciaObjetivo < distanciaSeguimiento)
        {
            //seguir al objetivo
            Vector3 direccion = (objetivo.position - transform.position).normalized;
            transform.position += direccion * velocidad * Time.deltaTime;
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
