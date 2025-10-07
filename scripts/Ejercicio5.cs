using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{

    [SerializeField] Vector3 v0;
    [SerializeField] Vector3 v1;
    [SerializeField] Vector3 v2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {

            GameObject esfera = GameObject.FindGameObjectWithTag("esfera");
            GameObject cubo = GameObject.FindGameObjectWithTag("cubo");
            GameObject cilindro = GameObject.FindGameObjectWithTag("cilindro");

            esfera.transform.Translate(v0);
            cubo.transform.Translate(v1);
            cilindro.transform.Translate(v2);

        }
    }
}
