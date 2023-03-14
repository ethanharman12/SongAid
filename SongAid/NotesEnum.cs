using System;
using System.ComponentModel;

namespace SongAid
{
    public enum Note
    {
        A = 45,
        [Description("As/Bf")]
        As = 50,
        B = 55,
        C = 0,
        [Description("Cs/Df")]
        Cs = 5,
        D = 10,
        [Description("Ds/Ef")]
        Ds = 15,
        E = 20,
        F = 25,
        [Description("Fs/Gf")]
        Fs = 30,
        G = 35,
        [Description("Gs/Af")]
        Gs = 40
    }

    public static class NotesHelper
    {
        public static string GetName(this Enum enumVal)
        {
            var type = enumVal.GetType();
            var memInfo = type.GetMember(enumVal.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
            return (attributes.Length > 0) ? ((DescriptionAttribute)attributes[0]).Description.Replace('s', '\u266F').Replace('f', '\u266D') : enumVal.ToString();
        }

        public static string GetFrequency(this Enum enumVal)
        {
            var type = enumVal.GetType();
            var memInfo = type.GetMember(enumVal.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
            return (attributes.Length > 0) ? ((DescriptionAttribute)attributes[0]).Description.Replace('s', '\u266F').Replace('f', '\u266D') : enumVal.ToString();
        }
    }
}
