using UnityEngine;

public class Ejercicio9B : MonoBehaviour
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

        moveDirection = new Vector3(Input.GetAxis("Horizontal2"), Input.GetAxis("Vertical2"), 0);


        transform.Translate(moveDirection.normalized * speed);
    }
}
