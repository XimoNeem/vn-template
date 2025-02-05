using UnityEngine;

[CreateAssetMenu(fileName = "NewDialogue", menuName = "VN/Dialogue")]
public class DialogueData : ScriptableObject
{
    public bool isSingleText; // ���� true, ��� ������ ����� ��� ���������
    [TextArea(3, 5)] public string text; // ����� �������
    public string characterName; // ��� ��������� (���� ����)
    public Sprite characterSprite; // ������ ��������� (���� ����)
}
