using HighlightingSystem;
using UnityEngine;

[RequireComponent(typeof(Highlighter))]
public class InteractableObject : MonoBehaviour {

    public Color highlightColor = Color.cyan;
    private Highlighter _highligher;

    private void Start()
    {
        _highligher = GetComponent<Highlighter>();
    }

    public void OnHover()
    {
        _highligher.Hover(highlightColor);
    }

    public void OnSelect()
    {
        //Debug.Log( this.gameObject.name + " selected.");
        UIManager.instance.ShowObjectSelection();
    }
}
