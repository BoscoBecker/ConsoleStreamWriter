namespace ConsoleStreamWriter {
    internal abstract class Program {
       private static void Main()
       {
           const string sourcePath = @"C:\temp\File.txt";
           const string targetPath = @"C:\temp\File1.txt";

           try
           {
               var lines = File.ReadAllLines(sourcePath);
               var sw = File.AppendText(targetPath);
               try
               {
                   foreach (var line  in lines)
                   {
                       sw.WriteLine(line.ToUpper());
                   }
               }
               finally
               {
                   sw.Close();
                   sw.Dispose();
               }
           }
           catch (Exception e)
           {
               Console.WriteLine(e);
               throw;
           }

       }
    }
};


