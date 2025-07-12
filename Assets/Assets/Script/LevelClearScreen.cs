using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelClearScreen : MonoBehaviour
{
    public LeaderBoardUI LeaderBoardUI;
    public Button leaderboardBtn;

    private void Start()
    {
        leaderboardBtn.onClick.AddListener(() => {
            OpenLeaderboad();
        
        });
    }

    public void OpenLeaderboad()
    {
        LeaderBoardUI.gameObject.SetActive(true);
    }
}
