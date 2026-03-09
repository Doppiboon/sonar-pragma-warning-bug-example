namespace SonarPragmaWarningBugExample;

[AttributeUsage(AttributeTargets.All)]
// #pragma warning disable S3376 // Sonar Extension removes this
public class AttributeClass : Attribute
// #pragma warning restore S3376 // Sonar Extension removes this
{
	// #pragma warning disable IDE0290 // Sonar Extension removes this
	public AttributeClass(string textValue, int numberValue)
	// #pragma warning restore IDE0290 // Sonar Extension removes this
	{
		TextValue = textValue;
		NumberValue = numberValue;
	}

	public string TextValue { get; set; }

	public int NumberValue { get; set; }
}
