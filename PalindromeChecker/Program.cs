Console.WriteLine("Welcome to the palindrome checker.\n Enter a word:");
string word = Convert.ToString(Console.ReadLine());
word = word.ToLower(); //converting to all lower case to make vowel checker easier to code

//initializing two char lists for future comparison
char[] charWord = word.ToCharArray();
char[] charWord2 = word.ToCharArray();
Array.Reverse(charWord2);
string stringWord2 = "";
foreach (char c in charWord2)
{
    stringWord2 += c;
}

//for loop to check if each cahracter matches between 2 lists
for (int i = 0; i < word.Length; i++)
{
    if (charWord[i] != charWord2[i])
    {
        Console.WriteLine("Looks like this is not a palindrome.\n");
        Console.WriteLine($"{word} is not the same as {stringWord2}");
        break;
    }
    else //(charWord[i] == charWord2[i])
    {
        //scan for vowels and output ratio of values in the word
        int vowelCount = 0;
        foreach (char v in charWord)
        {
            if (v == 'a' || v == 'e' || v == 'i' || v == 'o' || v == 'u')
            {
                vowelCount++;
            }
        }
        Console.WriteLine("Congrats, you entered a palindrome.");
        Console.WriteLine($"{word} is the same as {stringWord2} and has {vowelCount} vowels");
        break;
    }
}



Console.ReadKey();


