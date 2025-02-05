using UnityEngine;

[CreateAssetMenu(fileName = "NewScene", menuName = "VN/Scene")]
public class VNScene : ScriptableObject
{
    public string sceneName; // �������� �����
    public Sprite background; // ��� �����
    public DialogueData[] dialogues; // ������ �������� � �����
}
