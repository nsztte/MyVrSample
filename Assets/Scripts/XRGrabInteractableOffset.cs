using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace MyVrSample
{
    /// <summary>
    /// 오브젝트를 잡을때 오프셋 위치 설정
    /// </summary>
    public class XRGrabInteractableOffset : XRGrabInteractable
    {
        #region Variables
        private GameObject attachPoint;

        private Vector3 initialLocalPosition;
        private Quaternion initialLocalRotation;
        #endregion

        private void Start()
        {
            if (attachTransform == null) //빈 오브젝트 생성 후 Attach Transform에 넣기
            {
                attachPoint = new GameObject("Offset Grab Pivot");
                attachPoint.transform.SetParent(transform, false);
                attachTransform = attachPoint.transform;
            }
            else
            {
                //초기값 저장
                initialLocalPosition = attachTransform.localPosition;
                initialLocalRotation = attachTransform.localRotation;
            }
        }

        protected override void OnSelectEntering(SelectEnterEventArgs args)
        {
            if(args.interactorObject is XRDirectInteractor)
            {
                attachTransform.position = args.interactorObject.transform.position;
                attachTransform.rotation = args.interactorObject.transform.rotation;
            }
            else
            {
                attachTransform.localPosition = initialLocalPosition;
                attachTransform.localRotation = initialLocalRotation;
            }
            
            base.OnSelectEntering(args);
        }
    }
}