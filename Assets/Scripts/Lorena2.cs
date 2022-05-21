using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lorena2 : MonoBehaviour
{
    public void Scene1()
    {
        SceneManager.LoadScene("GalleryView");
        
    }
    public void Scene2()
    {
        SceneManager.LoadScene("VistaLorena2");

    }
    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("VistaLorena2");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
