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
        
        [When(@"I take 0 damage")]
        public void WhenITake0Damage()
        {
            _player.Hit(0);
        }
        
        [Then(@"My health should now be 100")]
        public void ThenMyHealthShouldNowBe100()
        {
            Assert.Equal(100, _player.Health);
        }


        [When(@"I take 30 damage")]
        public void WhenITake30Damage()
        {
            _player.Hit(30);
        }

        [Then(@"My health should now be 70")]
        public void ThenMyHealthShouldNowBe70()
        {
            Assert.Equal(70, _player.Health);
        }

        [When(@"I take 100 damage")]
        public void WhenITake100Damage()
        {
            _player.Hit(100);
        }

        [Then(@"I am dead")]
        public void ThenIAmDead()
        {
            Assert.Equal(true, _player.IsDead);
        }
    }
}
