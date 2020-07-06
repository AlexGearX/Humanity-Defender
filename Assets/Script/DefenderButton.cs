using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{

    [SerializeField] Defender defenderPrefab;
    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(49, 49, 49, 255);
        }
            GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
            FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
    }

}
