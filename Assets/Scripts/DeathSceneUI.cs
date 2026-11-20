using System;
using TMPro;
using UnityEngine;

public class DeathSceneUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI deathText;

    private void Start()
    {
        deathText.text = string.Format("You died!\n\nBut.. you collected {0} coins in the process!\n\nGood job?", Scoring.score);
    }
}
