using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puerta : MonoBehaviour
{
    public GameObject texto;
    public GameObject esfera;
    float tiempo;
    float counter;

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
        for (int i = 0; i < 7; i++)
        {
            Instantiate(esfera);
            esfera.transform.position = new Vector3(-2f, 49f, 5.41392f);
        }
        Debug.Log("Ganaste!");
        texto.SetActive(true);


    }
}
