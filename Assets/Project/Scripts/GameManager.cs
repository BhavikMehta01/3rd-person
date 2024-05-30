using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] GameObject cameraControlWithTarget, cameraControlWithOutTarget;
    [SerializeField] GameObject DirectionalLight;
    public Transform player;

    void Awake()
    {
        if (instance == null) instance = this;
    }

    public void OnCameraControl(bool val)
    {
        cameraControlWithTarget.SetActive(!val);
        cameraControlWithOutTarget.SetActive(val);
        DirectionalLight.transform.parent = val ? cameraControlWithOutTarget.transform : cameraControlWithTarget.transform;
    }
}
