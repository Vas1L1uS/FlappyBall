using UnityEngine;
using UnityEngine.UI;

public class ChooseLevel : MonoBehaviour
{
    [SerializeField] private Text _bestTime;

    [SerializeField] private Button _easyButton;
    [SerializeField] private Button _mediumButton;
    [SerializeField] private Button _hardButton;

    private Image _easyImage;
    private Image _mediumImage;
    private Image _hardImage;

    private Color _selectedColor = new Color(230/255f, 230/255f, 90/255f);
    private Color _notSelectedColor = new Color(140/255f, 170/255f, 130/255f);

    private void Awake()
    {
        _easyImage = _easyButton.GetComponent<Image>();
        _mediumImage = _mediumButton.GetComponent<Image>();
        _hardImage = _hardButton.GetComponent<Image>();

        Click_EasyLevel();
    }

    public void Click_EasyLevel()
    {
        StartSettings.SetStartPlayerSettings(StartSettings.EasySettings);
        SaveController.CurrentLevel = SaveController.TIME_EASY_LEVEL;
        _bestTime.text = SaveController.GetBestResultByLevel();

        UIButtonsSettingRefresh(_easyButton);
    }

    public void Click_MediumLevel()
    {
        StartSettings.SetStartPlayerSettings(StartSettings.MediumSettings);
        SaveController.CurrentLevel = SaveController.TIME_MEDIUM_LEVEL;
        _bestTime.text = SaveController.GetBestResultByLevel();

        UIButtonsSettingRefresh(_mediumButton);
    }

    public void Click_HardLevel()
    {
        StartSettings.SetStartPlayerSettings(StartSettings.HardSettings);
        SaveController.CurrentLevel = SaveController.TIME_HARD_LEVEL;
        _bestTime.text = SaveController.GetBestResultByLevel();

        UIButtonsSettingRefresh(_hardButton);
    }

    private void UIButtonsSettingRefresh(Button button)
    {
        _easyButton.interactable = true;
        _mediumButton.interactable = true;
        _hardButton.interactable = true;

        _easyImage.color = _notSelectedColor;
        _mediumImage.color = _notSelectedColor;
        _hardImage.color = _notSelectedColor;

        button.interactable = false;
        button.GetComponent<Image>().color = _selectedColor;
    }
}
