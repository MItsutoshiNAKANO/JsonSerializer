using System.Text.Json;
using System;
using System.Net;

namespace JsonSerializer
{
    class JsonSerializer
    {
        public static string Serialize<TValue>(TValue value, JsonSerializerOptions options = default)
        {
            return System.Text.Json.JsonSerializer.Serialize<TValue>(value, options);
        }

        static void Main(string[] args)
        {
            Console.Out.WriteLine(Serialize(new WebProxy("http://127.0.0.1:8080/")));
        }
    }
}
