using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NivelCompletado : MonoBehaviour
{
    int n = 0;
    public GameObject columna;

    void Update()
    {
        n = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (n < 1)
        {
            SiguienteNivel();
        }
    }
    void SiguienteNivel()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "SampleScene")
        {
            SceneManager.LoadScene("Fase2");
        }

        if (scene.name == "Fase2")
        {
            SceneManager.LoadScene("Fase3");
        }

        if (scene.name == "Fase3")
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
