using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class LeaderboarsScreenPresenter : MonoBehaviour
{
    public LeaderboardPanelPresenter[] ScreenPresenters;
    public UnityEvent OnUserStatsUpdate = new UnityEvent();
    public RectTransform ContantContainer;

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

    public UserTopViewData[] GetTop10ViewData()
    {
        var baseData = ServerBridge.Instance.GetTop10Data(FiltersInfo);
        return baseData.Select((data,ind) => UserTopViewData.InitFrom(ind+1,data)).ToArray();
    }

    public void SetHeight(float lowerWorldPoint)
    {
        ContantContainer.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, lowerWorldPoint);
    }
}