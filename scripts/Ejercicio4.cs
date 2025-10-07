using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject cubo = GameObject.FindGameObjectWithTag("cubo");
        GameObject cilindro = GameObject.FindGameObjectWithTag("cilindro");

        Debug.Log("Distancia entre cubo y cilindro: " + Vector3.Distance(cubo.transform.position, cilindro.transform.position));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
