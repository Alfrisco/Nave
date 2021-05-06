using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnColumna : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public GameObject enemigo;
    float posicionx;
    float posicionz;
    public int n;
    void Start()
    {
        StartCoroutine(Spawner());
        posicionx = Random.Range(-10, 10);
        posicionz = Random.Range(-10, 10);
        Instantiate(enemigo, new Vector3(posicionx, 4, posicionz), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Spawner()
    {
        for (float n = 0; n < 9; n++)
        {
            posicionx = Random.Range(-10, 10);
            posicionz = Random.Range(-10, 10);
            Instantiate(enemigo, new Vector3(posicionx, 4, posicionz), Quaternion.identity);
            yield return new WaitForSeconds(1);
        }

    }
}
