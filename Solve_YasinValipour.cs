
/*
 << Question >>
 
    We are sinking! The nearest ship got our SOS call, but they replied in pure gobbledygook! Are ye savvy enough to decode the message, or will we be sleepin' with the fish tonight? All hands on deck!

    Whiskey Hotel Four Tango Dash Alpha Romeo Three Dash Yankee Oscar Uniform Dash Sierra One November Kilo India November Golf Dash Four Bravo Zero Uniform Seven

    Flag format: TFCCTF{RESUL7-H3R3}
 */


string inputString = "Whiskey Hotel Four Tango Dash Alpha Romeo Three Dash Yankee Oscar Uniform Dash Sierra One November Kilo India November Golf Dash Four Bravo Zero Uniform Seven";

List<string> words = new List<string>(inputString.Split(' '));


Dictionary<string, string> numbers = new Dictionary<string, string>
{
    { "One", "1" }, { "Three", "3" }, { "Four", "4" },
    { "Seven", "7" }, { "Zero", "0" }, { "Dash", "-" }
};

for (int i = 0; i < words.Count; i++)
{
    if (numbers.ContainsKey(words[i]))
    {
        words[i] = numbers[words[i]];
    }
}

//Answer
words.ForEach(word => Console.Write(word[0]));
