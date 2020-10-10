using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpDownValueIP : MonoBehaviour
{

    TextMesh valueUiText;

    int interval = 1;

    int num;

    void Start()
    {
        valueUiText = this.GetComponent<TextMesh>();
    }

    private void Update()
    {
        num = int.Parse(valueUiText.text);
    }
    public void OnUpButtonClicked()
    {
        int setValue = int.Parse(valueUiText.text) + interval;
        valueUiText.text = setValue.ToString();
    }

    public void OnDownButtonClicked()
    {
        int setValue = int.Parse(valueUiText.text) - interval;
        valueUiText.text = setValue.ToString();
    }
}
