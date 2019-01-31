using UnityEngine;

[CreateAssetMenu(fileName = "InteractableObjectData", menuName = "InteractableObject", order = 1)]
public class InteractableObjectData : ScriptableObject
{
    public string objectName = "New InteractableObject";
    [TextArea]
    public string objectDescription = "New InteractableObject";
}
