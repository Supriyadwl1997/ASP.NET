using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default :System.Web.UI.Page
{
SqlConnection con= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachSbFilename=C:\learning.mdf;Integrated Security=True");
protected void Page_Load(object sender, EvenetArgs e)
{
if (con.State==ConnectionState.Open)
{
con.close()
}
con.Open();
}

protected void Button1_Click(object sender, EvenetArgs e)
{
SQLCommand cmd=con.CreateCommand();
cmdCommandType=CommandType.Text;
cmd.CommandText="insert into student values ('"+ firstname.Text +"','"+ LastName.Text +"','"+ ClassName.Text +"','"+ Rollno.Text +"','"+ Percentage.Text +"',)";
cmd.ExecuteNonQuery();
firstname.Text="";
LastName.Text="";
ClassName.Text="";
Rollno.Text="";
Percentage.Text="";
}

protected void Button2_Click(object sender, EvenetArgs e)
{
SQLCommand cmd=con.CreateCommand();
cmdCommandType=CommandType.Text;
cmd.CommandText="Select * from student where firstname='"+ firstname.Text +"' and lastname='"+ LastName.Text +"' and classname='"+ ClassName.Text +"'";
cmd.ExecuteNonQuery();
firstname.Text="";
LastName.Text="";
ClassName.Text="";

}

}