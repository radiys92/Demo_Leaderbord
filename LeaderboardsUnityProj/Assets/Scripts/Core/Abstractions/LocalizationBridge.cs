using DataKeepers;

internal class LocalizationBridge : CharpSingleton<LocalizationBridge>
{
    public string LocalizeStatusFilterCaption(PlayerStatus playerStatus)
    {
        return string.Format("ONLY {0}", playerStatus.ToString().ToUpper());
    }

    public string LocalizeRankStat(long rank)
    {
        return rank.ToString("###,###,###,##0");
    }

    public string LocalizeScoreStat(long score)
    {
        return score.ToString("###,###,###,##0");
    }

    public string LocalizeBetterThanCaption(int percents)
    {
        return string.Format("YOU are better than {0}%", percents);
    }

    public string LocalizePointerCaption(int percents)
    {
        return string.Format("{0}%", percents);
    }
}