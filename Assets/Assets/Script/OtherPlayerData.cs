using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OtherPlayerData : MonoBehaviour
{
    public List<string> playerNameList;
    public List<string> distanceList;
    public List<string> coinList;
    public List<string> scoreList;

    public TextMeshProUGUI playerNameTxt;
    public TextMeshProUGUI distanceTxt;
    public TextMeshProUGUI coinTxt;
    public TextMeshProUGUI scoreTxt;

    public int id;
    private void OnEnable()
    {
        ShowData();
    }

    public void ShowData()
    {
        id = Random.Range(0, 5);

        for (int i = 0; i < playerNameList.Count; i++)
        {
            if (i == id)
            {
                playerNameTxt.text = playerNameList[i];
            }
        }
        for (int i = 0; i < distanceList.Count; i++)
        {
            if (i == id)
            {
                distanceTxt.text = distanceList[i];
            }
        }
        for (int i = 0; i < coinList.Count; i++)
        {
            if (i == id)
            {
                coinTxt.text = coinList[i];
            }
        }
        for (int i = 0; i < scoreList.Count; i++)
        {
            if (i == id)
            {
                scoreTxt.text = scoreList[i];
            }
        }
    }

}
