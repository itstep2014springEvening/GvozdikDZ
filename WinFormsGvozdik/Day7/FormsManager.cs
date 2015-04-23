using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Day7
{
    public static class FormsManager
    {
        static List<Form> forms;
        static FormsManager()
        {
            forms = new List<Form>();
        }
        public static bool Add(Form form)
        {
            Form formAdd = forms.FirstOrDefault(p => p.Tag == form.Tag);
            if (formAdd == null)
            {
                forms.Add(form);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void CloseAll()
        {
            foreach(Form f in forms)
            {
                f.Close();
            }
        }
    }
}
