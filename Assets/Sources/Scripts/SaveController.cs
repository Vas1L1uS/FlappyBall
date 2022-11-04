using UnityEngine;
using System;

static public class SaveController
{
    public const string TIME_EASY_LEVEL = "TimeEasyLevel";
    public const string TIME_MEDIUM_LEVEL = "TimeMediumLevel";
    public const string TIME_HARD_LEVEL = "TimeHardLevel";

    static public string CurrentLevel { get; set; }

    static public void SaveBestResultByLevel(string currentTime)
       {
        string bestTime = GetBestResultByLevel();

        ÑomparisonAndSave(currentTime, bestTime);
    }

    static public string GetBestResultByLevel()
    {
        string bestTime = PlayerPrefs.GetString(CurrentLevel);
        if (bestTime == string.Empty)
        {
            bestTime = "00:00";
        }
        return bestTime;
    }

    static private void ÑomparisonAndSave(string currentTime, string bestTime)
    {
        var currentTimeElements = currentTime.Split(':');
        var bestTimeElements = bestTime.Split(':');

        if (Convert.ToInt32(currentTimeElements[0]) > Convert.ToInt32(bestTimeElements[0]))
        {
            PlayerPrefs.SetString(CurrentLevel, currentTime);
        }
        else if (Convert.ToInt32(currentTimeElements[0]) == Convert.ToInt32(bestTimeElements[0]))
        {
            if (Convert.ToInt32(currentTimeElements[1]) > Convert.ToInt32(bestTimeElements[1]))
            {
                PlayerPrefs.SetString(CurrentLevel, currentTime);
            }
        }

        PlayerPrefs.Save();
    }
}