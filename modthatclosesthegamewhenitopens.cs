using OWML.ModHelper;
using UnityEngine;

namespace modthatclosesthegamewhenitopens
{
    public class modthatclosesthegamewhenitopens : ModBehaviour
    {
        static modthatclosesthegamewhenitopens() {
            Application.Quit();
        }
    }
}
