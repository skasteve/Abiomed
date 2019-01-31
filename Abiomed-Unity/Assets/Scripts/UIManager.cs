using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class UIManager : MonoBehaviour {

    public static UIManager instance = null;

    [SerializeField]
    private FirstPersonController _firstPersonController;

    [SerializeField]
    private UIPanel _objectSelectionPanel;

	void Awake () {

        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);
    }

    public void ShowObjectSelection(InteractableObjectData data)
    {
        _objectSelectionPanel.SetObjectData(data);
        _objectSelectionPanel.ShowPanel();
        SetPlayerMovement(false);
    }

    public void HideOjectSelection()
    {
        _objectSelectionPanel.HidePanel();
        SetPlayerMovement(true);
    }

    void SetPlayerMovement(bool isMoving)
    {
        Cursor.visible = !isMoving;
        if (isMoving)
            Cursor.lockState = CursorLockMode.Locked;
        else
            Cursor.lockState = CursorLockMode.None;

        _firstPersonController.enabled = isMoving;
    }
}
