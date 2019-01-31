using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIPanel : MonoBehaviour
{
    public TextMeshProUGUI headerText;
    public TextMeshProUGUI descriptionText;
    public Button closeButton;
    public UIManager uiManger;

    private void OnEnable()
    {
        closeButton.onClick.AddListener(uiManger.HideOjectSelection);
    }

    private void OnDisable()
    {
        closeButton.onClick.RemoveListener(uiManger.HideOjectSelection);
    }

    public void SetObjectData(InteractableObjectData data)
    {
        headerText.text = data.objectName;
        descriptionText.text = data.objectDescription;
    }

    public void HidePanel()
    {
        gameObject.SetActive(false);
    }

    public void ShowPanel()
    {
        gameObject.SetActive(true);
    }
}
