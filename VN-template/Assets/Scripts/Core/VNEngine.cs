using System;
using UnityEngine;

public class VNEngine : MonoBehaviour
{
    public static VNEngine Instance;

    private VNEpisode currentEpisode;
    private VNScene currentScene;
    private int sceneIndex = 0;
    private int dialogueIndex = 0;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(this);
    }

    private void Start()
    {
        // Добавляем VNEngine в глобальный контекст
        Context.Instance.gameObject.AddComponent<VNEngine>();
    }

    /// <summary>
    /// Загружает эпизод и начинает его с первой сцены.
    /// </summary>
    public void StartEpisode(VNEpisode episode)
    {
        if (episode == null)
        {
            Debug.LogError("Эпизод не задан!");
            return;
        }

        currentEpisode = episode;
        sceneIndex = 0;
        StartScene(currentEpisode.scenes[sceneIndex]);
    }

    /// <summary>
    /// Загружает сцену и начинает ее с первого диалога.
    /// </summary>
    public void StartScene(VNScene scene)
    {
        if (scene == null)
        {
            Debug.LogError("Сцена не задана!");
            return;
        }

        currentScene = scene;
        dialogueIndex = 0;
        ShowDialogue();
    }

    /// <summary>
    /// Показывает текущий диалог.
    /// </summary>
    public void ShowDialogue()
    {
        if (currentScene == null || currentScene.dialogues.Length == 0)
        {
            Debug.LogError("В сцене нет диалогов!");
            return;
        }

        if (dialogueIndex >= currentScene.dialogues.Length)
        {
            NextScene();
            return;
        }

        DialogueData dialogue = currentScene.dialogues[dialogueIndex];
        dialogueIndex++;

        // Выводим в консоль, пока нет UI
        Debug.Log(dialogue.isSingleText
            ? $"НАРРАТОР: {dialogue.text}"
            : $"{dialogue.characterName}: {dialogue.text}");
    }

    /// <summary>
    /// Переход к следующему диалогу в сцене.
    /// </summary>
    public void NextDialogue()
    {
        ShowDialogue();
    }

    /// <summary>
    /// Переход к следующей сцене в эпизоде.
    /// </summary>
    public void NextScene()
    {
        sceneIndex++;

        if (sceneIndex >= currentEpisode.scenes.Length)
        {
            Debug.Log("Эпизод завершен.");
            return;
        }

        StartScene(currentEpisode.scenes[sceneIndex]);
    }
}
