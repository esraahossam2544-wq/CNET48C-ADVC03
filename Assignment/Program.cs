// See https://aka.ms/new-console-template for more information
#region Ex01

//List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

//Console.WriteLine("Grades: " + string.Join(", ", grades));
//Console.WriteLine("Count: " + grades.Count);
//Console.WriteLine("First: " + grades.First());
//Console.WriteLine("Last: " + grades.Last());
//grades.Sort();
//Console.WriteLine("Sorted Ascending: " + string.Join(", ", grades));
//int firstAbove90 = grades.First(g => g > 90);
//Console.WriteLine("First grade above 90: " + firstAbove90);
//List<int> failingGrades = grades.Where(g => g < 75).ToList();
//Console.WriteLine("Failing grades: " + string.Join(", ", failingGrades));
//grades.RemoveAll(g => g < 75);
//Console.WriteLine("After removing failing grades: " + string.Join(", ", grades));
//bool hasPerfectScore = grades.Any(g => g == 100);
//Console.WriteLine("Contains a 100: " + hasPerfectScore);
//List<string> formattedGrades = grades.Select(g => $"Grade: {g}").ToList();
//Console.WriteLine("Formatted:");
//foreach (var g in formattedGrades)
//    Console.WriteLine(g);
#endregion
#region Ex02
//SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>
//        {
//            { 500, "Ahmed" },
//            { 200, "Sara" },
//            { 800, "Ali" },
//            { 350, "Mona" }
//        };

//Console.WriteLine("Leaderboard:");
//foreach (var entry in leaderboard)
//    Console.WriteLine($"{entry.Key} = {entry.Value}");

//var first = leaderboard.First(); 
//Console.WriteLine($"First Key: {first.Key}, First Value: {first.Value}");

//bool exists500 = leaderboard.ContainsKey(500);
//Console.WriteLine("Score 500 exists: " + exists500);
//if (leaderboard.TryGetValue(999, out string player999))
//    Console.WriteLine("Score 999: " + player999);
//else
//    Console.WriteLine("No player with score 999");
//leaderboard.Remove(200);
//Console.WriteLine("After removing score 200:");
//foreach (var entry in leaderboard)
//    Console.WriteLine($"{entry.Key} = {entry.Value}");
#endregion
#region Ex03
//Dictionary<string, string> phoneBook = new Dictionary<string, string>
//        {
//            { "Ahmed", "01001234567" },
//            { "Sara", "01112345678" },
//            { "Ali", "01223456789" },
//            { "Mona", "01098765432" }
//        };

//phoneBook["Omar"] = "01234567890"; 

//try
//{
//    phoneBook.Add("Ahmed", "01111111111");
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine("Error: " + ex.Message);
//}

//bool added = phoneBook.TryAdd("Sara", "01199999999");
//Console.WriteLine("TryAdd Sara succeeded: " + added);

//bool found = phoneBook.ContainsKey("Youssef");
//Console.WriteLine("Youssef exists: " + found);

//string number = phoneBook.TryGetValue("Youssef", out string val) ? val : "Not Found";
//Console.WriteLine("Youssef's number: " + number);
//Console.WriteLine("Keys: " + string.Join(", ", phoneBook.Keys));
//Console.WriteLine("Values: " + string.Join(", ", phoneBook.Values));
#endregion
#region Ex04
//HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

//emails.Add("ahmed@test.com");
//emails.Add("AHMED@test.com");   
//emails.Add("sara@test.com");
//emails.Add("Sara@Test.com");  
//Console.WriteLine("Count: " + emails.Count);

//bool exists = emails.Contains("AHMED@TEST.COM");
//Console.WriteLine("AHMED@TEST.COM exists: " + exists);

//bool wasAdded = emails.Add("ahmed@Test.Com");
//Console.WriteLine("Adding ahmed@Test.Com succeeded: " + wasAdded);

//bool addedNew = emails.Add("mona@test.com");
//Console.WriteLine("Adding mona@test.com succeeded: " + addedNew); 

//emails.Remove("sara@test.com");

//Console.WriteLine("Remaining emails:");
//foreach (var email in emails)
//    Console.WriteLine(email);
#endregion
