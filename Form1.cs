using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OWOgeddon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<string> replacements = new List<string>
            {
                #region Bad Words
                "asshole|butt",
                "ass|butt",
                "anal|butt",

                "bitch|female dog",

                "cock|weenie",
                "penis|weenie",
                "dick|weenie",

                "shit|crap",

                "cunt|excuse me?",

                "fuck|fudge",

                "god|science",

                "boner|dog",

                "kill|dog",
                #endregion

                #region NO NEGATIVITY
                "snore|stay completely silent",
                "globe|flat earth",

                "no|yes",
                "no|yes",

                "murder|GOTOSLEEP",

                "hate|like",
                "love|like",
                "dislike|maybe like",
                #endregion

                #region REMOVE ALL MENTIONS OF GENDER LGBT IS NOT FOR LITTLE TIMMY
                "man|person",
                "men|people",
                "him|them",
                "his|their",

                "mother|parent",
                "father|parent",
                "mom|parent",
                "dad|parent",

                "america|south canada",
                "united states|south canada",

                "republic|team",
                "nation|group",

                "liberty|the statue of liberty",
                "justice|jury nullification",

                "stand|sit",

                "soda|water",
                "milk|water",

                "dead|fast asleep",

                "hoe|farming equipment",

                "female|nonbinary",
                "male|nonbinary",
                #endregion

                /*#region EGODEATH
                "i|one",
                "me|them",
                "myself|one's self",
                "my|one's",
                #endregion*/
            };

            Clipboard.SetText(CalculateReplacements(Clipboard.GetText().ToLower(), replacements));


            Application.Exit();
        }

        static string CalculateReplacements(string input, List<string> replacements)
        {
            foreach (string i in replacements)
            {
                string[] splitLine = i.Split('|');
                input = input.Replace(splitLine[0].Trim().Replace("\\n", "\n"), splitLine[1].Trim());
            }
            return input;
        }
    }
}
