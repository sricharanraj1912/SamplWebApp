// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Thread t1 = new Thread(new );
//void Method1()
//{
//    for(int i = 0;i < 100; i++)
//        Console.WriteLine($"method 1 {i}");
//}

//void Method2()
//{
//    for (int i = 0; i < 100; i++)
//        Console.WriteLine($"method 2 {i}");
//}

//Method1();
//Method2();
async Task SimpleTask()
{
    Console.WriteLine("start task");
    await Task.Delay(3000);//force a delay
    Console.WriteLine("task complete");
}
await SimpleTask();
File.WriteAllText(@"SomeFile.txt", "bla dshd dkdns");
async Task <string> ReadFile()
{
    using (StreamReader r = new StreamReader(@"SomeFile.txt"))
    {
        return await r.ReadToEndAsync();
    }
    //using does automatic garbage collection
}
string contents = await ReadFile();
Console.WriteLine(contents);