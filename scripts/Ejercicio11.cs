using UnityEngine;

public class Ejercicio11 : MonoBehaviour
{


    [SerializeField] Vector3 moveDirection;
    [SerializeField] float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 spherePos = GameObject.FindGameObjectWithTag("esfera").transform.position;

        Vector3 sphereDirection = spherePos - transform.position;
        moveDirection = sphereDirection;

        transform.Translate(moveDirection.normalized * speed * Time.deltaTime);
    }
}
