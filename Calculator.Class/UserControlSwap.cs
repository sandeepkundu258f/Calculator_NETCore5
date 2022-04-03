using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Class
{
    public static class UserControlSwap
    {
        public static void SwapControl<T>(string ControlName, string ParentTitle, UserControl CurrentUC) where T : UserControl, new()
        {
            bool isCurrentActive = CurrentUC.Parent.Controls.ContainsKey(ControlName);

            if (!isCurrentActive)
            {
                foreach (string control in Constants.allControls)
                {
                    CurrentUC.Parent.Controls.RemoveByKey(control);
                }

                T newControl = new T();
                newControl.Location = new System.Drawing.Point(1, 32);
                newControl.Name = ControlName;
                newControl.Size = new System.Drawing.Size(410, 377);
                newControl.TabIndex = 1;

                CurrentUC.Parent.Text = ParentTitle;
                CurrentUC.Parent.Controls.Add(newControl);

                Control CurrentNewControl = CurrentUC.Parent.Controls.Find(ControlName, false)[0];
                CurrentNewControl.Focus();
            }
        }
    }
}
