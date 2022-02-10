using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UIEvent
{
    [SerializeField] private GameObject UIPrefab;
    [SerializeField] private Date date;
    public Date Getdate { get { return date; } }
}
