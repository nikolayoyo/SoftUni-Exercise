using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Emergency_Skeleton.Enums;
using Emergency_Skeleton.Models;
using Emergency_Skeleton.Utils;

namespace Emergency_Skeleton.Factories
{
    public static class EmergencyFactory
    {
        public static BaseEmergency Get(string value)  //RegisterPropertyEmergency|Test|Minor|12:24 
        {
            var corectNamespace = $"Emergency_Skeleton.Models.Emergencies";
            var args = value.Split('|');

            var exactClassName = args[0].Replace("Register", "Public");
            var name = args[1];
            var level = Enum.Parse(typeof(EmergencyLevel), args[2]);
            var timeRegistered = new RegistrationTime(args[3]);
            var emergencyType =Enum.Parse(typeof(ServiceAndEmergencyType), args[0].Replace("Register", string.Empty).Replace("Emergency", string.Empty));

            var type = Type.GetType($"{corectNamespace}.{exactClassName}");
            return (BaseEmergency)Activator.CreateInstance(type, new[] {name, emergencyType, level, timeRegistered, args[4]});
        }
    }
}
