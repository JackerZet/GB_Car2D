using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Ui.Settings
{
    public class SettingsMenuView : MonoBehaviour
    {
        [SerializeField] private Button _buttonBack;
        
        public void Init(UnityAction backGame)
        {
            _buttonBack.onClick.AddListener(backGame);           
        }

        public void OnDestroy()
        {
            _buttonBack.onClick.RemoveAllListeners();           
        }
    }
}
