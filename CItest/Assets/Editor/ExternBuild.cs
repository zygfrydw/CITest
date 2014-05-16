using System;
using System.IO;
using UnityEngine;
using System.Collections;

public static class ExternBuild {

    public static void Build()
    {
        var path = GetOuputPath();
        var file = new StreamWriter("test.txt");

        file.WriteLine("Dupa " + path);
        file.Close();
    }

    private static string GetOuputPath()
    {
        var text = System.Environment.CommandLine;
        var args = text.Split(' ');
        var index = Array.IndexOf(args, "-output");
        var path = args[index + 1];
        return path;
    }
}
