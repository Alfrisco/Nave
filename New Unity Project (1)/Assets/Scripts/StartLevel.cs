using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartLevel : MonoBehaviour
{
    public void LevelButton(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void LevelButton(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
    public void OnGUI()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (GUI.Button(new Rect(10, 70, 50, 30), "Click"))
        {
            if (scene.name == "Victory")
            {
                SceneManager.LoadScene("Start");
            }

            if (scene.name == "Start")
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
}
