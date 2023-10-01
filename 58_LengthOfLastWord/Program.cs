// See https://aka.ms/new-console-template for more information

Console.WriteLine(LengthOfLastWord("s"));

static int LengthOfLastWord(string s)
{
    var noSpaceEnd = s.TrimEnd();
    int lastSpaceIndex = noSpaceEnd.LastIndexOf(' ');

    if (lastSpaceIndex == -1)
        return noSpaceEnd.Length;

    return noSpaceEnd.Length - lastSpaceIndex - 1;
}