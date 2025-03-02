using UnityEngine;

public class Escalera : MonoBehaviour
{
    public int escalones = 20;
    public float anchura = 5f;
    public float profundidad = 1f;
    public float alturaEscalon = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

        for (int i = 0; i < escalones; i++)
        {
            GameObject nuevoCubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
            nuevoCubo.transform.localScale = new Vector3(profundidad, alturaEscalon, anchura);
            nuevoCubo.transform.position = new Vector3(i*profundidad, i*alturaEscalon, 0);
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
