using UnityEngine;
using UnityEngine.Audio;

namespace MyFps
{
    public class XRPickupPistol : GrabInteractableTwoAttach
    {
        #region Variables
        //Action
        public GameObject arrow;

        public GameObject enemyTrigger;
        public GameObject ammoBox;
        public AmmoUI ammoUI;
        #endregion

        protected override void DoAction()
        {
            arrow.SetActive(false);
            ammoBox.SetActive(true);
            enemyTrigger.SetActive(true);

            //무기획득
            PlayerStats.Instance.SetHasGun(true);
            ammoUI.ShowAmmoUI();
        }
    }
}