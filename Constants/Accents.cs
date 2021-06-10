using System.Collections.Generic;
using System.Configuration;

namespace Quiccent.Constants
{
    public class Accents
    {
        public Dictionary<string, IList<string>> Mappings { get; set; }

        public Dictionary<string, IList<string>> Mappings_Removed { get; set; }

        public Accents()
        {
            var LowerS = CreateListFromConfig(ConfigurationManager.AppSettings["s_included"].Split(new char[] { ',' }));
            var UpperS = CreateListFromConfig(ConfigurationManager.AppSettings["S_caps_included"].Split(new char[] { ',' }));
            var LowerA = CreateListFromConfig(ConfigurationManager.AppSettings["a_included"].Split(new char[] { ',' }));
            var UpperA = CreateListFromConfig(ConfigurationManager.AppSettings["A_caps_included"].Split(new char[] { ',' }));
            var LowerC = CreateListFromConfig(ConfigurationManager.AppSettings["c_included"].Split(new char[] { ',' }));
            var UpperC = CreateListFromConfig(ConfigurationManager.AppSettings["C_caps_included"].Split(new char[] { ',' }));
            var LowerN = CreateListFromConfig(ConfigurationManager.AppSettings["n_included"].Split(new char[] { ',' }));
            var UpperN = CreateListFromConfig(ConfigurationManager.AppSettings["N_caps_included"].Split(new char[] { ',' }));
            var LowerE = CreateListFromConfig(ConfigurationManager.AppSettings["e_included"].Split(new char[] { ',' }));
            var UpperE = CreateListFromConfig(ConfigurationManager.AppSettings["E_caps_included"].Split(new char[] { ',' }));
            var LowerU = CreateListFromConfig(ConfigurationManager.AppSettings["u_included"].Split(new char[] { ',' }));
            var UpperU = CreateListFromConfig(ConfigurationManager.AppSettings["U_caps_included"].Split(new char[] { ',' }));
            var LowerI = CreateListFromConfig(ConfigurationManager.AppSettings["i_included"].Split(new char[] { ',' }));
            var UpperI = CreateListFromConfig(ConfigurationManager.AppSettings["I_caps_included"].Split(new char[] { ',' }));
            var LowerO = CreateListFromConfig(ConfigurationManager.AppSettings["o_included"].Split(new char[] { ',' }));
            var UpperO = CreateListFromConfig(ConfigurationManager.AppSettings["O_caps_included"].Split(new char[] { ',' }));

            var LowerS_Removed = CreateListFromConfig(ConfigurationManager.AppSettings["s_removed"].Split(new char[] { ',' }));
            var UpperS_Removed = CreateListFromConfig(ConfigurationManager.AppSettings["S_caps_removed"].Split(new char[] { ',' }));
            var LowerA_Removed = CreateListFromConfig(ConfigurationManager.AppSettings["a_removed"].Split(new char[] { ',' }));
            var UpperA_Removed = CreateListFromConfig(ConfigurationManager.AppSettings["A_caps_removed"].Split(new char[] { ',' }));
            var LowerC_Removed = CreateListFromConfig(ConfigurationManager.AppSettings["c_removed"].Split(new char[] { ',' }));
            var UpperC_Removed = CreateListFromConfig(ConfigurationManager.AppSettings["C_caps_removed"].Split(new char[] { ',' }));
            var LowerN_Removed = CreateListFromConfig(ConfigurationManager.AppSettings["n_removed"].Split(new char[] { ',' }));
            var UpperN_Removed = CreateListFromConfig(ConfigurationManager.AppSettings["N_caps_removed"].Split(new char[] { ',' }));
            var LowerE_Removed = CreateListFromConfig(ConfigurationManager.AppSettings["e_removed"].Split(new char[] { ',' }));
            var UpperE_Removed = CreateListFromConfig(ConfigurationManager.AppSettings["E_caps_removed"].Split(new char[] { ',' }));
            var LowerU_Removed = CreateListFromConfig(ConfigurationManager.AppSettings["u_removed"].Split(new char[] { ',' }));
            var UpperU_Removed = CreateListFromConfig(ConfigurationManager.AppSettings["U_caps_removed"].Split(new char[] { ',' }));
            var LowerI_Removed = CreateListFromConfig(ConfigurationManager.AppSettings["i_removed"].Split(new char[] { ',' }));
            var UpperI_Removed = CreateListFromConfig(ConfigurationManager.AppSettings["I_caps_removed"].Split(new char[] { ',' }));
            var LowerO_Removed = CreateListFromConfig(ConfigurationManager.AppSettings["o_removed"].Split(new char[] { ',' }));
            var UpperO_Removed = CreateListFromConfig(ConfigurationManager.AppSettings["O_caps_removed"].Split(new char[] { ',' }));
             
            Mappings = new Dictionary<string, IList<string>>()
            {
                { string.Empty, new string[0] },
                { "s", LowerS },
                { "S", UpperS },
                { "a", LowerA },
                { "A", UpperA },
                { "c", LowerC },
                { "C", UpperC },
                { "n", LowerN },
                { "N", UpperN },
                { "e", LowerE },
                { "E", UpperE },
                { "u", LowerU },
                { "U", UpperU },
                { "i", LowerI },
                { "I", UpperI },
                { "o", LowerO },
                { "O", UpperO }
            };

            Mappings_Removed = new Dictionary<string, IList<string>>()
            {
                { string.Empty, new string[0] },
                { "s", LowerS_Removed },
                { "S", UpperS_Removed },
                { "a", LowerA_Removed },
                { "A", UpperA_Removed },
                { "c", LowerC_Removed },
                { "C", UpperC_Removed },
                { "n", LowerN_Removed },
                { "N", UpperN_Removed },
                { "e", LowerE_Removed },
                { "E", UpperE_Removed },
                { "u", LowerU_Removed },
                { "U", UpperU_Removed },
                { "i", LowerI_Removed },
                { "I", UpperI_Removed },
                { "o", LowerO_Removed },
                { "O", UpperO_Removed }
            };
        }

        public void Save()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings.Remove("s_included");
            config.AppSettings.Settings.Add("s_included", string.Join(",", Mappings["s"]));

            config.AppSettings.Settings.Remove("S_caps_included");
            config.AppSettings.Settings.Add("S_caps_included", string.Join(",", Mappings["S"]));

            config.AppSettings.Settings.Remove("a_included");
            config.AppSettings.Settings.Add("a_included", string.Join(",", Mappings["a"]));

            config.AppSettings.Settings.Remove("A_caps_included");
            config.AppSettings.Settings.Add("A_caps_included", string.Join(",", Mappings["A"]));

            config.AppSettings.Settings.Remove("c_included");
            config.AppSettings.Settings.Add("c_included", string.Join(",", Mappings["c"]));

            config.AppSettings.Settings.Remove("C_caps_included");
            config.AppSettings.Settings.Add("C_caps_included", string.Join(",", Mappings["C"]));

            config.AppSettings.Settings.Remove("n_included");
            config.AppSettings.Settings.Add("n_included", string.Join(",", Mappings["n"]));

            config.AppSettings.Settings.Remove("N_caps_included");
            config.AppSettings.Settings.Add("N_caps_included", string.Join(",", Mappings["N"]));

            config.AppSettings.Settings.Remove("e_included");
            config.AppSettings.Settings.Add("e_included", string.Join(",", Mappings["e"]));

            config.AppSettings.Settings.Remove("E_caps_included");
            config.AppSettings.Settings.Add("E_caps_included", string.Join(",", Mappings["E"]));

            config.AppSettings.Settings.Remove("u_included");
            config.AppSettings.Settings.Add("u_included", string.Join(",", Mappings["u"]));

            config.AppSettings.Settings.Remove("U_caps_included");
            config.AppSettings.Settings.Add("U_caps_included", string.Join(",", Mappings["U"]));

            config.AppSettings.Settings.Remove("i_included");
            config.AppSettings.Settings.Add("i_included", string.Join(",", Mappings["i"]));

            config.AppSettings.Settings.Remove("I_caps_included");
            config.AppSettings.Settings.Add("I_caps_included", string.Join(",", Mappings["I"]));

            config.AppSettings.Settings.Remove("o_included");
            config.AppSettings.Settings.Add("o_included", string.Join(",", Mappings["o"]));

            config.AppSettings.Settings.Remove("O_caps_included");
            config.AppSettings.Settings.Add("O_caps_included", string.Join(",", Mappings["O"]));

            config.AppSettings.Settings.Remove("s_removed");
            config.AppSettings.Settings.Add("s_removed", string.Join(",", Mappings_Removed["s"]));

            config.AppSettings.Settings.Remove("S_caps_removed");
            config.AppSettings.Settings.Add("S_caps_removed", string.Join(",", Mappings_Removed["S"]));

            config.AppSettings.Settings.Remove("a_removed");
            config.AppSettings.Settings.Add("a_removed", string.Join(",", Mappings_Removed["a"]));

            config.AppSettings.Settings.Remove("A_caps_removed");
            config.AppSettings.Settings.Add("A_caps_removed", string.Join(",", Mappings_Removed["A"]));

            config.AppSettings.Settings.Remove("c_removed");
            config.AppSettings.Settings.Add("c_removed", string.Join(",", Mappings_Removed["c"]));

            config.AppSettings.Settings.Remove("C_caps_removed");
            config.AppSettings.Settings.Add("C_caps_removed", string.Join(",", Mappings_Removed["C"]));

            config.AppSettings.Settings.Remove("n_removed");
            config.AppSettings.Settings.Add("n_removed", string.Join(",", Mappings_Removed["n"]));

            config.AppSettings.Settings.Remove("N_caps_removed");
            config.AppSettings.Settings.Add("N_caps_removed", string.Join(",", Mappings_Removed["N"]));

            config.AppSettings.Settings.Remove("e_removed");
            config.AppSettings.Settings.Add("e_removed", string.Join(",", Mappings_Removed["e"]));

            config.AppSettings.Settings.Remove("E_caps_removed");
            config.AppSettings.Settings.Add("E_caps_removed", string.Join(",", Mappings_Removed["E"]));

            config.AppSettings.Settings.Remove("u_removed");
            config.AppSettings.Settings.Add("u_removed", string.Join(",", Mappings_Removed["u"]));

            config.AppSettings.Settings.Remove("U_caps_removed");
            config.AppSettings.Settings.Add("U_caps_removed", string.Join(",", Mappings_Removed["U"]));

            config.AppSettings.Settings.Remove("i_removed");
            config.AppSettings.Settings.Add("i_removed", string.Join(",", Mappings_Removed["i"]));

            config.AppSettings.Settings.Remove("I_caps_removed");
            config.AppSettings.Settings.Add("I_caps_removed", string.Join(",", Mappings_Removed["I"]));

            config.AppSettings.Settings.Remove("o_removed");
            config.AppSettings.Settings.Add("o_removed", string.Join(",", Mappings_Removed["o"]));

            config.AppSettings.Settings.Remove("O_caps_removed");
            config.AppSettings.Settings.Add("O_caps_removed", string.Join(",", Mappings_Removed["O"]));
            
            config.Save();
        }
        
        private IList<string> CreateListFromConfig(string[] configuredValues)
        {
            var newList = new List<string>();

            foreach (var value in configuredValues)
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    newList.Add(value);
                }
            }

            return newList;
        }
    }
}