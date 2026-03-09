namespace SonarPragmaWarningBugExample;

// Our Self-Managed Sonar Server says here: S109 Magic numbers are not allowed, for example.
[AttributeClass("Test", 100)]
public class AbstractClass
{
	public IList<string> TestData1 { get; set; } = [];

#pragma warning disable CS8618 // Sonar Extension accepts this
	public IList<string> TestData2 { get; set; }
#pragma warning restore CS8618 // Sonar Extension accepts this

#pragma warning disable CS8618 // Sonar Extension accepts this
	public List<string> TestData { get; set; }
#pragma warning restore CS8618 // Sonar Extension accepts this

	//#pragma warning disable CA1822 // Sonar Extension removes this
	//#pragma warning disable S2325 // Sonar Extension removes this
	public Task DoSomething()
	//#pragma warning restore CA1822 // Sonar Extension removes this
	//#pragma warning restore S2325 // Sonar Extension removes this
	{
		return Task.CompletedTask;
	}

	//#pragma warning disable CA1822 // Sonar Extension removes this
	//#pragma warning disable S2325 // Sonar Extension removes this
	public async Task<string> DoSomethingInParallel()
	//#pragma warning restore CA1822 // Sonar Extension removes this
	//#pragma warning restore S2325 // Sonar Extension removes this
	{
		return await Task.FromResult("");
	}
}
