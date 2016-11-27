using GameCore;
using TechTalk.SpecFlow;
using Xunit;

namespace Specs
{
    [Binding]
    public class PlayerCharacterSteps
    {
        PlayerCharacter _player;

        [Given(@"I'm a new player")]
        public void GivenImANewPlayer()
        {
            _player = new PlayerCharacter();
        }

        [When("I take (.*) damage")]
        public void WhenITakeDamage(int damage)
        {
            _player.Hit(damage);
        }


        [Then("My health should now be (.*)")]
        public void ThenMyHealthShouldNowBe(int expectedHealth)
        {
            Assert.Equal(expectedHealth, _player.Health);
        }

        [Then(@"I am dead")]
        public void ThenIAmDead()
        {
            Assert.Equal(true, _player.IsDead);
        }
    }
}
