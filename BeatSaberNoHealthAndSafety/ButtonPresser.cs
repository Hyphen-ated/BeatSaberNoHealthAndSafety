using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace BeatSaberNoHealthAndSafety
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
                    Console.WriteLine("[NoHealthAndSafety]: Clicking 'continue' through the safety warning");
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
