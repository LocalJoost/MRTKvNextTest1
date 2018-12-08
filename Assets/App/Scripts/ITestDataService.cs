using Microsoft.MixedReality.Toolkit.Core.Interfaces;

namespace Assets.App.Scripts
{
    public interface ITestDataService : IMixedRealityExtensionService
    {
        string GetTestData();
    }
}
