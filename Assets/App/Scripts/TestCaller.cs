using Microsoft.MixedReality.Toolkit.Core.Services;
using UnityEngine;

namespace Assets.App.Scripts
{
    public class TestCaller : MonoBehaviour
    {
        private void Start()
        {
            var service  = MixedRealityToolkit.Instance.GetService<ITestDataService>();
            Debug.Log("Service returned " + service.GetTestData());
        }
    }
}
