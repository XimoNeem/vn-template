using UnityEngine;

[CreateAssetMenu(fileName = "NewScene", menuName = "VN/Scene")]
public class VNScene : ScriptableObject
{
    public string sceneName; // Название сцены
    public Sprite background; // Фон сцены
    public DialogueData[] dialogues; // Список диалогов в сцене
}
