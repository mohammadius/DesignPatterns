namespace DesignPatterns.Flyweight;

public class FormattedText
{
	private readonly string _plainText;
	private readonly bool[] _capitalize;

	public FormattedText(string plainText)
	{
		_plainText = plainText;
		_capitalize = new bool[plainText.Length];
	}

	public void Capitalize(int start, int end)
	{
		for (int i = start; i <= end; i++)
		{
			_capitalize[i] = true;
		}
	}

	public override string ToString()
	{
		return string.Create(_plainText.Length, _plainText, (span, s) =>
		{
			for (var i = 0; i < s.Length; i++)
			{
				var c = s[i];
				span[i] = _capitalize[i] ? char.ToUpper(c) : c;
			}
		});
	}
}