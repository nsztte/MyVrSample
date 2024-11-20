using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace MyFps
{
    public class WorldMenu : MonoBehaviour
    {
        #region Variables
        public GameObject worldMenuUI;

        public TextMeshProUGUI textBox;

        private Transform head;
        [SerializeField] private float distance;
        [SerializeField] private float offset = 1.0f;
        #endregion

        protected virtual void Start()
        {
            head = Camera.main.transform;
        }

        protected virtual void Update()
        {
            distance = PlayerCasting.distanceFromTarget;
        }

        protected void ShowMenuUI(string sequenceText = "")
        {
            worldMenuUI.SetActive(true);

            //show 설정
            distance = (distance < 1.5f) ? distance - 0.05f : offset;     //UI 벽속에 파묻힘 방지
            worldMenuUI.transform.position = head.position + new Vector3(head.forward.x, 0f, head.forward.z).normalized * distance;
            worldMenuUI.transform.LookAt(new Vector3(head.position.x, worldMenuUI.transform.position.y, head.position.z));
            worldMenuUI.transform.forward *= -1;

            //text 설정
            if (textBox)
            {
                textBox.text = sequenceText;
            }
        }

        protected void HideMenuUI()
        {
            worldMenuUI.SetActive(false);

            textBox.text = "";
        }
    }
}