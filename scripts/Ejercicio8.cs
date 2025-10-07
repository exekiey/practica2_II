using UnityEngine;

public class Ejercicio8 : MonoBehaviour
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


        transform.Translate(moveDirection.normalized * speed * Time.deltaTime);
    }
}
