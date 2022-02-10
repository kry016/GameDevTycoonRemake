using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "officeObject", menuName = "Office/OfficeObject", order = 2)]
public class OfficeObJect : ScriptableObject
{
    [SerializeField] private Office[] office;
    public Office[] Getoffice { get { return office; } }
}
