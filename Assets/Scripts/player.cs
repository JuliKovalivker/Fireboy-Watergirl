using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    
    public int jumpForce = 5;
    public bool hasJump;
    Rigidbody RB;
    public GameObject moneda;
    public GameObject plataforma;
    public GameObject moneda2;
    public GameObject plataforma2;
    public GameObject moneda3;
    public GameObject plataforma3;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        int random = Random.Range(1, 33);
        plataforma = GameObject.Find("Cube (" + random + ")");
        Debug.Log(random);
        GameObject clon;
        clon = Instantiate(moneda);
        clon.transform.position = new Vector3(plataforma.transform.position.x, plataforma.transform.position.y + 1, plataforma.transform.position.z);

        int random2 = Random.Range(1, 33);
        plataforma2 = GameObject.Find("Cube (" + random2 + ")");
        Debug.Log(random2);
        GameObject clon2;
        clon2 = Instantiate(moneda2);
        clon2.transform.position = new Vector3(plataforma2.transform.position.x, plataforma2.transform.position.y + 1, plataforma2.transform.position.z);

        int random3 = Random.Range(1, 33);
        plataforma3 = GameObject.Find("Cube (" + random3 + ")");
        Debug.Log(random);
        GameObject clon3;
        clon3 = Instantiate(moneda3);
        clon3.transform.position = new Vector3(plataforma3.transform.position.x, plataforma3.transform.position.y + 1, plataforma3.transform.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && hasJump)
        {
            RB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            hasJump = false;
        }
        else if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position += new Vector3(-0.1f, 0, 0);
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.position += new Vector3(0, 0, -0.1f);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += new Vector3(0.1f, 0, 0);
        }
        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.position += new Vector3(0, 0, 0.1f);
        }
        
    }

    void OnCollisionEnter(Collision col)
    {
        hasJump = true;
        if(col.gameObject.tag == "Moneda")
        {
            Destroy(col.gameObject);
        }
    }
}
 