using OWML.ModHelper;
using UnityEngine;

namespace modthatclosesthegamewhenitopens
{
    public class modthatclosesthegamewhenitopens : ModBehaviour
    {
        public static modthatclosesthegamewhenitopens Instance;

        public void Awake()
        {
            Instance = this;
        }

        public void Start()
        {
            Application.Quit();
        }
    }
}
