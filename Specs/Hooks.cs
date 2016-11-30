using TechTalk.SpecFlow;

namespace Specs
{
    [Binding]
    public class Hooks : Steps
    {
        [BeforeScenario("elf")]
        public void BeforeScenario()
        {
        }

        [AfterScenario("elf")]
        public void AfterScenario()
        {

        }

    }
}
