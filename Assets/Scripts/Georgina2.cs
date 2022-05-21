using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Georgina2 : MonoBehaviour
{
    public void Scene1()
    {
        SceneManager.LoadScene("GalleryView");

    }
    public void Scene2()
    {
        SceneManager.LoadScene("VistaGeorgina2");

    }
    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("VistaGeorgina2");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
