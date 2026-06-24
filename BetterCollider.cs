using System.IO;
using System.Reflection;
using MSCLoader;
using UnityEngine;

namespace BetterCollider
{
    public class BetterCollider : Mod
    {
        public override string ID => "BetterCollider";
        public override string Name => "BetterCollider";
        public override string Author => "additions";
        public override string Version => "1.0";
        public override string Description => "Utility API";
        public override Game SupportedGames => Game.MySummerCar_And_MyWinterCar;

    }
}