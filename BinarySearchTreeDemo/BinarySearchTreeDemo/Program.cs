using System;
using System.Collections.Generic;
public class Path
{
    public string CurrentPath { get; private set; }

    public Path(string path)
    {
        this.CurrentPath = path;
    }

    public void Cd(string newPath)
    {
        var commands = newPath.Split('/');

        var path = this.CurrentPath.Split('/');

        Stack<string> s = new Stack<string>();
        foreach(var c in path)
        {
            if(c != "")
                s.Push(c);
        }

        foreach(var c in commands)
        {
            if( c == "..")
            {
                s.Pop();
            }
            else
            {
                s.Push(c);
            }
        }

        string np = "";
        while (s.Count > 0)
        {
            var c = s.Pop();
            np = "/" + c + np;
        }

        if (np == "") np = "/";
        this.CurrentPath = np;
    }

    public static void Main(string[] args)
    {
        Path path = new Path("/a/b/c/d");
        path.Cd("../x");
        Console.WriteLine(path.CurrentPath);
        Console.ReadKey();
    }
}
