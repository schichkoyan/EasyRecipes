using System;
using System.IO;

namespace EasyRecipes
{
    public static class Constants
    {
        public static string DbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people.db3");
    }
}
