//using Allure.Commons;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.IO;
using TechTalk.SpecFlow;

namespace SpecFlowAllure.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private int FirstNumber;
        private int SecondtNumber;
        private int Result;
        private string Str;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            
            _scenarioContext = scenarioContext;

        }

        [Given("первое число (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 
            //_scenarioContext.Pending();
            //Console.WriteLine(Environment.CurrentDirectory);
            FirstNumber = number;
        }

        [Given("второе число (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            //_scenarioContext.Pending();
            SecondtNumber = number;
        }

        [When("два числа суммируются")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            //_scenarioContext.Pending();
            Result = FirstNumber + SecondtNumber;
        }

        [Then("результат должен быть (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            result.Should().Be(Result);

            //_scenarioContext.Pending();
        }

        [Given(@"пользователь ввел ""(.*)""")]
        public void GivenInputIs(string input_str)
        {
            Str = input_str;
        }

        [Then(@"ответ ""(.*)""")]
        public void ThenAnswerIs(string answer_str)
        {
            string world_str = "World";
            answer_str.Should().Be(world_str);
        }

        [When("два числа вычитаются")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            //TODO: implement act (action) logic
            //_scenarioContext.Pending();
            Result = FirstNumber - SecondtNumber;
        }

        [When("условие (.*)")]
        public void WhenConditionIsTrue(bool cond)
        {
            Assert.IsTrue(cond);
        }

        [Then("объект работает")]
        public void ObjectIsRunning()
        {
            Assert.IsTrue(true);
        }
    }
}
