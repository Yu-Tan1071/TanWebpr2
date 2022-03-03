using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkURL : MonoBehaviour
{
    public void onClick()
    {
        //Debug.Log("Push!");
        Application.OpenURL("https://www.spike-chunsoft.co.jp/ark/");
    }
}
