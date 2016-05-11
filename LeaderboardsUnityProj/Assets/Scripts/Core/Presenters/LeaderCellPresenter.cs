using UnityEngine;
using UnityEngine.UI;

internal class LeaderCellPresenter : MonoBehaviour
{
    public Text NumberText;
    public Text NameText;
    public Text ScoreText;
    public Image IconImage;

    public void SetData(UserTopViewData viewData)
    {
        IconImage.sprite = viewData.Icon;
        NumberText.text = LocalizationBridge.Instance.LocalizeLeaderIndex(viewData.Index);
        NameText.text = viewData.UserName;
        ScoreText.text = LocalizationBridge.Instance.LocalizeLeaderScore(viewData.Score);
    }
}