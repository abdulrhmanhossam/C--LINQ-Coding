namespace CAAttributes
{
    class UpdateProcessor
    {
        
        [Obsolete("this method will not be supported in the next release consider using" +
            "DownloadAndInstall() instead", false)]
        public static void Download(Update[] updates)
        {
            for (int i = 0; i < updates.Length; i++)
            {
                Console.WriteLine($"Downloading {updates[i]}");
                Thread.Sleep(750);
            }
        }

        [Obsolete("this method will not be supported in the next release consider using" +
            "DownloadAndInstall() instead", false)] 
        public static void Install(Update[] updates)
        {
            for (int i = 0; i < updates.Length; i++)
            {
                Console.WriteLine($"Installing {updates[i]}");
                Thread.Sleep(750);
            }
        }

        public static void DownloadAndInstall(Update[] updates)
        {
            for (int i = 0; i < updates.Length; i++)
            {
                Console.WriteLine($"Downloading {updates[i]}");
                Thread.Sleep(750);
                Console.WriteLine($"Installing {updates[i]}");
                Thread.Sleep(750);
            }
        }
    }
}
