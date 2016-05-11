using UnityEngine;

public class UserTopViewData
{
    public static UserTopViewData InitFrom(int ind, UserTopData data)
    {
        return new UserTopViewData()
        {
            Index = ind,
            Icon = ResourcesBridge.Instance.GetIconById(data.IconId),
            UserName = data.UserName,
            Score = data.Score
        };
    }

    public long Score { get; set; }

    public string UserName { get; set; }

    public Sprite Icon { get; set; }

    public int Index { get; set; }
}