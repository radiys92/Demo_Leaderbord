using UnityEngine;
using UnityEngine.Events;

public class LeaderboarsScreenPresenter : MonoBehaviour
{
    public LeaderboardPanelPresenter[] ScreenPresenters;
    public UnityEvent OnUserStatsUpdate = new UnityEvent();

    private FiltersInfo FiltersInfo { get; set; }

    void Awake()
    {
        foreach (var presenter in ScreenPresenters)
        {
            presenter.InitPresenter(this);
        }
    }

    public void GoBackScreen()
    {
        Debug.Log("Go to main menu button pressed!");
    }

    public void ShareStats()
    {
        Debug.Log("Share button pressed!");
    }

    public FiltersInfo GetFiltersInfo()
    {
        return FiltersInfo;
    }

    public void SetFiltersInfo(FiltersInfo info)
    {
        Debug.Log("Setted filter satet to "+info.ToString());
        FiltersInfo = info;
    }

    public UserStatsViewData GetUserStatsViewData()
    {
        return UserStatsViewData.InitFrom(OptionsBridge.Instance.GetUserStats());
    }
}