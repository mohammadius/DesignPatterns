var ft = new FormattedText("abcdefghijklmnopqrstuvwxyz");
ft.Capitalize(0, 4);
ft.Capitalize(10, 14);
ft.Capitalize(20, 24);
Console.Write("Formatted Text:           ");
Console.WriteLine(ft);

var fft = new FlyweightFormattedText("abcdefghijklmnopqrstuvwxyz");
fft.GetRange(0, 4).Capitalize = true;
fft.GetRange(10, 14).Capitalize = true;
fft.GetRange(20, 24).Capitalize = true;
Console.Write("Flyweight Formatted Text: ");
Console.WriteLine(fft);