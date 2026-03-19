using UnityEngine;
using UnityEngine.InputSystem;


namespace Blocks.Gameplay.Core.Editor
{
    // Attach this MonoBehaviour to a GameObject in your scene.
    // Press B to show/hide the purchase overlay.
    public class CoreMenue : MonoBehaviour
    {
        private bool showBuyMenu;
        private readonly Rect menuRect = new Rect(20, 20, 260, 180);

        void Update()
        {
            if (Keyboard.current.bKey.wasPressedThisFrame)
            {
                showBuyMenu = !showBuyMenu;
            }
        }

        void OnGUI()
        {
            if (!showBuyMenu)
                return;

            GUI.color = Color.white;
            GUI.Box(menuRect, "Buy Menu");

            const float padding = 10f;
            var buttonRect = new Rect(menuRect.x + padding, menuRect.y + 40, menuRect.width - 2 * padding, 30);

            if (GUI.Button(buttonRect, "Buy Item 1"))
            {
                Debug.Log("Buy Item 1 clicked");
            }

            buttonRect.y += 40;
            if (GUI.Button(buttonRect, "Buy Item 2"))
            {
                Debug.Log("Buy Item 2 clicked");
            }

            buttonRect.y += 40;
            if (GUI.Button(buttonRect, "Close (B key also toggles)"))
            {
                showBuyMenu = false;
            }
        }
    }
}
