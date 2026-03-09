namespace SonarPragmaWarningBugExample;

[AttributeUsage(AttributeTargets.All)]
// #pragma warning disable S3376 // Sonar Extension removes this
public class AttributeClass : Attribute
// #pragma warning restore S3376 // Sonar Extension removes this
{
	public AttributeClass(string textValue, int numberValue)
	{
		TextValue = textValue;
		NumberValue = numberValue;
	}

	public string TextValue { get; set; }

	public int NumberValue { get; set; }
}
