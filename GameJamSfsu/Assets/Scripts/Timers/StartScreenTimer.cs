using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreenTimer : MonoBehaviour
{
    private static float time = 0f;
    void FixedUpdate()
    {
        time += Time.deltaTime;
    }

    public static float get_time() => time;
}
