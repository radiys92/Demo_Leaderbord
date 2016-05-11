using UnityEngine;

public class UserStatsViewData
{
    public static UserStatsViewData InitFrom(UserStats userStats)
    {
        return new UserStatsViewData()
        {
            BetterThen = userStats.BetterThen,
            Score = userStats.Score,
            Rank = userStats.Rank,
            Icon = ResourcesBridge.Instance.GetIconById(userStats.IconId),
            UserName = userStats.UserName
        };
    }

    public int BetterThen { get; set; }

    public long Score { get; set; }

    public long Rank { get; set; }

    public Sprite Icon { get; set; }

    public string UserName { get; set; }
}