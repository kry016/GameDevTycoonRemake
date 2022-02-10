using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Date
{
    [SerializeField] private int year;
    [SerializeField] private int month;
    [SerializeField] private int week;
    public int GetYear { get { return year; } set { year = value; } }
    public int GetMonth { get { return month; } set { month = value; } }
    public int GetWeek { get { return week; } set { week = value; } }
    public int GetDateSum() => year + month + week;
}
