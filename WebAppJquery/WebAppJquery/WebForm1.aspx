<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppJquery.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <title></title>
    <script src="scripts/jquery-3.4.1.js" ></script>
    <script>
        $(function () {
            $('btnChange').click(function () {
                $('p').addClass('bg-danger');
                alert('');

            });
            $('#btnClick').click(function () {
                $('#divData').fadeToggle(2000);
                //alert("ok");
                var data = $(this).val();

                switch (data) {
                    case 'Hide':
                        $(this).val('Show');
                        break;

                    case 'Show':
                        $(this).val('Hide');
                        break;
                    default:
                }
               
            });

            });
      
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <div class="bg-warning" id="divData">
             <p>
                 Be sure to have your pages set up with the latest design and development standards. That means using an HTML5 doctype and including a viewport meta tag for proper responsive behaviors. Put it all together and your pages should look like this:
             </p>

         </div>
        <input type="button" name="name" id="btnClick" value="Hide" class="btn btn-sm btn-success" />

         <input type="button" name="name" id="btnChange" value="Change" class="btn btn-sm btn-success" />
        
    </div>
    </form>
</body>
</html>
