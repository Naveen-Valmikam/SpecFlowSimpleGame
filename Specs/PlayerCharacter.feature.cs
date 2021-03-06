﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class PlayerCharacterFeature : Xunit.IClassFixture<PlayerCharacterFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PlayerCharacter.feature"
#line hidden
        
        public PlayerCharacterFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PlayerCharacter", "\tIn order to play the game\r\n\tAs a human player\r\n\tI want my character attributes t" +
                    "o be correctly represented", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 7
 #line 8
  testRunner.Given("I\'m a new player", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        public virtual void SetFixture(PlayerCharacterFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.TheoryAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Health Reduction")]
        [Xunit.InlineDataAttribute("0", "100", new string[0])]
        [Xunit.InlineDataAttribute("30", "70", new string[0])]
        [Xunit.InlineDataAttribute("60", "40", new string[0])]
        public virtual void HealthReduction(string damage, string expectedHealth, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Health Reduction", exampleTags);
#line 10
 this.ScenarioSetup(scenarioInfo);
#line 7
 this.FeatureBackground();
#line 11
 testRunner.When(string.Format("I take {0} damage", damage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then(string.Format("My health should now be {0}", expectedHealth), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Taking too much damageresults in player death")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Taking too much damageresults in player death")]
        public virtual void TakingTooMuchDamageresultsInPlayerDeath()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Taking too much damageresults in player death", ((string[])(null)));
#line 20
this.ScenarioSetup(scenarioInfo);
#line 7
 this.FeatureBackground();
#line 21
testRunner.When("I take 100 damage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
testRunner.Then("I am dead", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Elf race characters get additional 20 damage resistance")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Elf race characters get additional 20 damage resistance")]
        [Xunit.TraitAttribute("Category", "elf")]
        public virtual void ElfRaceCharactersGetAdditional20DamageResistance()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Elf race characters get additional 20 damage resistance", new string[] {
                        "elf"});
#line 25
this.ScenarioSetup(scenarioInfo);
#line 7
 this.FeatureBackground();
#line 26
testRunner.And("I have a damage resistance of 10", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
testRunner.And("I\'m an Elf", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
testRunner.When("I take 30 damage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
testRunner.Then("My health should now be 100", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Elf race characters get additional 20 damage resistance using data table")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Elf race characters get additional 20 damage resistance using data table")]
        [Xunit.TraitAttribute("Category", "elf")]
        public virtual void ElfRaceCharactersGetAdditional20DamageResistanceUsingDataTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Elf race characters get additional 20 damage resistance using data table", new string[] {
                        "elf"});
#line 32
this.ScenarioSetup(scenarioInfo);
#line 7
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "attribute",
                        "value"});
            table1.AddRow(new string[] {
                        "Race",
                        "Elf"});
            table1.AddRow(new string[] {
                        "Resistance",
                        "10"});
#line 33
testRunner.And("I have the following attributes", ((string)(null)), table1, "And ");
#line 37
testRunner.When("I take 30 damage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
testRunner.Then("My health should now be 100", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Healers restore all health")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Healers restore all health")]
        public virtual void HealersRestoreAllHealth()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Healers restore all health", ((string[])(null)));
#line 40
this.ScenarioSetup(scenarioInfo);
#line 7
 this.FeatureBackground();
#line 41
testRunner.Given("My character class is set to healer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 42
testRunner.When("I take 30 damage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
testRunner.And("Cast a healing spell", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
testRunner.Then("My health should now be 100", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Total magical power")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Total magical power")]
        public virtual void TotalMagicalPower()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Total magical power", ((string[])(null)));
#line 46
this.ScenarioSetup(scenarioInfo);
#line 7
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "Value",
                        "Power"});
            table2.AddRow(new string[] {
                        "Ring",
                        "200",
                        "100"});
            table2.AddRow(new string[] {
                        "Amulet",
                        "400",
                        "200"});
            table2.AddRow(new string[] {
                        "Ring",
                        "100",
                        "400"});
#line 47
testRunner.Given("I have the following magical items", ((string)(null)), table2, "Given ");
#line 52
testRunner.Then("My total magical power should be 700", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Reading a restore health scroll when over tired had no effect")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Reading a restore health scroll when over tired had no effect")]
        public virtual void ReadingARestoreHealthScrollWhenOverTiredHadNoEffect()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Reading a restore health scroll when over tired had no effect", ((string[])(null)));
#line 54
this.ScenarioSetup(scenarioInfo);
#line 7
 this.FeatureBackground();
#line 55
testRunner.Given("I last slept 4 days ago", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 56
testRunner.When("I take 40 damage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
testRunner.And("I read a restore health scroll", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
testRunner.Then("My health should now be 60", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Weapons are worth money")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Weapons are worth money")]
        public virtual void WeaponsAreWorthMoney()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Weapons are worth money", ((string[])(null)));
#line 60
this.ScenarioSetup(scenarioInfo);
#line 7
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table3.AddRow(new string[] {
                        "Sword",
                        "50"});
            table3.AddRow(new string[] {
                        "Pick",
                        "40"});
            table3.AddRow(new string[] {
                        "Knife",
                        "10"});
#line 61
testRunner.Given("I have the following weapons", ((string)(null)), table3, "Given ");
#line 66
testRunner.Then("My weapons should be worth 100", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Elf race characters don\'t lose magical power")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Elf race characters don\'t lose magical power")]
        [Xunit.TraitAttribute("Category", "elf")]
        public virtual void ElfRaceCharactersDonTLoseMagicalPower()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Elf race characters don\'t lose magical power", new string[] {
                        "elf"});
#line 69
this.ScenarioSetup(scenarioInfo);
#line 7
 this.FeatureBackground();
#line 70
testRunner.Given("I\'m an Elf", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 71
testRunner.And("I have an Amulet with a power of 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
testRunner.When("I use a magical Amulet", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
testRunner.Then("The Amulet power should not be reduced", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                PlayerCharacterFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PlayerCharacterFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
