using UnityEngine;

namespace MyFps
{
    public class XRPickupAmmoBox : SimpleInteractable
    {
        #region Variables
        //AmmoBox 아이템 획득시 지급하는 ammo 갯수
        [SerializeField] private int giveAmmo = 7;

        public AmmoUI ammoUI;
        #endregion

        protected override void DoAction()
        {
            //아이템 지급
            Debug.Log("탄환 7개를 지급 했습니다");
            PlayerStats.Instance.AddAmmo(giveAmmo);

            ammoUI.ShowAmmoUI();

            //킬
            Destroy(gameObject);
        }
    }
}