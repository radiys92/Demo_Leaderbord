using UnityEngine;

public class UserStats
{
    public static UserStats Dummy
    {
        get { return new UserStats()
        {
            UserName = "Vasya Pupkin",
            IconId = 6,
            Rank = (long)(Random.value*9999999 + 9999),
            Score = (long)(Random.value * 9999 + 999),
            BetterThen = Random.Range(10,99)
        };}
    }

    public int BetterThen { get; set; }

    public long Score { get; set; }

    public long Rank { get; set; }

    public int IconId { get; set; }

    public string UserName { get; set; }
}