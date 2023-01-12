using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void LoadSavesScene()
    {
        SceneManager.LoadScene("SavesScene");
    }

    public void LoadOptionsMenu()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void LoadNewProfilesScene()
    {
        SceneManager.LoadScene("NewProfileCreationScene");
    }

    public void LoadFidgetScene()
    {
        SceneManager.LoadScene("FidgetSetUpScene");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
