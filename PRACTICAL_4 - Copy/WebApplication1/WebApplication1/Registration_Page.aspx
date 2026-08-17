<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration_Page.aspx.cs" Inherits="WebApplication1.Registration_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Page</title>
</head>

<body>

    <form id="form1" runat="server">

        <div>

            <asp:Label
                ID="NameLabel"
                runat="server"
                Text="Name">
            </asp:Label>

            <asp:TextBox
                ID="NameTextBox"
                runat="server">
            </asp:TextBox>

            <asp:RequiredFieldValidator
                ID="NameValidator"
                runat="server"
                ControlToValidate="NameTextBox"
                ErrorMessage="Name Is Required"
                ForeColor="Red">
            </asp:RequiredFieldValidator>

            <br />
            <br />


            <asp:Label
                ID="DepartmentLabel"
                runat="server"
                Text="Department">
            </asp:Label>

            <asp:RadioButtonList
                ID="RadioButtonList1"
                runat="server">

                <asp:ListItem
                    Text="Computer"
                    Value="Computer">
                </asp:ListItem>

                <asp:ListItem
                    Text="Electronics"
                    Value="Electronics">
                </asp:ListItem>

                <asp:ListItem
                    Text="Mechanical"
                    Value="Mechanical">
                </asp:ListItem>

                <asp:ListItem
                    Text="Civil"
                    Value="Civil">
                </asp:ListItem>

            </asp:RadioButtonList>

            <asp:RequiredFieldValidator
                ID="DepartmentValidator"
                runat="server"
                ControlToValidate="RadioButtonList1"
                ErrorMessage="Department Is Required"
                ForeColor="Red">
            </asp:RequiredFieldValidator>

            <br />
            <br />


            <asp:Label
                ID="EventLabel"
                runat="server"
                Text="Event">
            </asp:Label>

            <asp:DropDownList
                ID="DropDownList1"
                runat="server">

                <asp:ListItem
                    Text="Select Event"
                    Value="">
                </asp:ListItem>

                <asp:ListItem
                    Text="Coding"
                    Value="Coding">
                </asp:ListItem>

                <asp:ListItem
                    Text="Quiz"
                    Value="Quiz">
                </asp:ListItem>

                <asp:ListItem
                    Text="Project"
                    Value="Project">
                </asp:ListItem>

            </asp:DropDownList>

            <asp:RequiredFieldValidator
                ID="EventValidator"
                runat="server"
                ControlToValidate="DropDownList1"
                InitialValue=""
                ErrorMessage="Event Is Required"
                ForeColor="Red">
            </asp:RequiredFieldValidator>

            <br />
            <br />



            <asp:Label
                ID="GenderLabel"
                runat="server"
                Text="Gender">
            </asp:Label>

            <asp:RadioButtonList
                ID="RadioButtonList2"
                runat="server">

                <asp:ListItem
                    Text="Male"
                    Value="Male">
                </asp:ListItem>

                <asp:ListItem
                    Text="Female"
                    Value="Female">
                </asp:ListItem>

                <asp:ListItem
                    Text="Other"
                    Value="Other">
                </asp:ListItem>

            </asp:RadioButtonList>

            <asp:RequiredFieldValidator
                ID="GenderValidator"
                runat="server"
                ControlToValidate="RadioButtonList2"
                ErrorMessage="Gender Is Required"
                ForeColor="Red">
            </asp:RequiredFieldValidator>

            <br />
            <br />



            <asp:Label
                ID="SkillLabel"
                runat="server"
                Text="Skill">
            </asp:Label>

            <asp:CheckBoxList
                ID="CheckBoxList1"
                runat="server">

                <asp:ListItem
                    Text="C#"
                    Value="C#">
                </asp:ListItem>

                <asp:ListItem
                    Text="Java"
                    Value="Java">
                </asp:ListItem>

                <asp:ListItem
                    Text="Python"
                    Value="Python">
                </asp:ListItem>

                <asp:ListItem
                    Text="JavaScript"
                    Value="JavaScript">
                </asp:ListItem>

            </asp:CheckBoxList>

            <asp:CustomValidator
                ID="SkillValidator"
                runat="server"
                ErrorMessage="Skill Is Required"
                ForeColor="Red"
                OnServerValidate="SkillValidator_ServerValidate">
            </asp:CustomValidator>

            <br />
            <br />
            

            <asp:Label
                ID="AddressLabel"
                runat="server"
                Text="Address">
            </asp:Label>

            <br />

            <asp:TextBox
                ID="TextArea1"
                runat="server"
                TextMode="MultiLine"
                Columns="20"
                Rows="3">
            </asp:TextBox>

            <asp:RequiredFieldValidator
                ID="AddressValidator"
                runat="server"
                ControlToValidate="TextArea1"
                ErrorMessage="Address Is Required"
                ForeColor="Red">
            </asp:RequiredFieldValidator>

            <br />
            <br />

            <asp:CheckBox
                ID="CheckBox1"
                runat="server"
                Text="I agree to the terms and conditions"></asp:CheckBox>

            <asp:CustomValidator
                ID="CheckValidator"
                runat="server"
                ErrorMessage="CheckBox Is Required"
                ForeColor="Red"
                OnServerValidate="CheckValidator_ServerValidate">
            </asp:CustomValidator>

            <br />
            <br />

            <asp:Button
                ID="SubmitButton"
                runat="server"
                Text="Submit"
                OnClick="SubmitButton_Click"></asp:Button>

            <br />

            <asp:Label
                ID="SuccessMessage"
                runat="server"
                Text="Registration Successful!"
                ForeColor="Green"
                Visible="False">
            </asp:Label>

        </div>

    </form>

</body>
</html>
