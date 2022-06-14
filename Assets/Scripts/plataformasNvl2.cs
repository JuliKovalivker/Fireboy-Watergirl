using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformasNvl2 : MonoBehaviour
{
    public float z;

    // Start is called before the first frame update
    void Start()
    {
        int randomY = Random.Range(-3, 3);
        int randomX = Random.Range(-3, 3);
        Debug.Log(randomY + randomX);
        gameObject.transform.position = new Vector3(randomX, randomY, z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


