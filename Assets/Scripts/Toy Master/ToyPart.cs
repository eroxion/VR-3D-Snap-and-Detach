using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Interactables;


public class ToyPart : MonoBehaviour
{
    [SerializeField] private string targetSlotName;
    [SerializeField] private Transform snapTarget;
    private bool isSnapped = false;
    private InputSystem_Actions inputSystem;

    private void Awake()
    {
        inputSystem = new InputSystem_Actions();
        inputSystem.Player.Enable();
    }
    
    private void FixedUpdate()
    {
        if (isSnapped && GetComponent<XRGrabInteractable>().isSelected)
        {
            if (inputSystem.Player.Detach.IsPressed())
            {
                Detach();
            }
        }
    }
    
    internal void Detach()
    {
        if (isSnapped)
        {
            GetComponent<Rigidbody>().isKinematic = false;
            isSnapped = false;
            snapTarget = null;
        }
    }
}
