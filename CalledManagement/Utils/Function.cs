using System;
using CalledManagement.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalledManagement.Utils
{
    class Function
    {
        public static void EnableFields(Control formulario, bool p)
        {
            foreach (Control ctl in formulario.Controls)
            {
                if (ctl is TextBox)
                {
                    ((TextBox)ctl).Enabled = p;
                }
                else if (ctl is MaskedTextBox)
                {
                    ((MaskedTextBox)ctl).Enabled = p;
                }
                else if (ctl is ComboBox)
                {
                    ((ComboBox)ctl).Enabled = p;
                }
                else if (ctl.Controls.Count > 0)
                {
                    EnableFields(ctl, p);
                }
            }
        }

        public static void Clean(Control formulario)
        {
            foreach (Control ctl in formulario.Controls)
            {
                if (ctl is TextBox)
                {
                    ((TextBox)ctl).Text = "";
                }
                else if (ctl is MaskedTextBox)
                {
                    ((MaskedTextBox)ctl).Text = "";
                }
                else if (ctl is ComboBox)
                {
                    ((ComboBox)ctl).SelectedIndex = -1;
                }
                else if (ctl.Controls.Count > 0)
                {
                    Clean(ctl);
                }
            }
        }

        public static void EnableButtons(Control formulario, String sit)
        {
            foreach (Control ctl in formulario.Controls)
            {
                if (ctl is Button)
                {
                    if (sit == "Save")
                    {
                        if (((Button)ctl).Name == "btnRegInit")
                        {
                            ((Button)ctl).Enabled = false;
                        }
                        else if (((Button)ctl).Name == "btnRegChange")
                        {
                            ((Button)ctl).Enabled = false;
                        }
                        else if (((Button)ctl).Name == "btnRegSave")
                        {
                            ((Button)ctl).Enabled = true;
                        }
                        else if (((Button)ctl).Name == "btnRegDelete")
                        {
                            ((Button)ctl).Enabled = false;
                        }
                        else if (((Button)ctl).Name == "btnRegCancel")
                        {
                            ((Button)ctl).Enabled = true;
                        }
                        else if (((Button)ctl).Name == "btnRegFinish")
                        {
                            ((Button)ctl).Enabled = false;
                        }
                    }
                    if (sit == "Change")
                    {
                        if (((Button)ctl).Name == "btnRegInit")
                        {
                            ((Button)ctl).Enabled = false;
                        }
                        else if (((Button)ctl).Name == "btnRegChange")
                        {
                            ((Button)ctl).Enabled = true;
                        }
                        else if (((Button)ctl).Name == "btnRegSave")
                        {
                            ((Button)ctl).Enabled = false;
                        }
                        else if (((Button)ctl).Name == "btnRegDelete")
                        {
                            ((Button)ctl).Enabled = true;
                        }
                        else if (((Button)ctl).Name == "btnRegCancel")
                        {
                            ((Button)ctl).Enabled = true;
                        }
                        else if (((Button)ctl).Name == "btnRegFinish")
                        {
                            ((Button)ctl).Enabled = false;
                        }
                    }
                    if (sit == "Init")
                    {
                        if (((Button)ctl).Name == "btnRegInit")
                        {
                            ((Button)ctl).Enabled = true;
                        }
                        else if (((Button)ctl).Name == "btnRegChange")
                        {
                            ((Button)ctl).Enabled = false;
                        }
                        else if (((Button)ctl).Name == "btnRegSave")
                        {
                            ((Button)ctl).Enabled = false;
                        }
                        else if (((Button)ctl).Name == "btnRegDelete")
                        {
                            ((Button)ctl).Enabled = false;
                        }
                        else if (((Button)ctl).Name == "btnRegCancel")
                        {
                            ((Button)ctl).Enabled = false;
                        }
                        else if (((Button)ctl).Name == "btnRegFinish")
                        {
                            ((Button)ctl).Enabled = true;
                        }
                    }
                }
                else if (ctl.Controls.Count > 0)
                {
                    EnableButtons(ctl, sit);
                }
            }
        }
        public static void EnterNumbers(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || //Letras
                char.IsSymbol(e.KeyChar) || //Símbolos
                char.IsWhiteSpace(e.KeyChar) || //Espaço
                char.IsPunctuation(e.KeyChar)) //Pontuação
                e.Handled = true; //Não permitir

            /* */
        }
        public static void EnterCurrency(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || //Letras
                char.IsSymbol(e.KeyChar) || //Símbolos
                char.IsWhiteSpace(e.KeyChar)) //Espaço
                e.Handled = true; //Não permitir
        }

        public double CalculateHoursWorked(double hoursWorked)
        {
            HourWorked hw = new HourWorked();
            /*
             desenvolver...
             */
            return hoursWorked;
        }
    }
}
