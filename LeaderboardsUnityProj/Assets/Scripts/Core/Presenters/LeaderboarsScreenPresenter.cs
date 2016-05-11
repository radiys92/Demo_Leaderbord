using UnityEngine;
using System.Collections;

public class LeaderboarsScreenPresenter : MonoBehaviour
{
    public LeaderboardPanelPresenter[] ScreenPresenters;

    void Start()
    {
        foreach (var presenter in ScreenPresenters)
        {
            presenter.InitPresenter(this);
        }
    }
}