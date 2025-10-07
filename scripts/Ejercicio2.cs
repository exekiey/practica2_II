using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{

    public Vector3 v0;
    public Vector3 v1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("v0: " + v0);
        Debug.Log("v1" + v1);

        Debug.Log("Ángulo: " + Vector3.Angle(v0, v1));
        Debug.Log("Distancia: " + Vector3.Distance(v0, v1));

        Debug.Log("El vector más alto es:");
        if (v0.y > v1.y)
        {
            Debug.Log(v0);
        } else
        {
            Debug.Log(v1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
