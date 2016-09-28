using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using Selenium;

namespace SeleniumTests
{
[TestFixture]
public class can Login
{
private ISelenium selenium;
private StringBuilder verificationErrors;

[SetUp]
public void SetupTest()
{
selenium = new DefaultSelenium("localhost", 4444, "*chrome", "http://localhost:1787/");
selenium.Start();
verificationErrors = new StringBuilder();
}

[TearDown]
public void TeardownTest()
{
try
{
selenium.Stop();
}
catch (Exception)
{
// Ignore errors if unable to close the browser
}
Assert.AreEqual("", verificationErrors.ToString());
}

[Test]
public void TheCan LoginTest()
{
			selenium.Open("/Login?ReturnUrl=%2f");
			selenium.Type("id=login-username", "regional");
			selenium.Type("id=login-password", "P@ssw0rdcats");
			selenium.Click("id=login-btn");
			selenium.WaitForPageToLoad("3000000");
			selenium.Click("link=Regional User");
			Assert.IsTrue(selenium.IsElementPresent("id=linkLogout"));
			selenium.Click("id=linkLogout");
			selenium.WaitForPageToLoad("3000000");
}
}
}
