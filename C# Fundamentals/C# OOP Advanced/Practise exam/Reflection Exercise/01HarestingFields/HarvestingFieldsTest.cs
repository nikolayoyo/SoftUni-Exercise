namespace _01HarestingFields
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    class HarvestingFieldsTest
    {
        static void Main(string[] args)
        {
            var allFields = typeof(HarvestingFields).GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            var sortedFields = new Dictionary<string, FieldInfo[]>()
            {
                {"protected", allFields.Where(f=> f.IsFamily).ToArray()},
                {"public", allFields.Where(f=> f.IsPublic).ToArray() },
                {"private", allFields.Where(f=>f.IsPrivate).ToArray() },
                {"all", allFields }
            };

            string cmdInput;
            while ((cmdInput=Console.ReadLine())!="HARVEST")
            {
                foreach (var field in sortedFields[cmdInput])
                {
                    Console.WriteLine($"{field.Attributes.ToString().ToLower().Replace("family", "protected")} {field.FieldType.Name} {field.Name}");
                }
            }
        }
    }
}
