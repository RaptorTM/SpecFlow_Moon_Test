using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Xml;
using NUnit.Engine;

namespace SpecFlowAllure.Steps
{
    public class AllureRunner
    {
        public const string TestPlanEnv = "ALLURE_TESTPLAN_PATH";

        public static void Main(string[] args)
        {
            var path = Assembly.GetExecutingAssembly().Location;

            var package = new TestPackage(path);
            package.AddSetting("WorkDirectory", Environment.CurrentDirectory);

            using (ITestEngine engine = TestEngineActivator.CreateInstance())
            {
                var filterService = engine.Services.GetService<ITestFilterService>();
                var builder = filterService.GetTestFilterBuilder();
                var testPlan = getTestPlan();
                //Console.WriteLine(testPlan.Tests[0].Selector);
                if (testPlan != null)
                {
                    Console.WriteLine("Not empty");
                    foreach (var testCase in testPlan.Tests)
                    {
                        builder.AddTest(testCase.Selector);
                    }
                }

                var filter = builder.GetFilter();
                using (ITestRunner runner = engine.GetRunner(package))
                {
                    //var result = runner.Run(listener: null, filter: filter);
                    runner.Run(listener: null, filter: filter);
                    //XmlDocument doc = new XmlDocument();
                    //var xml_str = result.OuterXml;

                    //doc.LoadXml(xml_str);
                    //Console.WriteLine(Path.Combine(Environment.CurrentDirectory, "TestResults.xml"));
                    //doc.Save(Path.Combine(Environment.CurrentDirectory, "TestResults.xml"));
                }
            }
        }

        public static TestPlan? getTestPlan()
        {
            var testPlanPath = getTestPlanPath();
            if (!(testPlanPath != null && File.Exists(testPlanPath)))
            {
                return null;
            }

            //try
            //{
            var testPlanJson = File.ReadAllText(testPlanPath);

            var options = new JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = true;
            Console.WriteLine($"testPlanJson: {testPlanJson} options: {options}");
            return JsonSerializer.Deserialize<TestPlan>(testPlanJson, options);
            //}
            //catch (Exception e)
            //{
            //    return null;
            //}
        }

        public static string? getTestPlanPath()
        {
            var testPlanPath = Environment.GetEnvironmentVariable(TestPlanEnv);
            Console.WriteLine(testPlanPath);
            return testPlanPath;
        }
    }

    public class TestPlan
    {
        public string Version { get; set; }
        public List<TestCase> Tests { get; set; }
    }

    public class TestCase
    {
        public int Id { get; set; }
        public string Selector { get; set; }
    }
}