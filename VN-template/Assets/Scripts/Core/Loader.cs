using System;
using Unity.VisualScripting;
using UnityEngine;

public class Loader : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        this.AddComponent<Context>().Initialize(OnInitialized);
    }

    private void OnInitialized()
    {
        Destroy(this);
        Debug.Log("Loader destroyed");

        Context.Instance.WindowManager.OpenWindow(VN.UI.VN_WindowsNames.MainMenu);
    }
}