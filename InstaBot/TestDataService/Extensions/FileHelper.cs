using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TestDataService.Data.UserActivitySection;

namespace TestDataService.Extensions
{
    public static class FileHelper
    {
        public static void SaveJson(List<InstagramUser> usersList, string fileName)
        {
            var saveDialog = new SaveFileDialog
            {
                Filter = "Image Files(.txt)|*.png|All files (*.*)|*.*",
                FileName = $"{fileName}_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt"
            };
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter file = File.CreateText(saveDialog.FileName))
                {
                    var resultsList = usersList.OrderByDescending(u => u.NumberLikes).ToList();

                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, resultsList);
                }
            }
        }

        public static List<InstagramUser> LoadJson()
        {
            List<InstagramUser> usersList = null;

            var open_dialog = new OpenFileDialog
            {
                Filter = "Image Files(*.txt;)|*.txt|All files (*.*)|*.*",
                Multiselect = false
            };
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader stream = new StreamReader(open_dialog.FileName))
                    {
                        usersList = JsonConvert.DeserializeObject<List<InstagramUser>>(stream.ReadToEnd());
                    }
                }
                catch { }
            }

            return usersList;
        }

        public static void SaveText(string fileName, string text)
        {
            using (var file = new StreamWriter(Directory.GetCurrentDirectory() + $"/{fileName}", true))
            {
                file.WriteLine(DateTime.Now.ToString("yyyy-MM-dd") + ": " + text);
            }
        }

        public static int LoadText(string fileName)
        {
            var numberLikesDay = 0;

            if (File.Exists(Directory.GetCurrentDirectory() + $"/{fileName}"))
            {
                var lines = File.ReadAllLines(Directory.GetCurrentDirectory() + $"/{fileName}");

                if (!lines.Any())
                {
                    numberLikesDay = 0;

                    return numberLikesDay;
                }

                char[] charsToTrim = { ' ' };

                foreach (var line in lines)
                {
                    var arrayLine = line.Trim(charsToTrim).Split(':');

                    if (arrayLine[0] == DateTime.Now.ToString("yyyy-MM-dd"))
                    {
                        var numberLikes = short.Parse(arrayLine[1]);
                        if (numberLikes > numberLikesDay)
                        {
                            numberLikesDay = numberLikes;
                        }
                    }
                }
            }
            else
            {
                numberLikesDay = 0;

                SaveText(fileName, numberLikesDay.ToString());
            }

            return numberLikesDay;
        }
    }
}
