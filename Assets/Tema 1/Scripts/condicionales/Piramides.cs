using UnityEngine;

public class Piramides : MonoBehaviour
{
    public int niveles = 10;                    // Niveles de cada pir�mide individual
    public float separacion = 1.1f;             // Distancia entre cubos en una pir�mide
    public float separacionPiramides = 10f;     // Distancia entre pir�mides
    public int N = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int fila = 0; fila < N; fila++)
        {
            for (int columna = 0; columna < N; columna++)
            {
                Vector3 inicio = new Vector3(fila * (niveles * separacion + separacionPiramides), 0, columna * (niveles * separacion + separacionPiramides));

                for (int y = 0; y < niveles; y++)
                {
                    for (int x = 0; x < niveles - y; x++)
                    {
                        for (int z = 0; z < niveles - y; z++)
                        {
                            GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
                            cubo.transform.position = inicio + new Vector3(x * separacion, y, z * separacion);
                        }
                    }
                    // Calculamos la posici�n inicial para el nuevo nivel
                    inicio.x += separacion / 2;
                    inicio.z += separacion / 2;
                }
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
