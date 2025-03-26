using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace VRProject1
{
    public class SocketItemTransformChanger : MonoBehaviour
    {
        [SerializeField] private Transform[] socketTransforms;
        private XRSocketInteractor _socketInteractor;

        private void Awake()
        {
            _socketInteractor = this.GetComponent<XRSocketInteractor>();
        }

        private void Start()
        {
            _socketInteractor.attachTransform = null;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("SocketItem"))
            {
                ItemPartID partId = other.GetComponent<ItemPartID>();
                int id = partId.getPartId();
                _socketInteractor.attachTransform = socketTransforms[id];
            }
        }
        
        private void OnTriggerExit(Collider other)
        {
            _socketInteractor.attachTransform = null;
        }
    }
}
