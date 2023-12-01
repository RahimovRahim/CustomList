CustomList<int> customlist = new CustomList<int>();

customlist.Add(5);
customlist.Add(10);
customlist.Add(15);
customlist.Add(20);
customlist.Add(100);



customlist.Remove(3);
customlist.Remove(4);
Console.WriteLine( customlist.Count);


//Console.WriteLine(customlist.Capacity);
//Console.WriteLine(customlist.Count);
