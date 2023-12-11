using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TanksMP
{
    public class CheatCode : MonoBehaviour
    {
        [Cheat]
        private static void a()
        {
            CheatConsole.Log("Hello");
        }
    }
}