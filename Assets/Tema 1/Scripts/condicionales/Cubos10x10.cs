using UnityEngine;

public class Cubos10x10 : MonoBehaviour
{
    public float distanciaEntreCubos = 1.3f;
    public int cantidadCubos = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < cantidadCubos; i++)
        {
            
            for (int j = 0; j < cantidadCubos; j++)
            {
                GameObject nuevoCubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
                nuevoCubo.transform.position = new Vector3(i * distanciaEntreCubos, 1, j * distanciaEntreCubos);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
