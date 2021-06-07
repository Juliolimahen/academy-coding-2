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
        //funcao responsavel por habilitar os campos 
        public static void EnableFields(Control formulario, bool p)
        {
            foreach (Control ctl in formulario.Controls)
            {
                switch (ctl)
                {
                    case TextBox _:
                        ((TextBox)ctl).Enabled = p;
                        break;
                    case DateTimePicker _:
                        ((DateTimePicker)ctl).Enabled = p;
                        break;
                    case MaskedTextBox _:
                        ((MaskedTextBox)ctl).Enabled = p;
                        break;
                    case ComboBox _:
                        ((ComboBox)ctl).Enabled = p;
                        break;
                    default:
                        if (ctl.Controls.Count > 0)
                        {
                            EnableFields(ctl, p);
                        }

                        break;
                }
            }
        }
        //funcao responsavel por liampar formularios 
        public static void Clean(Control formulario)
        {
            foreach (Control ctl in formulario.Controls)
            {
                switch (ctl)
                {
                    case TextBox _:
                        ((TextBox)ctl).Text = "";
                        break;
                    case MaskedTextBox _:
                        ((MaskedTextBox)ctl).Text = "";
                        break;
                    case ComboBox _:
                        ((ComboBox)ctl).SelectedIndex = -1;
                        break;
                    default:
                        if (ctl.Controls.Count > 0)
                        {
                            Clean(ctl);
                        }

                        break;
                }
            }
        }
        //funcao responsavel por habiliatar os botoes 
        public static void EnableButtons(Control formulario, String sit)
        {
            foreach (Control ctl in formulario.Controls)
            {
                switch (ctl)
                {
                    case Button _:
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
                                ((Button)ctl).Enabled = false;
                            }
                        }
                        if (sit == "Load")
                        {
                            if (((Button)ctl).Name == "btnRegInit")
                            {
                                ((Button)ctl).Enabled = true;
                            }
                            else if (((Button)ctl).Name == "btnRegChange")
                            {
                                ((Button)ctl).Enabled = true;
                            }
                            else if (((Button)ctl).Name == "btnRegSave")
                            {
                                ((Button)ctl).Enabled = true;
                            }
                            else if (((Button)ctl).Name == "btnRegDelete")
                            {
                                ((Button)ctl).Enabled = true;
                            }
                            else if (((Button)ctl).Name == "btnRegCancel")
                            {
                                ((Button)ctl).Enabled = false;
                            }
                            else if (((Button)ctl).Name == "btnRegFinish")
                            {
                                ((Button)ctl).Enabled = false;
                            }
                        }
                        break;
                    default:
                        if (ctl.Controls.Count > 0)
                        {
                            EnableButtons(ctl, sit);
                        }

                        break;
                }
            }
        }
        //funÇão resposavel por não permitir a entrada de caracteres indesejaveis 
        public static void EnterNumbers(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || //Letras
                char.IsSymbol(e.KeyChar) || //Símbolos
                char.IsWhiteSpace(e.KeyChar) || //Espaço
                char.IsPunctuation(e.KeyChar)) //Pontuação
                e.Handled = true; //Não permitir

        }
        public static void EnterCurrency(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || //Letras
                char.IsSymbol(e.KeyChar) || //Símbolos
                char.IsWhiteSpace(e.KeyChar)) //Espaço
                e.Handled = true; //Não permitir
        }
    }
}
