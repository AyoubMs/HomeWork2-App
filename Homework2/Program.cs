


Console.Write("Please enter your age: ");

string ageText = Console.ReadLine();

bool isValid = int.TryParse(ageText, out int age);

Console.WriteLine($"You would be {age + 25} in 25 years, and 25 years ago, you were {age - 25}");