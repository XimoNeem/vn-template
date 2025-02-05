using UnityEngine;

public class WindowController : MonoBehaviour
{
    private string _name;
    public virtual void InitWindow()
    {
        
    }

    public virtual void Close()
    {
        Destroy(this.gameObject);
    }
}
