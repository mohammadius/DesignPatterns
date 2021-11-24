namespace DesignPatterns.Flyweight;

public class FlyweightFormattedText
{
	private readonly string _plainText;
	private List<TextRange> _formatting = new();

	public FlyweightFormattedText(string plainText)
	{
		_plainText = plainText;
	}

	public TextRange GetRange(int start, int end)
	{
		var range = new TextRange { Start = start, End = end };
		_formatting.Add(range);
		return range;
	}

	public override string ToString()
	{
		return string.Create(_plainText.Length, _plainText, (span, s) =>
		{
			for (var i = 0; i < s.Length; i++)
			{
				var c = s[i];
				foreach (var range in _formatting)
				{
					if (range.Covers(i) && range.Capitalize)
					{
						c = char.ToUpper(c);
					}
				}

				span[i] = c;
			}
		});
	}

	public class TextRange
	{
		public int Start { get; set; }
		public int End { get; set; }

		// a bool property for each formatting (bold, italic, etc.)
		public bool Capitalize { get; set; }
		public bool Covers(int position) => position >= Start && position <= End;
	}
}