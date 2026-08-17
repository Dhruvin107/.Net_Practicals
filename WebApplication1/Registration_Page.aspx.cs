using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class Registration_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void SkillValidator_ServerValidate(
            object source,
            ServerValidateEventArgs args)
        {
            args.IsValid = false;

            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    args.IsValid = true;
                    break;
                }
            }
        }

        protected void CheckValidator_ServerValidate(
            object source,
            ServerValidateEventArgs args)
        {
            args.IsValid = CheckBox1.Checked;
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string name = NameTextBox.Text;
                string department = RadioButtonList1.SelectedValue;
                string eventName = DropDownList1.SelectedValue;
                string gender = RadioButtonList2.SelectedValue;
                string address = TextArea1.Text;
                bool terms = CheckBox1.Checked;

                // Show Data in Page
                SuccessMessage.Text =
                    "Registration Successful!<br/><br/>" +
                    "Name: " + name + "<br/>" +
                    "Department: " + department + "<br/>" +
                    "Event: " + eventName + "<br/>" +
                    "Gender: " + gender + "<br/>" +
                    "Address: " + address + "<br/>" +
                    "Terms Accepted: " + terms;

                SuccessMessage.Visible = true;
            }
            else
            {
                SuccessMessage.Visible = false;
            }
        }
    }
}