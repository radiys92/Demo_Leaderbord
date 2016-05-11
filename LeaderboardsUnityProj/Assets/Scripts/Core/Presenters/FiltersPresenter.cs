using UnityEngine;
using UnityEngine.UI;

public class FiltersPresenter: LeaderboardPanelPresenter
{
    [Header("Difficulty filters")] 
    public Toggle EasyToggle;
    public Toggle MediumToggle;
    public Toggle HardToggle;

    [Header("Status filters")] 
    public Toggle AllStatusToggle;
    public Toggle MyStatusToggle;
    public Text MyStatusText;

    private FiltersInfo FiltersInfo
    {
        get { return ParentScreen.GetFiltersInfo(); }
        set { ParentScreen.SetFiltersInfo(value); }
    }

    void Start()
    {
        UpdateView();
        ReggisterEvents();
    }

    private void UpdateView()
    {
        var info = FiltersInfo;
        EasyToggle.isOn = info.Difficulty == Difficulty.Easy;
        MediumToggle.isOn = info.Difficulty == Difficulty.Medium;
        HardToggle.isOn = info.Difficulty == Difficulty.Hard;

        AllStatusToggle.isOn = info.PlayerStatus == PlayerStatus.All;
        MyStatusToggle.isOn = info.PlayerStatus == PlayerStatus.Brookie;
        MyStatusText.text = LocalizationBridge.Instance.LocalizeStatusFilterCaption(PlayerStatus.Brookie);
    }

    private void ReggisterEvents()
    {
        EasyToggle.onValueChanged.AddListener(on => { if (on) SetDifficulty(Difficulty.Easy); });
        MediumToggle.onValueChanged.AddListener(on => { if (on) SetDifficulty(Difficulty.Medium); });
        HardToggle.onValueChanged.AddListener(on => { if (on) SetDifficulty(Difficulty.Hard); });

        AllStatusToggle.onValueChanged.AddListener(on => { if (on) SetStatusFilter(PlayerStatus.All); });
        MyStatusToggle.onValueChanged.AddListener(on => { if (on) SetStatusFilter(PlayerStatus.Brookie); });
    }

    private void SetStatusFilter(PlayerStatus playerStatus)
    {
        var info = FiltersInfo;
        info.PlayerStatus = playerStatus;
        FiltersInfo = info;
    }

    private void SetDifficulty(Difficulty difficulty)
    {
        var info = FiltersInfo;
        info.Difficulty = difficulty;
        FiltersInfo = info;
    }
}