using UnityEngine;

public class for10cubos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 posicionNueva = new Vector3(i * 1.2f, 0, 0);
            GameObject nuevoCubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
            nuevoCubo.transform.position = posicionNueva;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
