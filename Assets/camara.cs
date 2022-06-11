using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    GameObject cubo;

    // Start is called before the first frame update
    void Start()
    {
        cubo = GameObject.Find("Cube(Clone)");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, cubo.transform.position.y, gameObject.transform.position.z);
    }
}
