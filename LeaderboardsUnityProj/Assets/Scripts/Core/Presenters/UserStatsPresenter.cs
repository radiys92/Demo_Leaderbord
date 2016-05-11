using UnityEngine;
using UnityEngine.UI;

public class UserStatsPresenter : LeaderboardPanelPresenter
{
    [Header("Base Data")]
    public Text NameText;
    public Text RankText;
    public Text ScoreText;
    public Text BetterText;
    public Image IconImage;

    [Header("Pointer objects")] 
    public RectTransform PointerLimitsRectTransform;
    public RectTransform PointerRectTransform;
    public Text PointerText;

    void Start()
    {
        UpdateView();
        ParentScreen.OnUserStatsUpdate.AddListener(UpdateView);
    }

    private void UpdateView()
    {
        var data = ParentScreen.GetUserStatsViewData();

        // base
        NameText.text = data.UserName;
        RankText.text = LocalizationBridge.Instance.LocalizeRankStat(data.Rank);
        ScoreText.text = LocalizationBridge.Instance.LocalizeScoreStat(data.Score);
        BetterText.text = LocalizationBridge.Instance.LocalizeBetterThanCaption(data.BetterThen);
        IconImage.sprite = data.Icon;

        // pointer
        PointerText.text = LocalizationBridge.Instance.LocalizePointerCaption(data.BetterThen);
        var min = PointerLimitsRectTransform.rect.min;
        var point = PointerLimitsRectTransform.rect.width*data.BetterThen/100f;
        var localPos = min + new Vector2(point, 0);
        localPos.y = PointerRectTransform.localPosition.y;
        PointerRectTransform.localPosition = localPos;
    }
}