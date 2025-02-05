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
    /// ������������� ��� �����.
    /// </summary>
    public void SetBackground(Sprite background)
    {
        if (backgroundImage != null)
        {
            backgroundImage.sprite = background;
        }
    }

    /// <summary>
    /// ������������� ��� ���������.
    /// </summary>
    public void SetCharacterName(string name)
    {
        if (characterNameText != null)
        {
            characterNameText.text = name;
        }
    }

    /// <summary>
    /// ��������� ������� � ������� � ���������� ������.
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
    /// ���������� ��������� �������.
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
    /// ��������� ���� ����� WindowController.
    /// </summary>
    public override void Close()
    {
        base.Close();
    }
}
