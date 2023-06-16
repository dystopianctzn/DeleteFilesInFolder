//путь
DirectoryInfo folder = new DirectoryInfo(@"C:\1");

try
{
    if (folder.Exists)
    {
        foreach (FileInfo file in folder.GetFiles())
        {
            if (file.LastAccessTime < DateTime.Now.AddMinutes(-30))
                file.Delete();
        }


        foreach (DirectoryInfo dir in folder.GetDirectories())
        {
            if (dir.LastAccessTime < DateTime.Now.AddMinutes(-30))
                dir.Delete(true);
        }
    }

    else
        Console.WriteLine("Такой папки не существует");
}
catch (Exception ex)
{
    Console.WriteLine("Произошла ошибка: " + ex.Message);
}