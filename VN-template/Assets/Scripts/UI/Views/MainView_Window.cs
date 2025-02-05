using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainView_Window : WindowController
{
    [Header("UI Elements")]
    [SerializeField] private Image backgroundImage;
    [SerializeField] private TextMeshProUGUI characterNameText;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private Button nextButton;

    private Queue<string> dialogueQueue = new Queue<string>();

    private void Start()
    {
        nextButton.onClick.AddListener(ShowNextDialogue);
    }

    /// <summary>
    /// Устанавливает фон сцены.
    /// </summary>
    public void SetBackground(Sprite background)
    {
        if (backgroundImage != null)
        {
            backgroundImage.sprite = background;
        }
    }

    /// <summary>
    /// Устанавливает имя персонажа.
    /// </summary>
    public void SetCharacterName(string name)
    {
        if (characterNameText != null)
        {
            characterNameText.text = name;
        }
    }

    /// <summary>
    /// Добавляет реплики в очередь и показывает первую.
    /// </summary>
    public void SetDialogue(string[] dialogueLines)
    {
        dialogueQueue.Clear();
        foreach (var line in dialogueLines)
        {
            dialogueQueue.Enqueue(line);
        }
        ShowNextDialogue();
    }

    /// <summary>
    /// Показывает следующую реплику.
    /// </summary>
    private void ShowNextDialogue()
    {
        if (dialogueQueue.Count > 0)
        {
            dialogueText.text = dialogueQueue.Dequeue();
        }
        else
        {
            Close();
        }
    }

    /// <summary>
    /// Закрывает окно через WindowController.
    /// </summary>
    public override void Close()
    {
        base.Close();
    }
}
