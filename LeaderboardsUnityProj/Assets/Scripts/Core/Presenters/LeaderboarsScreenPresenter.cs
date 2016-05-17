using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class LeaderboarsScreenPresenter : MonoBehaviour
{
    public LeaderboardPanelPresenter[] ScreenPresenters;

    public UnityEvent OnUserStatsUpdate = new UnityEvent();
    public UnityEvent OnLeadersDataUpdate = new UnityEvent();

    private FiltersInfo _filtersInfo;

    private FiltersInfo FiltersInfo
    {
        get { return _filtersInfo; }
        set
        {
            _filtersInfo = value;
            OnUserStatsUpdate.Invoke();
            OnLeadersDataUpdate.Invoke();
        }
    }

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
        return UserStatsViewData.InitFrom(ServerBridge.Instance.GetCurrentUserStats(FiltersInfo));
    }

    public UserTopViewData[] GetTop10ViewData()
    {
        var baseData = ServerBridge.Instance.GetTop10Data(FiltersInfo);
        return baseData.Select((data,ind) => UserTopViewData.InitFrom(ind+1,data)).ToArray();
    }
}