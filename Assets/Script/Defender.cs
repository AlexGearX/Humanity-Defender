using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{

    [SerializeField] int crownCost = 100;

    public void AddCrowns(int amout)
    {
        FindObjectOfType<CrownDisplay>().AddCrowns(amout);
    }

    public int GetCrownCost()
    {
        return crownCost;
    }

}
