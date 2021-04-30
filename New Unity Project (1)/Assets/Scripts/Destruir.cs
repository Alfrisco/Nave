using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    public GameObject Esfera;
    private Esfera nave;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("objeto1 ha colisionado con objeto2");
        GameObject objeto1 = GameObject.Find("Columna");
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("objeto1 ha colisionado con objeto3");
            Destroy(gameObject);
        }

    }
}
