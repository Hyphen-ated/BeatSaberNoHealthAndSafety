using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace NoHealthAndSafety
{
    class ButtonPresser : MonoBehaviour
    {
        private IEnumerator clickIt()
        {
            yield return new WaitForSeconds(.3f);
            foreach (Button button in Resources.FindObjectsOfTypeAll<Button>())
            {
                if (button.name == "Continue")
                {
                    button.onClick.Invoke();
                }
            }
        }

        void Awake()
        {
            StartCoroutine(clickIt());
        }
    }
}