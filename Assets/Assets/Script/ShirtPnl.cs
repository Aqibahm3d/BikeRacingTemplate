using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class ShirtPnl : MonoBehaviour
{
    public List<String> bikerNameList;
    public List<string> bikertextList;
    public List<Sprite> bikerImages;
    public int bikerId;
    public Button btn01;
    public Button btn02;
    public Button btn03;
    public Button btn04;
    public Button btn05;
    public Button btn06;
    public Button btn07;
    public Button btn08;
    public Button btn09;
    public Button btn10;

    public TextMeshProUGUI bikerName;
    public TextMeshProUGUI bikerText;
    public Image bikerImage;


    private void Start()
    {
        btn01.onClick.AddListener(() => {
            bikerId = 0;
            SetBikerData();
        });

        btn02.onClick.AddListener(() => {
            bikerId = 1;
            SetBikerData();
        });

        btn03.onClick.AddListener(() => {
            bikerId = 2;
            SetBikerData(); });

        btn04.onClick.AddListener(() => {
            bikerId = 3;
            SetBikerData();
        });
        btn05.onClick.AddListener(() => {
            bikerId = 4;
            SetBikerData();
        });

        btn06.onClick.AddListener(() => {
            bikerId = 5;
            SetBikerData();
        });

        btn07.onClick.AddListener(() => {
            bikerId = 6;
            SetBikerData();
        });

        btn08.onClick.AddListener(() => {
            bikerId = 7;
            SetBikerData();
        });

        btn09.onClick.AddListener(() => {
            bikerId = 8;
            SetBikerData();
        });

        btn10.onClick.AddListener(() => {
            bikerId = 9;
            SetBikerData();
        });
    }
    public void SetBikerData()
    {
        for (int i = 0; i <= bikerNameList.Count; i++)
        {
            if (i == bikerId )
            {
                bikerName.text = bikerNameList[i];
                
               
            }
        }
        for (int i = 0; i <= bikertextList.Count; i++)
        {
            if (i == bikerId)
            {
               
                bikerText.text = bikertextList[i];
              
            }
        }
        for (int i = 0; i <= bikerImages.Count; i++)
        {
            if (i == bikerId)
            {
              
                bikerImage.sprite = bikerImages[i];
            }
        }

    }
}
