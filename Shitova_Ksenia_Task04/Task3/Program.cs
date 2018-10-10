using System;
using System.Globalization;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringResult = String.Empty;
            stringResult += GetLocaleDifferences(CultureInfo.CreateSpecificCulture("ru-RU"), CultureInfo.CreateSpecificCulture("en-US"));
            stringResult += GetLocaleDifferences(CultureInfo.CreateSpecificCulture("en-US"), CultureInfo.InvariantCulture);
            stringResult += GetLocaleDifferences(CultureInfo.CreateSpecificCulture("ru-RU"), CultureInfo.InvariantCulture);
            Console.WriteLine(stringResult);
            Console.ReadLine();
        }

        public static string GetLocaleDifferences(CultureInfo culture1, CultureInfo culture2)
        {
            string result = String.Empty;
            DateTime date = new DateTime(2018, 10, 9, 13, 24, 10);
            double number = 12.433;
            result += $"Date: in {culture1}: \"{ date.ToString(culture1)}\"; in {culture2}: \"{ date.ToString(culture2)}\"\r\n";
            result += $"Date separator: in {culture1}: \"{culture1.DateTimeFormat.DateSeparator}\"; in {culture2}: \"{culture2.DateTimeFormat.DateSeparator}\"\r\n";
            result += $"Time separator: in {culture1}: \"{culture1.DateTimeFormat.TimeSeparator}\"; in {culture2}: \"{culture2.DateTimeFormat.TimeSeparator}\"\r\n";
            result += $"Full date time pattern:\r\n in {culture1}: \"{culture1.DateTimeFormat.FullDateTimePattern}\";\r\n in {culture2}: \"{culture2.DateTimeFormat.FullDateTimePattern}\"\r\n";
            result += $"Number: in {culture1}: \"{ number.ToString(culture1)}\"; in {culture2}: \"{ number.ToString(culture2)}\"\r\n";
            result += $"Number decimal separator: in {culture1}: \"{culture1.NumberFormat.NumberDecimalSeparator}\"; in {culture2}: \"{culture2.NumberFormat.NumberDecimalSeparator}\"\r\n";
            result += $"Number group separator: in {culture1}: \"{culture1.NumberFormat.NumberGroupSeparator}\"; in {culture2}: \"{culture2.NumberFormat.NumberGroupSeparator}\"\r\n\r\n";
            return result;
        }
    }
}
