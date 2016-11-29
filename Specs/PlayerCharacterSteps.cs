using GameCore;
using System.Linq;
using TechTalk.SpecFlow;
using Xunit;
using TechTalk.SpecFlow.Assist;
using System.Collections;
using System.Collections.Generic;

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
            dynamic attributes = table.CreateDynamicInstance();
            _player.Race = attributes.Race;
            _player.DamageResistance = attributes.Resistance;

        }
        

        [Given(@"My character class is set to (.*)")]
        public void GivenMyCharacterClassIsSetToHealer(CharacterType characterType)
        {
            _player.CharacterType = characterType;
        }

        [When(@"Cast a healing spell")]
        public void WhenCastAHealingSpell()
        {
            _player.CastHealingSpell();
        }


        [Given(@"I have the following magical items")]
        public void GivenIHaveTheFollowingMagicalItems(Table table)
        {
            //foreach (var row in table.Rows)
            //{
            //    var name = row["Item"];
            //    var value = row["Value"];
            //    var power = row["Power"];

            //    _player.MagicalItems.Add(new MagicalItem
            //    {
            //        Name = name,
            //        Value = int.Parse(value),
            //        Power = int.Parse(power)
            //    });

            //}

            // Strongly Typed DataSet
            IEnumerable<MagicalItem> items = table.CreateSet<MagicalItem>();
            _player.MagicalItems.AddRange(items);


            // using Dynamic Set -- weakly typed though
            //IEnumerable<dynamic> items = table.CreateDynamicSet();
            //foreach (var magicalItem in items)
            //{
            //    _player.MagicalItems.Add(new MagicalItem
            //    {
            //        Name = magicalItem.name,
            //        Value = magicalItem.Value,
            //        Power = magicalItem.Power
            //    });
            //}
        }

        [Then(@"My total magical power should be (.*)")]
        public void ThenMyTotalMagicalPowerShouldBe(int expectedPower)
        {
            Assert.Equal(expectedPower, _player.MagicalPower);
        }

    }
}
