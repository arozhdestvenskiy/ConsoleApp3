// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("start prog");
        NFCReader NFC = new NFCReader();
        Console.WriteLine(NFC.Connect());
        Console.WriteLine(NFC.WriteBlock("try to write", "2"));
        
    }

}
