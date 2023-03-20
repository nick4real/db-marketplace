using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace Amafun
{
    internal class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        private static int tempIndex;

        public static List<string> ColorList = new List<string>() { "#3F51B5",
                                                                    "#009688",
                                                                    "#FF5722",
                                                                    "#607D8B",
                                                                    "#FF9800",
                                                                    "#9C27B0",
                                                                    "#2196F3",
                                                                    "#EA676C",
                                                                    "#E41A4A",
                                                                    "#5978BB",
                                                                    "#018790",
                                                                    "#0E3441",
                                                                    "#00B0AD",
                                                                    "#721D47",
                                                                    "#EA4833",
                                                                    "#EF937E",
                                                                    "#F37521",
                                                                    "#A12059",
                                                                    "#126881",
                                                                    "#8BC240",
                                                                    "#364D5B",
                                                                    "#C7DC5B",
                                                                    "#0094BC",
                                                                    "#E4126B",
                                                                    "#43B76E",
                                                                    "#7BCFE9",
                                                                    "#B71C46"};
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
        public static void GenerateTheme()
        {
            Random random = new Random();
            int index = random.Next(ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ColorList.Count);
            }
            tempIndex = index;
            Color color = ColorTranslator.FromHtml(ColorList[index]);
            PrimaryColor = color;
            SecondaryColor = ChangeColorBrightness(color, -0.3);
        }
        public static void UpdateColor()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT `color_theme` FROM `settings` WHERE `user_login` = @ul ", db.getConnection());

            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = MainForm.userLogin;
            command.CommandType = CommandType.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.OpenConnection();
            object input = command.ExecuteScalar();
            db.CloseConnection();
            if (input != null)
            {
                MainForm.userTheme = Convert.ToString(input);
            }
            else
            {
                MainForm.userTheme = "Random";
            }
        }
    }
}
