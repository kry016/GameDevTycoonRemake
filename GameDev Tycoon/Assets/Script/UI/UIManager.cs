using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private UIObject uiObject;

        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
            //GameObject Object = Instantiate(uiObject.GetLoadingUI, transform);
            //Object.GetComponentInChildren<Image>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }

        private void Activated()
        {

        }
    }
}

