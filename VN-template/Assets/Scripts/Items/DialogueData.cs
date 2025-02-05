using UnityEngine;

[CreateAssetMenu(fileName = "NewDialogue", menuName = "VN/Dialogue")]
public class DialogueData : ScriptableObject
{
    public bool isSingleText; // Если true, это просто текст без персонажа
    [TextArea(3, 5)] public string text; // Текст реплики
    public string characterName; // Имя персонажа (если есть)
    public Sprite characterSprite; // Спрайт персонажа (если есть)
}
