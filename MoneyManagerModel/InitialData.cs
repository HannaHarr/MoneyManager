using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Diagnostics;

namespace MoneyManagerModel
{
    public static class InitialData
    {
        public static List<User> Users { get; private set; }
        public static List<Asset> Assets { get; private set; }
        public static List<Category> Categories { get; private set; }
        public static List<Transaction> Transactions { get; private set; }

        static InitialData()
        {
            using (var sr = new StreamReader($"{AppDomain.CurrentDomain.BaseDirectory}/initial_data.json"))
            {
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.Converters.Add(new DateTimeConverter());

                var root = JsonSerializer.Deserialize<Root>(sr.ReadToEnd(), options);

                Users = root.Users;
                Assets = root.Assets;
                Categories = root.Categories;
                Transactions = root.Transactions;
            }
        }

        private class Root
        {
            public List<User> Users { get; set; }
            public List<Asset> Assets { get; set; }
            public List<Category> Categories { get; set; }
            public List<Transaction> Transactions { get; set; }
        }

        private class DateTimeConverter 
            : JsonConverter<DateTime>
        {
            public override DateTime Read(
                ref Utf8JsonReader reader, 
                Type typeToConvert, 
                JsonSerializerOptions options)
            {
                Debug.Assert(typeToConvert == typeof(DateTime));

                var date = reader.GetString().Split('.');

                return new DateTime(
                    int.Parse(date[2]),
                    int.Parse(date[1]), 
                    int.Parse(date[0]));
            }

            public override void Write(
                Utf8JsonWriter writer,
                DateTime value,
                JsonSerializerOptions options) => 
                    writer.WriteStringValue(
                        value.Day.ToString() +
                        '.' + value.Month.ToString() +
                        '.' + value.Year.ToString());
        }
    }
}
