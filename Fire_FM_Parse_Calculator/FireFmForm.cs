using Fire_FM_Parse_Calculator.Extensions;
using Fire_FM_Parse_Calculator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fire_FM_Parse_Calculator
{
    public partial class FireFmForm : Form
    {
        public FireFmForm()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            var validateResult = ValidateForm();

            if (!validateResult.isValid)
            {
                var output = string.Join("\r\n", validateResult.errors);
                MessageBox.Show(output, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var fireFmParse = new FireFMParseModel(timeMins.Text.ToInt(), timeSecs.Text.ToInt())
                {
                    BlazingBeams = bbCount.Text.ToInt(),
                    BlazingPalms = bpCount.Text.ToInt(),
                    Dragonblazes = dbCount.Text.ToInt(),
                    DualDragons = ddCount.Text.ToInt(),
                    FrostPalms = fpCount.Text.ToInt(),
                    SmoulderingAsh = saCount.Text.ToInt(),
                    Impacts = impCount.Text.ToInt(),
                    Infernos = infCount.Text.ToInt(),
                    MeteorShowers = msCount.Text.ToInt(),
                    ShortFuses = sfCount.Text.ToInt()
                };

                var parseResults = fireFmParse.CalculateParse();

                var output = string.Join("\r\n", parseResults.Select(x => x.ToString()));

                var parseForm = new ParseMessage(output);
                parseForm.ShowDialog();
            }
        }

        private void textbox_OnFocus(object sender, EventArgs e)
        {
            var tbox = (TextBox)sender;

            tbox.SelectAll();
        }

        private (bool isValid, List<string> errors) ValidateForm()
        {
            var valid = true;
            var errors = new List<string>();

            if (!IsNumber(timeMins.Text))
            {
                valid = false;
                errors.Add("Minutes field must be a valid number.");
            }

            if (!IsNumber(timeSecs.Text))
            {
                valid = false;
                errors.Add("Seconds field must be a valid number.");
            }

            if (!IsNumber(bbCount.Text))
            {
                valid = false;
                errors.Add("Blazing Beam field must be a valid number.");
            }

            if (!IsNumber(infCount.Text))
            {
                valid = false;
                errors.Add("Inferno field must be a valid number.");
            }

            if (!IsNumber(saCount.Text))
            {
                valid = false;
                errors.Add("Smouldering Ash field must be a valid number.");
            }

            if (!IsNumber(msCount.Text))
            {
                valid = false;
                errors.Add("Meteor Shower field must be a valid number.");
            }

            if (!IsNumber(bpCount.Text))
            {
                valid = false;
                errors.Add("Blazing Palm field must be a valid number.");
            }

            if (!IsNumber(fpCount.Text))
            {
                valid = false;
                errors.Add("Frost Palm field must be a valid number.");
            }

            if (!IsNumber(ddCount.Text))
            {
                valid = false;
                errors.Add("Dual Dragons field must be a valid number.");
            }

            if (!IsNumber(dbCount.Text))
            {
                valid = false;
                errors.Add("Dragonblaze field must be a valid number.");
            }

            if (!IsNumber(impCount.Text))
            {
                valid = false;
                errors.Add("Impact field must be a valid number.");
            }

            if (!IsNumber(sfCount.Text))
            {
                valid = false;
                errors.Add("Short Fuse field must be a valid number.");
            }

            return (isValid: valid, errors: errors);
        }

        private bool IsNumber(string str)
        {
            return Regex.IsMatch(str, "^[0-9]+$");
        }
    }
}
