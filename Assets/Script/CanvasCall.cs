using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CanvasCall : MonoBehaviour
{
    public GameObject sv;
    void Start()
    {
        sv.SetActive(false);
    }

    public void onClick()
    {
        //Debug.Log("Push!");
        sv.SetActive(!sv.activeSelf);
    }
}
