using GameCore;
using System.Linq;
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

        [Given(@"I have a damage resistance of (.*)")]
        public void GivenIHaveADamageResistanceOf(int damageResistance)
        {
            _player.DamageResistance = damageResistance;
        }

        [Given(@"I'm an Elf")]
        public void GivenImAnElf()
        {
            _player.Race = "Elf";
        }

        [Given(@"I have the following attributes")]
        public void GivenIHaveTheFollowingAttributes(Table table)
        {
            var race = table.Rows.First(row => row["attribute"] == "Race")["value"];
            var damageResistance = table.Rows.First(row => row["attribute"] == "Resistance")["value"];
            _player.Race = race;
            _player.DamageResistance = int.Parse(damageResistance);

        }


    }
}
