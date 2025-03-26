using UnityEngine;

namespace VRProject1
{
    public class ItemPartID : MonoBehaviour
    {
        [SerializeField] private int partId;

        internal int getPartId()
        {
            return partId;
        }
    }
}
