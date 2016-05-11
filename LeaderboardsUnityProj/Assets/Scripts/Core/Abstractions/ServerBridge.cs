using System.Collections.Generic;
using DataKeepers;
public class ServerBridge : CharpSingleton<ServerBridge>
{
    public UserStats GetUserStats()
    {
        return UserStats.Dummy;
    }

    public UserTopData[] GetTop10Data()
    {
        var res = new List<UserTopData>();
        for (var i = 0; i < 10; i++)
        {
            res.Add(UserTopData.Dummy);
        }
        return res.ToArray();
    }
}

public class UserTopData
{
    public static UserTopData Dummy
    {
        get
        {
            return new UserTopData()
            {
                IconId = UnityEngine.Random.Range(0, 9),
                Score = 123245,
                UserName = "Olga Pupkina"
            };
        }
    }

    public int IconId { get; set; }
    public string UserName { get; set; }
    public long Score { get; set; }
}