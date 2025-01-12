﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace CalculatorTestss.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Check if a number is a prime number")]
    public partial class CheckIfANumberIsAPrimeNumberFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Primary.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Check if a number is a prime number", "  As a user\r\n  I want to check if a number is prime\r\n  So that I can verify the p" +
                    "rimality of a given number", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check if a number is prime")]
        [NUnit.Framework.TestCaseAttribute("2", "Prime", null)]
        [NUnit.Framework.TestCaseAttribute("3", "Prime", null)]
        [NUnit.Framework.TestCaseAttribute("5", "Prime", null)]
        [NUnit.Framework.TestCaseAttribute("7", "Prime", null)]
        [NUnit.Framework.TestCaseAttribute("11", "Prime", null)]
        [NUnit.Framework.TestCaseAttribute("13", "Prime", null)]
        [NUnit.Framework.TestCaseAttribute("17", "Prime", null)]
        [NUnit.Framework.TestCaseAttribute("19", "Prime", null)]
        [NUnit.Framework.TestCaseAttribute("23", "Prime", null)]
        [NUnit.Framework.TestCaseAttribute("29", "Prime", null)]
        [NUnit.Framework.TestCaseAttribute("31", "Prime", null)]
        [NUnit.Framework.TestCaseAttribute("37", "Prime", null)]
        [NUnit.Framework.TestCaseAttribute("41", "Prime", null)]
        [NUnit.Framework.TestCaseAttribute("43", "Prime", null)]
        [NUnit.Framework.TestCaseAttribute("47", "Prime", null)]
        [NUnit.Framework.TestCaseAttribute("53", "Prime", null)]
        [NUnit.Framework.TestCaseAttribute("59", "Prime", null)]
        [NUnit.Framework.TestCaseAttribute("61", "Prime", null)]
        [NUnit.Framework.TestCaseAttribute("67", "Prime", null)]
        [NUnit.Framework.TestCaseAttribute("71", "Prime", null)]
        public virtual void CheckIfANumberIsPrime(string number, string isPrime, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("number", number);
            argumentsOfScenario.Add("isPrime", isPrime);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if a number is prime", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 6
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
    testRunner.Given(string.Format("the prime number is {0}", number), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
    testRunner.When("I check if the number is prime", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
    testRunner.Then(string.Format("the prime result should be \"{0}\"", isPrime), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check if a number is not prime")]
        [NUnit.Framework.TestCaseAttribute("8", null)]
        [NUnit.Framework.TestCaseAttribute("9", null)]
        [NUnit.Framework.TestCaseAttribute("10", null)]
        [NUnit.Framework.TestCaseAttribute("12", null)]
        [NUnit.Framework.TestCaseAttribute("14", null)]
        [NUnit.Framework.TestCaseAttribute("15", null)]
        [NUnit.Framework.TestCaseAttribute("16", null)]
        [NUnit.Framework.TestCaseAttribute("18", null)]
        [NUnit.Framework.TestCaseAttribute("20", null)]
        [NUnit.Framework.TestCaseAttribute("21", null)]
        [NUnit.Framework.TestCaseAttribute("22", null)]
        [NUnit.Framework.TestCaseAttribute("24", null)]
        [NUnit.Framework.TestCaseAttribute("25", null)]
        [NUnit.Framework.TestCaseAttribute("26", null)]
        [NUnit.Framework.TestCaseAttribute("27", null)]
        [NUnit.Framework.TestCaseAttribute("28", null)]
        [NUnit.Framework.TestCaseAttribute("30", null)]
        [NUnit.Framework.TestCaseAttribute("32", null)]
        [NUnit.Framework.TestCaseAttribute("33", null)]
        [NUnit.Framework.TestCaseAttribute("34", null)]
        public virtual void CheckIfANumberIsNotPrime(string number, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("number", number);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if a number is not prime", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 34
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 35
    testRunner.Given(string.Format("the prime number is {0}", number), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 36
    testRunner.When("I check if the number is prime", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
    testRunner.Then("the prime result should be \"Not Prime\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
