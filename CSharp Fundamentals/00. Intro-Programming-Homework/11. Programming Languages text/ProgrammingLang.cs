using System;
using System.IO;

class ProgrammingLanguages
{
    static void Main()
    {
        string text = (" C# is an object oriented language, developed by Microsoft. One of the main advantages is that C# is just a language targeting CLR... thus, I think the advantages mainly result from .net framework.\r\n C++ is and part object part process oriented language. It's a low level language, thus You can use it to write code for embeded devices.\r\n JaveScript is a multiparadigm language that supports object-orienting, imperative and funcional programming styles. It is one of the 3 backbone languages of the internet alongside with HTML and CSS.");
        File.WriteAllText("output.txt", text);
    }
}


