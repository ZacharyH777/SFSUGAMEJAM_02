using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventCameraGrab : MonoBehaviour
{
    private Canvas canvas;

    void Awake()
    {
        canvas = this.GetComponent<Canvas>();
    }
    void Start()
    {
        canvas.worldCamera = Camera.main;
    }
}
