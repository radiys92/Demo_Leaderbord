using DataKeepers;
using UnityEngine;

public class ResourcesBridge : CharpSingleton<ResourcesBridge>
{
    private static readonly string AvatarPathPattern = "Avatars/{0}";

    public Sprite GetIconById(int iconId)
    {
        var avatarName = "avatar_placeholder";
        var otherNames = new[]
        {
            "Bazookalicious",
            "Electro-DE-lux",
            "mumbia",
            "Psycolizzard",
            "Pumpkin",
            "pUNK'N'STEIN",
            "skillet",
            "spitfire",
            "X-lightning"
        };
        if (iconId >= 0 && iconId < otherNames.Length)
            avatarName = otherNames[iconId];
        return Resources.Load<Sprite>(string.Format(AvatarPathPattern, avatarName));
    }
}