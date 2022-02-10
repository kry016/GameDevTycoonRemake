using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameState
{
    [SerializeField] private int cash;
    [SerializeField] private int reaserchPoint;
    [SerializeField] private int BugPoint;
    [SerializeField] private int DesignPoint;
    [SerializeField] private int TechnologyPoint;
    public int GetCash { get { return cash; } }

}
