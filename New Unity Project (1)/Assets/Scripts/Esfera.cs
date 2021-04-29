using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    Vector3 Jak;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Jak = transform.localPosition;
        Jak.y += Input.GetAxis("Jump") * Time.deltaTime * 12;
        Jak.x += Input.GetAxis("Horizontal") * Time.deltaTime * 12;
        Jak.z += Input.GetAxis("Vertical") * Time.deltaTime * 12;
        transform.localPosition = Jak;
    }
}
