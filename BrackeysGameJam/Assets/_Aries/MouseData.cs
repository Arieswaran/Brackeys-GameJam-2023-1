using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class MouseData
{
    public int health;
    public int max_health;
    public int speed;
    public int lifespan;
    public int actions;
    public int max_actions;
    public int played_count;
    public int brushed_count;
    public int generation_count = 20;
    public System.Action OnStatsChanged;
}

[Serializable]
public class PlayerData{
    public int red_cheese_count =1;
    public int blue_cheese_count =1;
    public int green_cheese_count =1;
}