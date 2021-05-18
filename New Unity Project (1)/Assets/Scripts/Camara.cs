using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject Player;
    Vector3 _offset;

    void Start()
    {
        _offset = new Vector3(0, 4, -10); // or whatever you need
    }

    void FixedUpdate()
    {
        transform.position = Player.transform.position + _offset;
        transform.rotation = Player.transform.rotation;
    }
}
