using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteractionController : MonoBehaviour {

    public float interactionDistance = 3;
    RaycastHit lastObjectHit;
	
	// Update is called once per frame
	void Update ()
    {
        CheckForInteraction();

        if (Input.GetButtonDown("Fire1"))
            CheckForSelection();
    }

    void CheckForInteraction()
    {
        Debug.DrawRay(this.transform.position, this.transform.forward * interactionDistance, Color.magenta);

        if (Physics.Raycast(this.transform.position, this.transform.forward, out lastObjectHit, interactionDistance))
        {
            //Debug.Log("Hit " + lastObjectHit.collider.gameObject.name);
            InteractableObject interactable = lastObjectHit.collider.gameObject.GetComponent<InteractableObject>();
            if (interactable != null)
            {
                interactable.OnHover();
            }
        }
    }

    void CheckForSelection()
    {
        if (Physics.Raycast(this.transform.position, this.transform.forward, out lastObjectHit, interactionDistance))
        {
            //Debug.Log("Hit " + lastObjectHit.collider.gameObject.name);
            InteractableObject interactable = lastObjectHit.collider.gameObject.GetComponent<InteractableObject>();
            if (interactable != null)
            {
                interactable.OnSelect();
            }
        }
    }
}
