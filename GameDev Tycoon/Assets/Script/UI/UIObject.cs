using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    [CreateAssetMenu(fileName = "UIScritableObject", menuName = "UI/UIScritable", order = 1)]
    public class UIObject : ScriptableObject
    {
        [SerializeField] private UIEvent[] eventUI;
        [SerializeField] private GameObject[] productionUI;
        [SerializeField] private GameObject[] StartUI;
        [SerializeField] private GameObject LoadingUI;
        public UIEvent[] GetEventUI {get { return eventUI; } }
        public GameObject[] GetProductionUI { get { return productionUI; } }
        public GameObject[] GetStartUI { get { return StartUI; } }
        public GameObject GetLoadingUI { get { return LoadingUI; } }

    }
}

