using Unity.VisualScripting;
using UnityEngine;
using System;

public class Context : MonoBehaviour
{
    public static Context Instance;

    public VN_WindowManager WindowManager;

    private void Awake()
    {
        DontDestroyOnLoad(this);

        if (Instance == null) { Instance = this; }
        else { Destroy(this); }
    }
    public void Initialize(Action Callback)
    {
        WindowManager = this.AddComponent<VN_WindowManager>();

        Debug.Log("Context initialized");
        Callback.Invoke();
    }
}
