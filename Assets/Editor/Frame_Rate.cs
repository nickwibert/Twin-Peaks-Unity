using System.Collections;
using System.Collections.Generic;
using System.Runtime.Hosting;
using UnityEngine;

public class Frame_Rate : MonoBehaviour
{
    public int FPS;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = FPS;
    }

    void Update()
    {
        Application.targetFrameRate = FPS;
    }
}
