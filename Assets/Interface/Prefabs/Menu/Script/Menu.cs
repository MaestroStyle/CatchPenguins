﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class Menu : UIScreen
{
    public GameObject LanguagePanel;
    public GameObject Cursor;

    public DataManager dm;

    public override void Show()
    {
        base.Show();
        LanguagePanel.SetActive(false);
    }

    public void OnLanguageBtn() {
        LanguagePanel.SetActive(!LanguagePanel.activeSelf);
    }

    public void OnRusBtn() { }
    public void OnEngBtn() { }
    public void OnArrowDownBtn() {
        LanguagePanel.SetActive(!LanguagePanel.activeSelf);
    }
        
    public void OnShopBtn()
    {
        UIHome.instance.ShowShop();
        Debug.Log("Show shop!");
    }

    public void OnAboutBtn()
    {
        UIHome.instance.ShowAbout();
        Debug.Log("Show about!");
        dm.Save();
    }
    public void TapOnScreenPanel() {
        UIHome.instance.ShowPlay();
        Debug.Log("Game start!");
    }
}
