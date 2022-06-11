using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject cubo;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(cubo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
