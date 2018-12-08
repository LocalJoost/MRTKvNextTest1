using Microsoft.MixedReality.Toolkit.Core.Services;
using UnityEngine;

namespace Assets.App.Scripts
{
    public class TestDataService : BaseExtensionService, ITestDataService
    {
        public TestDataService(string name, uint priority) : base(name, priority)
        {
        }

        public string GetTestData()
        {
            Debug.Log("GetTestData called");
            return "Hello";
        }
    }
}
