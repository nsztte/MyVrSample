using UnityEngine;

namespace MyFps
{
    public class VrUI : MonoBehaviour
    {
        #region Variables
        public Transform head;
        [SerializeField] private Vector3 distance = Vector3.zero;
        #endregion

        private void Update()
        {
            this.transform.position = head.position + distance;
        }
    }
}