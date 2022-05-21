using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void Scene1()
    {
        SceneManager.LoadScene("GalleryView");
        
    }
    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("VistaInfo");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

   
}