using UnityEngine;
using System.Collections.Generic;

public class globalVars
{
    public static float spawnSpeed = 1.0f;
    public static float liveSpeed = 2.0f;
    public static int level = 1;
    public static int last10 = 0;
    public static int last10Score = 0;
    public static int tries = 1;
    public static bool pauseMenuActive = false;
    public static List<int> levelStars = new List<int>(){0,0,0,0,0,0,0,0,0,0};

}
