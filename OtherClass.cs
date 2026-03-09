namespace SonarPragmaWarningBugExample;

public class OtherClass
{
#pragma warning disable S1144 // Sonar Extension removes this
	private readonly int _async = 42;
#pragma warning restore S1144 // Sonar Extension removes this

	public static bool DoSomething()
	{
		List<int> testData = [42, 34];

#pragma warning disable S6617 // Sonar Extension removes this
		return testData.Any(n => n == 42);
#pragma warning restore S6617 // Sonar Extension removes this
	}
}
