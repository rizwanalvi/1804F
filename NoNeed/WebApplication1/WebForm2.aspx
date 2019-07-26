<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <ajaxToolkit:TextBoxWatermarkExtender ID="TextBox1_TextBoxWatermarkExtender" runat="server" WatermarkText="Search" BehaviorID="TextBox1_TextBoxWatermarkExtender" TargetControlID="TextBox1" />
        <ajaxToolkit:AutoCompleteExtender ID="TextBox1_AutoCompleteExtender" runat="server" 
            BehaviorID="TextBox1_AutoCompleteExtender" 
            DelimiterCharacters=""
            ServicePath="" TargetControlID="TextBox1" ServiceMethod="GetSearch" MinimumPrefixLength="1">
        </ajaxToolkit:AutoCompleteExtender>
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server" Height="21px" Width="154px"></asp:TextBox>
        <ajaxToolkit:MaskedEditExtender ID="TextBox2_MaskedEditExtender" runat="server" BehaviorID="TextBox2_MaskedEditExtender" Century="2000" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Mask="99/99/9999" MaskType="Date" TargetControlID="TextBox2" />
       <br />
         <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
         <ajaxToolkit:PasswordStrength ID="TextBox3_PasswordStrength" runat="server" BehaviorID="TextBox3_PasswordStrength" CalculationWeightings="25;25;15;35" MinimumLowerCaseCharacters="2" MinimumNumericCharacters="1" MinimumSymbolCharacters="1" MinimumUpperCaseCharacters="4" PreferredPasswordLength="6" RequiresUpperAndLowerCaseCharacters="True" StrengthIndicatorType="BarIndicator" StrengthStyles="VeryPoor; Weak; Average; Excellent; Strong" TargetControlID="TextBox3" HelpStatusLabelID="Label1" />
        <asp:Label ID="Label1" runat="server" Font-Bold="true" Font-Size="Medium" ForeColor="Brown"></asp:Label>
         <br />
        <ajaxToolkit:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1" runat="server" TargetControlID="TextBox4" WatermarkText="Select Date" />
        <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" DefaultView="Months" TargetControlID="TextBox4" />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
         <br />
        
         </div>
        <div  class="row">
            <div class="col-md-4">
                </div>
            <div class="col-md-4">
            <div class="form-group">
    <label for="exampleInputEmail1">Email address</label>
                <asp:TextBox ID="TextBox6" runat="server" class="form-control" TextMode="Email"></asp:TextBox>
                <ajaxToolkit:TextBoxWatermarkExtender ID="TextBox6_TextBoxWatermarkExtender" runat="server" BehaviorID="TextBox6_TextBoxWatermarkExtender" TargetControlID="TextBox6" WatermarkText="Enter Your Email Id" />
    <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">Create-Password</label>
      <asp:TextBox ID="TextBox5" runat="server" TextMode="Password" class="form-control"></asp:TextBox>
      <ajaxToolkit:PasswordStrength ID="TextBox5_PasswordStrength" runat="server" BehaviorID="TextBox5_PasswordStrength" MinimumLowerCaseCharacters="2" MinimumNumericCharacters="2" MinimumSymbolCharacters="1" MinimumUpperCaseCharacters="4" PreferredPasswordLength="10" TargetControlID="TextBox5" />
      <ajaxToolkit:TextBoxWatermarkExtender ID="TextBox5_TextBoxWatermarkExtender" runat="server" BehaviorID="TextBox5_TextBoxWatermarkExtender" TargetControlID="TextBox5" WatermarkText="Enter Your Password" />
  </div>
                 <div class="form-group">
    <label for="exampleInputPassword1">Retype-Password</label>
      <asp:TextBox ID="TextBox7" runat="server" TextMode="Password" class="form-control"></asp:TextBox>
      <ajaxToolkit:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender2" runat="server" BehaviorID="TextBox5_TextBoxWatermarkExtender" TargetControlID="TextBox7" WatermarkText="Enter Your Password" />
  </div>
  <div class="form-check">
    <input type="checkbox" class="form-check-input" id="exampleCheck1">
    <label class="form-check-label" for="exampleCheck1">Check me out</label>
  </div>
  <button type="submit" class="btn btn-primary">Register</button>
                </div>
            <div class="col-md-4">
                </div>
        </div>
    </form>
</body>
</html>
