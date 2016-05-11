using UnityEngine;

public abstract class LeaderboardPanelPresenter : MonoBehaviour
{
    protected LeaderboarsScreenPresenter ParentScreen = null;

    public virtual void InitPresenter(LeaderboarsScreenPresenter parent)
    {
        ParentScreen = parent;
    }
}