using JetBrains.Annotations;
using Packages.Rider.Editor.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrownDisplay : MonoBehaviour
{
    [SerializeField] int crowns = 100;
    Text crownText;
    void Start()
    {
        crownText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        crownText.text = crowns.ToString();
    }

    public bool HaveEnoughCrowns(int amount)
    {
        return crowns >= amount;
    }

    public void AddCrowns(int amout)
    {
        crowns += amout;
        UpdateDisplay();
    }

    public void SpendCrowns(int amout)
    {
        if (crowns >= amout)
        {
            crowns -= amout;
            UpdateDisplay();
        }
    }
}
