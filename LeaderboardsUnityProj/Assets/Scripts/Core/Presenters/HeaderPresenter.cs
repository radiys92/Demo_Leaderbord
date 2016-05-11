using UnityEngine;
using UnityEngine.UI;

public class HeaderPresenter : LeaderboardPanelPresenter
{
    public Button BackButton;
    public Button ShareButton;

    void Start()
    {
        if (BackButton)
            BackButton.onClick.AddListener(ParentScreen.GoBackScreen);
        if (ShareButton)
            ShareButton.onClick.AddListener(ParentScreen.ShareStats);
    }
}