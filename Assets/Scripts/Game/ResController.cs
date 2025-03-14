using UnityEngine;
using QFramework;

namespace Farm.Game
{
    public partial class ResController : ViewController, ISingleton
    {
        public static ResController Instance => MonoSingletonProperty<ResController>.Instance;

        public GameObject SeedPrefab;

        public void OnSingletonInit()
        {
        }
    }
}