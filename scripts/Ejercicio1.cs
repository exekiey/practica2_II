using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{

    Vector3 color;
    int counter = 0;
    [SerializeField] int counterLimit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        color = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (counter < counterLimit)
        {
            counter++;

  
        } else
        {
            counter = 0;
            int randomPos = Random.Range(0, 3);

            float randomNum = Random.Range(0f, 1f);

            switch (randomPos)
            {
                case 0:
                    color.x = randomNum;
                    break;
                case 1:
                    color.y = randomNum;
                    break;
                case 2:
                    color.z = randomNum;
                    break;
            }

            gameObject.GetComponent<Renderer>().material.color = new Color(color.x, color.y, color.z);
        }
    }
}
