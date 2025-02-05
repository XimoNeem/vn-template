using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu_Window : WindowController
{
    [SerializeField] private Button _playButton;
    [SerializeField] private Transform _episodeListContainer;
    [SerializeField] private GameObject _episodeButtonPrefab;

    [SerializeField] private List<VNEpisode> _availableEpisodes;

    public override void InitWindow()
    {
        base.InitWindow();
    }
    private void OnEnable()
    {
        _playButton.onClick.AddListener(ShowEpisodeList);
    }

    private void ShowEpisodeList()
    {
        // ������� ������ ������, ���� ��� ����
        foreach (Transform child in _episodeListContainer)
        {
            Destroy(child.gameObject);
        }

        // ������� ������ ��� ������� �������
        foreach (var episode in _availableEpisodes)
        {
            GameObject episodeButtonObj = Instantiate(_episodeButtonPrefab, _episodeListContainer);
            episodeButtonObj.SetActive(true);
            Button episodeButton = episodeButtonObj.GetComponent<Button>();
            TMP_Text buttonText = episodeButtonObj.GetComponentInChildren<TMP_Text>();

            if (buttonText != null)
            {
                buttonText.text = episode.episodeName;
            }

            // ��������� �������� ��� �������
            episodeButton.onClick.AddListener(() =>
            {
                Debug.Log($"������ ������: {episode.episodeName}");
                // TODO: ������ �������
                Context.Instance.WindowManager.OpenWindow(VN.UI.VN_WindowsNames.MainView);
            });
        }
    }
}
