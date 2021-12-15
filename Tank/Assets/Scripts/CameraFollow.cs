using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Camera mianCamera;
    void Start()
    {
        mianCamera = Camera.main;
        mianCamera.transform.SetParent(GameManager.localPlayer.transform, false);
    }
}
