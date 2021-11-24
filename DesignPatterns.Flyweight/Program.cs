var text = new FormattedText("abcdefghijklmnopqrstuvwxyz");
text.Capitalize(0, 4);
text.Capitalize(10, 14);
text.Capitalize(20, 24);
Console.WriteLine(text);