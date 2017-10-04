using System;
using System.Text;
using System.Reflection;

public class Spy
{
    public string StealFieldInfo(string className, params string[] namesOfFields)
    {
        var sb = new StringBuilder();

        Type hackerType = Type.GetType(className);

        var classInstansce = Activator.CreateInstance(hackerType, new object[] { });
        sb.AppendLine($"Class under investigation {hackerType.Name}");
        FieldInfo[] info = hackerType.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic);
        foreach (var field in info)
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(classInstansce)}");
        }
        return sb.ToString().Trim();
    }
}

