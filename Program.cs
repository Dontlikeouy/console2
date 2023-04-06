using System.Xml;

Console.WriteLine("Hello, World!");
using (XmlReader reader = XmlReader.Create(@"C:\Users\cook\Downloads\dsad.xml"))
{
    while (reader.Read())
    {
        Console.WriteLine($"Type: {reader.NodeType} LocalName: {reader.LocalName}, Value: {reader.Value}");

    }
}

NewNamespace.NewClass.NewMessage();
