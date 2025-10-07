using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{

    [SerializeField] Vector3 velocidad;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Izquierda " + Input.GetAxis("Horizontal") * velocidad);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Derecha" + Input.GetAxis("Horizontal") * velocidad);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Arriba " + Input.GetAxis("Vertical") * velocidad);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Abajo " + Input.GetAxis("Vertical") * velocidad);
        }
    }
}
