using UnityEngine;

public class UserStats
{
    public static UserStats Dummy
    {
        get { return new UserStats()
        {
            UserName = "Vasya Pupkin",
            IconId = Random.Range(0,9),
            Rank = 1234567,
            Score = 12345,
            BetterThen = Random.Range(10,99)
        };}
    }

    public int BetterThen { get; set; }

    public long Score { get; set; }

    public long Rank { get; set; }

    public int IconId { get; set; }

    public string UserName { get; set; }
}