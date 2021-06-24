using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Discord;

public class DiscordController : MonoBehaviour
{
    public Discord.Discord discord;

    private void Start()
    {
        discord = new Discord.Discord(857654332387622943, (System.UInt64)Discord.CreateFlags.Default);
        var activityManager = discord.GetActivityManager();
        var activity = new Discord.Activity
        {
            State = "Exploring map"
        };
        activityManager.UpdateActivity(activity, (res) =>
        {
            
        });
    }

    private void Update()
    {
        discord.RunCallbacks();
    }
}
