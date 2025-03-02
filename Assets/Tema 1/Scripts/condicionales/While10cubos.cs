using UnityEngine;

public class While10cubos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1;
        while (i <= 10)
        {
            Vector3 posicionNueva = new Vector3 (i * 1.2f , 0, 0);
            GameObject nuevoCubo = GameObject.CreatePrimitive (PrimitiveType.Cube);
            nuevoCubo.transform.position = posicionNueva;
            if(i%2 == 0)
            {
                nuevoCubo.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                nuevoCubo.GetComponent<Renderer>().material.color = Color.green;
            }
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
