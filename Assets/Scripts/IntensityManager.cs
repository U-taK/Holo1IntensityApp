using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

namespace uOSC {
    public class IntensityManager : MonoBehaviour, IInputClickHandler
    {
        

        // Use this for initialization
        void Start()
        {
            //Airtapを検出したとき、OnInputClickedがよばれる
            InputManager.Instance.PushFallbackInputHandler(gameObject);
            //
        }

        // Update is called once per frame
        void Update()
        {

        }
        public void OnInputClicked(InputClickedEventData eventData)
        {
            throw new System.NotImplementedException();
        }
    }
}
