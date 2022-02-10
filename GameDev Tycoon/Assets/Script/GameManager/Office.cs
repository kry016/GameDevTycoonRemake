using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Office
{
    [SerializeField] private string scene;
    [SerializeField] private Date date;
    [SerializeField] private int cashRange;
    [SerializeField] private int numberEmpoyee;
    [SerializeField] private int buy;
    [SerializeField] private bool execute = false;
    public Date GetDate { get { return GetDate; } }
    public int GetCash { get { return cashRange; } }
    public string GetScene { get { return scene; } }
    public int GetBuy { get { return buy; } }
    public int GetnumberEmpoyee { get { return numberEmpoyee; } }

    public bool OfficeChange(int cash, int day)
    {
        if (!execute)
        {            
            if (cashRange <= cash && date.GetDateSum() <= day)
            {
                return execute = true;
            }
        }
        
        return false;
    }
}
