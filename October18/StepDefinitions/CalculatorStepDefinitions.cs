using NUnit.Framework;
using SpecFlowProject1.Features;
using System.Net;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        Class1 cal = new Class1();
        int i, j;
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            i=number;
            Console.WriteLine($"{nameof(GivenTheFirstNumberIs)} : {number}");
        }


        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            j = number;
            Console.WriteLine($"{nameof(GivenTheSecondNumberIs)} : {number}");
            
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Console.WriteLine($"{nameof(WhenTheTwoNumbersAreAdded)}");  
        }


        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {

            int actual = i + j;
            result = i + j;
            Console.WriteLine($"{nameof(ThenTheResultShouldBe)} : {result}");
            Assert.AreEqual(result, actual);

            
        }


       //***************************************************************************//


        [When("the two numbers are subtracted")]

        public void WhenTheTwoNumbersAreSubtracted()
        {
            Console.WriteLine($"{nameof(WhenTheTwoNumbersAreSubtracted)}");
           

        }

        [Then("the output should be (.*)")]
        public void ThenTheResultShouldBe(double result)
        {
            result = i - j;
            Console.WriteLine($"{nameof(ThenTheResultShouldBe)} : {result}");
          
        }

        //****************************************************************************

        [When("the two numbers are multiplied")]

        public void WhenTheTwoNumbersAreMultiplied()
        {
            Console.WriteLine($"{nameof(WhenTheTwoNumbersAreMultiplied)}");
        }

        [Then("the answer should be (.*)")]
        public void ThenTheAnswerShouldBe(double result)
        {
            result = i * j;
            Console.WriteLine($"{nameof(ThenTheAnswerShouldBe)} : {result}");

        }


        //****************************************************************************

        [When("the two numbers are divided")]

        public void WhenTheTwoNumbersAreDivided()
        {
            Console.WriteLine($"{nameof(WhenTheTwoNumbersAreDivided)}");
        }

        [Then("the divans should be (.*)")]
        public void ThenTheDivansShouldBe(double result)
        {
            int a;
            a = i / j;
            result = i / j;
            Console.WriteLine($"{nameof(ThenTheAnswerShouldBe)} : {result}");
            Assert.AreEqual(a, result);
        }
        //*******************************************************************************//

        double k;
        [Given(@"the number is (.*)")]
        public void GivenTheNumberIs(double p0)
        {
            k = p0;
        }

        [When(@"the number is taken squareroot")]
        public void WhenTheNumberIsTakenSquareroot()
        {
            Console.WriteLine("taking squareroot..");
        }

        [Then(@"the sqr root result be (.*)")]
        public void ThenTheSqrRootResultBe(double result)
        {
            double output= Math.Sqrt(k);
            result = Math.Sqrt(k);
            Console.WriteLine($"Sqr root value of {k}: {result}");
            Assert.AreEqual(output,result);

        }
    }
}