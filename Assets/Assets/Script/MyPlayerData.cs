using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyPlayerData : MonoBehaviour
{
    public endlessmodeGraphics endlessmodeGraphics;

    public TextMeshProUGUI distanceText;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI ScoreText;

    private void OnEnable()
    {
        ShowMyData();
    }
    public void ShowMyData()
    {
        distanceText.text = endlessmodeGraphics.distance.text;
        coinText.text = endlessmodeGraphics.coinCash.text;
        ScoreText.text = endlessmodeGraphics.score.text;

    }
}
