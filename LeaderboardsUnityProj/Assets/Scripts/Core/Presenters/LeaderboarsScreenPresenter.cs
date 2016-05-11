using UnityEngine;
using System.Collections;

public class LeaderboarsScreenPresenter : MonoBehaviour
{
    public LeaderboardPanelPresenter[] ScreenPresenters;

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
}