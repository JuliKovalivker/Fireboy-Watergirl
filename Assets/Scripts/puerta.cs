using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puerta : MonoBehaviour
{
    public GameObject texto;
    public GameObject esfera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter()
    {
        for(int i = 0; i < 7; i++)
        {
            Instantiate(esfera);
            esfera.transform.position = new Vector3(-3.7f, 39.9f, 8.3f);
        }
        Debug.Log("Ganaste!");
        texto.SetActive(true);

    }
}
