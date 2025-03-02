using UnityEngine;

public class BucleEspiral : MonoBehaviour
{
    public float radio = 2.0f; //radio del espiral
    public int vueltas = 3; // cantidad de vueltas
    public int puntosPorVuelta = 100; // cantidad de puntos por vuelta
    int i = 0;
    public float indiceSubida = 0.1f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        do{

            float angulo = Mathf.PI * 2 * i / puntosPorVuelta;
            float x = radio * Mathf.Cos(angulo);
            float z = radio * Mathf.Sin(angulo);
            float y = i * indiceSubida;

            GameObject nuevoCubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
            nuevoCubo.transform.position = new Vector3(x, y, z);

            radio += 0.05f;
            i++;

        } while(i < vueltas *puntosPorVuelta);
    }
}
