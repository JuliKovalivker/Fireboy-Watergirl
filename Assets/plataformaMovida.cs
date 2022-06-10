using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformaMovida : MonoBehaviour
{
    bool derecha = true;
    Vector3 vector;
    public int posicion;
    public GameObject cubo;

    // Start is called before the first frame update
    void Start()
    {
        vector = new Vector3(transform.position.x, transform.position.y, transform.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        if (!derecha)
        {
            gameObject.transform.position += Vector3.right;
        }
        else
        {
            gameObject.transform.position += Vector3.left;
        }

        if(transform.position.x < vector.x - posicion)
        {
            derecha = false;
        }
        else if(transform.position.x > vector.x + posicion)
        {
            derecha = true;
        }
    }

    void OnCollisionStay()
    {
        cubo.transform.position = transform.position;
        cubo.transform.position += Vector3.up;
    }

}
