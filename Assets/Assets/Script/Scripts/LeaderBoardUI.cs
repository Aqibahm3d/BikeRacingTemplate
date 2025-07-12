using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderBoardUI : MonoBehaviour
{
    public Button backBtn;

    private void Start()
    {
        backBtn.onClick.AddListener(() => {

            this.gameObject.SetActive(false);
        });
    }
}
