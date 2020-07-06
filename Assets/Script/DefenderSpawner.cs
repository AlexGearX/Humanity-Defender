using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defender defender;

    private void OnMouseDown()
    {
        attemptToPlaceDefenderAt(GetSquareClicked());
    }

    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defender = defenderToSelect;
    }

    private void attemptToPlaceDefenderAt(Vector2 gridPos)
    {
        var CrownDisplay = FindObjectOfType<CrownDisplay>();
        int defendercost = defender.GetCrownCost();
        if (CrownDisplay.HaveEnoughCrowns(defendercost))
        {
            SpawnDefender(gridPos);
            CrownDisplay.SpendCrowns(defendercost);
        }
        
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 ClickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(ClickPos);
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }

    private void SpawnDefender( Vector2 roundedPos)
    {
        Defender newDefender = Instantiate(defender, roundedPos, quaternion.identity) as Defender;
        
    }

}
