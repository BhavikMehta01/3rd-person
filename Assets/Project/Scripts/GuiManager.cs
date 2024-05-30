using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GuiManager : MonoBehaviour
{
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * 2);
    }

    /// <summary>
    /// Menu Scene Code
    /// </summary>
    /// <param name="isOn"></param>
    public void ClickOnPlayBtn()
    {
        SceneManager.LoadScene(1);
    }


    /// <summary>
    /// Gameplay Scene Code
    /// </summary>
    /// <param name="isOn"></param>
    public void ClickOnCameraSwitch(Toggle isOn)
    {
        GameManager.instance.OnCameraControl(isOn.isOn);
    }

    public void ClickOnHomeBtn()
    {
        SceneManager.LoadScene(0);
    }
}
