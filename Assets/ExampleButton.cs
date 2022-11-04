using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DiscordPresence;
public class ExampleButton : MonoBehaviour
{
    
    public string detail, state;
    public void Button()
    {
        PresenceManager.UpdatePresence(detail:detail,state: state);
    }
    public void ClickForTime()
      {
          DateTime epochStart = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
          int cur_time = (int)(DateTime.UtcNow - epochStart).TotalSeconds;
          PresenceManager.UpdatePresence(detail: "Thoi gian ne", start: cur_time);
      }

    
}
