using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 startPos = new Vector3(0, 100, 0);

    public float speed = 20f;

    private float limX = 200f;
    private float limY = 200f;
    private float limZ = 200f;
    private float suelo = 0f;



    // Start is called before the first frame update
    void Start()
    {

        transform.position = startPos;

        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (transform.position.x <= -limX)

        {
            transform.position = new Vector3(-limX, transform.position.y, transform.position.z);
        }
        if (transform.position.x >= limX)

        {
            transform.position = new Vector3(limX, transform.position.y, transform.position.z);
        }

        if (transform.position.y <= suelo)

        {
            transform.position = new Vector3(transform.position.x, suelo, transform.position.z);
        }
        if (transform.position.y >= limY)

        {
            transform.position = new Vector3(transform.position.x, limY, transform.position.z);
        }

        if (transform.position.z <= -limZ)

        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -limZ);
        }

        if (transform.position.z >= limZ)

        {
            transform.position = new Vector3(transform.position.x, transform.position.y, limZ);
        }

        RotateGameObject(KeyCode.W, new Vector3(-10, 0, 0));
        RotateGameObject(KeyCode.A, new Vector3(0, -10, 0));
        RotateGameObject(KeyCode.S, new Vector3(10, 0, 0));
        RotateGameObject(KeyCode.D, new Vector3(0, 10, 0));


    }

    public void RotateGameObject(KeyCode kcode, Vector3 rotation)
    {
        if (Input.GetKeyDown(kcode))
        {
            transform.rotation *= Quaternion.Euler(rotation);
        }

    }


}


