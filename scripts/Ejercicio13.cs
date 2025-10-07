using UnityEngine;

public class Ejercicio13 : MonoBehaviour
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
        transform.Rotate(transform.up, Input.GetAxis("Horizontal"));

        moveDirection = transform.forward;

        transform.position += moveDirection.normalized * speed * Time.deltaTime;

        Debug.DrawLine(transform.position, transform.position + moveDirection);

    }
}
