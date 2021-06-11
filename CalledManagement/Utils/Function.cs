using System;
using CalledManagement.EntitiesDAO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalledManagement.Utils
{
    class Function
    {
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
                            if (((Button)ctl).Name == "btnRegInit" || (((Button)ctl).Name == "btnRegInitHours"))
                            {
                                ((Button)ctl).Enabled = false;
                            }
                            else if (((Button)ctl).Name == "btnRegChange" || (((Button)ctl).Name == "btnRegChangeHours"))
                            {
                                ((Button)ctl).Enabled = false;
                            }
                            else if (((Button)ctl).Name == "btnRegSave" || (((Button)ctl).Name == "btnRegInitSaveHours"))
                            {
                                ((Button)ctl).Enabled = true;
                            }
                            else if (((Button)ctl).Name == "btnRegDelete" || (((Button)ctl).Name == "btnRegDeleteHours"))
                            {
                                ((Button)ctl).Enabled = false;
                            }
                            else if (((Button)ctl).Name == "btnRegCancel")
                            {
                                ((Button)ctl).Enabled = true;
                            }
                            else if (((Button)ctl).Name == "btnRegFinish" || (((Button)ctl).Name == "btnRegFinishedHours"))
                            {
                                ((Button)ctl).Enabled = true;
                            }
                            else if (((Button)ctl).Name == "btnSecSearch" || (((Button)ctl).Name == "btnSecSearchHours"))
                            {
                                ((Button)ctl).Enabled = true;
                            }
                        }
                        if (sit == "Change")
                        {
                            if (((Button)ctl).Name == "btnRegInit" || (((Button)ctl).Name == "btnRegInitHours"))
                            {
                                ((Button)ctl).Enabled = false;
                            }
                            else if (((Button)ctl).Name == "btnRegChange" || (((Button)ctl).Name == "btnRegChangeHours"))
                            {
                                ((Button)ctl).Enabled = true;
                            }
                            else if (((Button)ctl).Name == "btnRegSave" || (((Button)ctl).Name == "btnRegInitSaveHours"))
                            {
                                ((Button)ctl).Enabled = false;
                            }
                            else if (((Button)ctl).Name == "btnRegDelete" || (((Button)ctl).Name == "btnRegDeleteHours"))
                            {
                                ((Button)ctl).Enabled = true;
                            }
                            else if (((Button)ctl).Name == "btnRegCancel")
                            {
                                ((Button)ctl).Enabled = true;
                            }
                            else if (((Button)ctl).Name == "btnRegFinish" || (((Button)ctl).Name == "btnRegFinishedHours"))
                            {
                                ((Button)ctl).Enabled = true;
                            }
                            else if (((Button)ctl).Name == "btnSecSearch" || (((Button)ctl).Name == "btnSecSearchHours"))
                            {
                                ((Button)ctl).Enabled = true;
                            }
                        }
                        if (sit == "Init")
                        {
                            if (((Button)ctl).Name == "btnRegInit" || (((Button)ctl).Name == "btnRegInitHours"))
                            {
                                ((Button)ctl).Enabled = true;
                            }
                            else if (((Button)ctl).Name == "btnRegChange" || (((Button)ctl).Name == "btnRegChangeHours"))
                            {
                                ((Button)ctl).Enabled = false;
                            }
                            else if (((Button)ctl).Name == "btnRegSave" || (((Button)ctl).Name == "btnRegInitSaveHours"))
                            {
                                ((Button)ctl).Enabled = false;
                            }
                            else if (((Button)ctl).Name == "btnRegDelete" || (((Button)ctl).Name == "btnRegDeleteHours"))
                            {
                                ((Button)ctl).Enabled = false;
                            }
                            else if (((Button)ctl).Name == "btnRegCancel")
                            {
                                ((Button)ctl).Enabled = false;
                            }
                            else if (((Button)ctl).Name == "btnRegFinishedCalled" || (((Button)ctl).Name == "btnRegFinishedHours"))
                            {
                                ((Button)ctl).Enabled = true;
                            }
                            else if (((Button)ctl).Name == "btnSecSearch" || (((Button)ctl).Name == "btnSecSearchHours"))
                            {
                                ((Button)ctl).Enabled = true;
                            }
                        }
                        if (sit == "Load")
                        {
                            if (((Button)ctl).Name == "btnRegInit" || (((Button)ctl).Name == "btnRegInitHours"))
                            {
                                ((Button)ctl).Enabled = true;
                            }
                            else if (((Button)ctl).Name == "btnRegChange" || (((Button)ctl).Name == "btnRegChangeHours"))
                            {
                                ((Button)ctl).Enabled = true;
                            }
                            else if (((Button)ctl).Name == "btnRegSave" || (((Button)ctl).Name == "btnRegInitSaveHours"))
                            {
                                ((Button)ctl).Enabled = true;
                            }
                            else if (((Button)ctl).Name == "btnRegDelete" || (((Button)ctl).Name == "btnRegDeleteHours"))
                            {
                                ((Button)ctl).Enabled = true;
                            }
                            else if (((Button)ctl).Name == "btnRegCancel")
                            {
                                ((Button)ctl).Enabled = false;
                            }
                            else if (((Button)ctl).Name == "btnRegFinishedCalled" || (((Button)ctl).Name == "btnRegFinishedHours"))
                            {
                                ((Button)ctl).Enabled = true;
                            }
                            else if (((Button)ctl).Name == "btnSecSearch" || (((Button)ctl).Name == "btnSecSearchHours"))
                            {
                                ((Button)ctl).Enabled = true;
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
                    case RadioButton _:
                        ((RadioButton)ctl).Enabled = p;
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
    }
}

