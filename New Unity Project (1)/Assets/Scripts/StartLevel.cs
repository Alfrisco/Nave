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
        if (GUI.Button(new Rect(10, 70, 50, 30), "Click"))
            SceneManager.LoadScene("SampleScene");
    }
}
