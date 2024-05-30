using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXLoad : MonoBehaviour
{
    [SerializeField] GameObject vfx;

    // Start is called before the first frame update
    void Start()
    {
        vfx.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        Mouse();
    }

    void Mouse()
    {
        if (Input.GetMouseButtonDown(0))
        {
            vfx.SetActive(true);
        }
    }
}
