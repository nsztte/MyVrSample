using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace MyFps
{
    /// <summary>
    /// 두개의 Attach Point 구현
    /// </summary>
    public class GrabInteractableTwoAttach : GrabInteractable
    {
        #region Variables
        public Transform leftAttachTransform;
        public Transform rightAttachTransform;

        protected override void DoAction()
        {
        }
        #endregion

        protected override void OnSelectEntering(SelectEnterEventArgs args) //위치가 실시간으로 수정(Entered보다 먼저 실행됨)
        {
            //두개의 Attach Point를 잡는 손에 따라 구분해서 적용
            if (args.interactorObject.transform.CompareTag("LeftHand"))
            {
                attachTransform = leftAttachTransform;
            }
            else if (args.interactorObject.transform.CompareTag("RightHand"))
            {
                attachTransform = rightAttachTransform;
            }

            base.OnSelectEntering(args);
        }
    }
}