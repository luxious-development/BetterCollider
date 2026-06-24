BetterCollider

A lightweight utility API that instantly gives your imported models perfect collision.

What it adds?
- MeshCollider that is way better than the original Unity one

How to use:
- Install the .dll file from [here](https://github.com/luxious-development/BetterCollider/releases)
- Add it as a Reference in your mod project/visual studio project
- Add ```using BetterCollider; ```
- Have ```GameObject 1; GameObject2;``` until you have the number of GameObjects
- After loading your object add this code to your project and rename myObject to the GameObject you want to add Collider
 ``` csharp
ColliderUtility.AddCollider(myObject); 
```

For multiple objects:
 - Simple,
just do this:
``` csharp
ColliderUtility.AddCollider(myObject);
ColliderUtility.AddCollider(myObject2); 
ColliderUtility.AddCollider(myObject3); 
```
until you have the number of GameObjects

Popular option:
```
using MSCLoader;
using UnityEngine;
using BetterCollider;

namespace Showcase
{
    public class Showcase : Mod
    {
        public override string ID => "Showcase";
        public override string Name => "Showcase";
        public override string Author => "additions";
        public override string Version => "1.0";
        public override string Description => "";
        public override Game SupportedGames => Game.MySummerCar_And_MyWinterCar;

        GameObject objectshowcase;

        public override void ModSetup()
        {
            SetupFunction(Setup.OnLoad, Mod_OnLoad);
        }
        private void Mod_OnLoad()
        {
            AssetBundle val = LoadAssets.LoadBundle("Showcase.Assets.showcase.unity3d");
            GameObject val2 = val.LoadAsset<GameObject>("showcase.prefab");
            objectshowcase = Object.Instantiate(val2);
            val.Unload(false);
            objectshowcase.transform.localPosition = new Vector3(1555.915f, 4.501545f, 742.5206f);
            ColliderUtility.AddCollider(objectshowcase);
        }
    }
}
```
Here is with multiple loads:
```
using MSCLoader;
using UnityEngine;
using BetterCollider;

namespace Showcase
{
    public class Showcase : Mod
    {
        public override string ID => "Showcase";
        public override string Name => "Showcase";
        public override string Author => "additions";
        public override string Version => "1.0";
        public override string Description => "";
        public override Game SupportedGames => Game.MySummerCar_And_MyWinterCar;

        GameObject objectshowcase;
        GameObject objectshowcase2;
        GameObject objectshowcase3;

        public override void ModSetup()
        {
            SetupFunction(Setup.OnLoad, Mod_OnLoad);
        }
        private void Mod_OnLoad()
        {
            AssetBundle val = LoadAssets.LoadBundle("Showcase.Assets.showcase.unity3d");
            GameObject val2 = val.LoadAsset<GameObject>("showcase.prefab");
            objectshowcase = Object.Instantiate(val2);
            GameObject val3 = val.LoadAsset<GameObject>("showcase2.prefab");
            objectshowcase = Object.Instantiate(val3);
            GameObject val4 = val.LoadAsset<GameObject>("showcase3.prefab");
            objectshowcase = Object.Instantiate(val4);
            val.Unload(false);
            objectshowcase.transform.localPosition = new Vector3(1555.915f, 4.501545f, 742.5206f);
            ColliderUtility.AddCollider(objectshowcase);
            ColliderUtility.AddCollider(objectshowcase2);
            ColliderUtility.AddCollider(objectshowcase3);
        }
    }
}
```

- [nexusmods](https://www.nexusmods.com/profile/additions)
- [discord group Luxious Development](https://discord.gg/sg4zmVc7Kk)
- [telegram group](t.me/LuxiousDevelopment)


Shittings:

- In reference tab in MSCLoader it doesnt show Author and version (i dont know why)
