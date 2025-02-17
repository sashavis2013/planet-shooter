using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : Menu
{
    [Header("UI References :")]
    [SerializeField] TMP_Text _scoreText;
    [Space]
    [SerializeField] Button _rateButton;
    [SerializeField] Button _settingButton;

    public override void SetEnable()
    {
        base.SetEnable();

        UpdateBestScoreDisplay();
    }

    private void Start()
    {
        OnButtonPressed(_rateButton, () =>
        {
            Application.OpenURL("https://t.me/cyRax2");
        });
        OnButtonPressed(_settingButton, () =>
        {
            MenuManager.Instance.OpenMenu(MenuType.Setting);
        });
    }

    private void UpdateBestScoreDisplay()
    {
        int bestScore = PlayerPrefs.GetInt("HighScore", 0);
        _scoreText.text = bestScore.ToString();
    }
}
