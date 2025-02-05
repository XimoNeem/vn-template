using System.Collections.Generic;
using UnityEngine;

public class VN_WindowManager : MonoBehaviour
{

    private Dictionary<string, GameObject> _windows = new Dictionary<string, GameObject>();

    /// <summary>
    /// ��������� ����, �������� ���, ���� ��� ��� �� ���� �������.
    /// </summary>
    public GameObject OpenWindow(string windowName)
    {
        if (_windows.TryGetValue(windowName, out GameObject existingWindow))
        {
            existingWindow.SetActive(true);
            return existingWindow;
        }

        GameObject prefab = Resources.Load<GameObject>(windowName);
        if (prefab == null)
        {
            Debug.LogError($"������ ���� �� ������ � Resources: {windowName}");
            return null;
        }

        GameObject newWindow = Instantiate(prefab);
        _windows[windowName] = newWindow;
        return newWindow;
    }

    /// <summary>
    /// ��������� ����, ������� ���.
    /// </summary>
    public void CloseWindow(string windowName)
    {
        if (_windows.TryGetValue(windowName, out GameObject existingWindow))
        {
            existingWindow.SetActive(false);
        }
    }

    /// <summary>
    /// ��������� ������� ���� �� ������.
    /// </summary>
    public void DestroyWindow(string windowName)
    {
        if (_windows.TryGetValue(windowName, out GameObject existingWindow))
        {
            Destroy(existingWindow);
            _windows.Remove(windowName);
        }
    }
}
