using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuousAudio : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
