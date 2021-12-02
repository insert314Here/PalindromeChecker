//read console line to get a word to check
// convert to char array
//reverse the word
//match case

//is the original string the same value as the reveresed string
string str = Console.ReadLine();
char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);

int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");