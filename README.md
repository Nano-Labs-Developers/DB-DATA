# DB-DATA 

###### Application Details

#### About this application
- Using C# and SQL database
- Simple login applied
- Form Student


##### [1.](sql-connection) SQL Connection
```
SqlConnection con = new SqlConnection(@"Data Source = <here user_name[PC_name]>; Initial Catalog = StudentDB; Integrated Security = True");
```
*Ex:*
```
SqlConnection con = new SqlConnection(@"Data Source = ASUS; Initial Catalog = StudentDB; Integrated Security = True");
```

##### [2.](database) Database Deatils

##### [2.1.](database-select) Database - Select Data
```C#
string query_search = "SELECT * FROM Teacher WHERE email = '" + u_email + "'";
```

##### [2.2.](database-insert) Database - Insert Data
```C#
string query_insert = "INSERT INTO FormLoginData VALUES('" + user_name+ "','" +password+ "','" +role+ "','"+ usertype  + "')";
```

##### [2.2.](database-update) Database - Update Data
```C#
string updatesql = "UPDATE Student SET firstname='" + fname + "',email='" + email + "',tp='" + tel + "',gender='" + gender + "',grade='" + grade + "' where email='" + email + "'";
```

##### [2.2.](database-delete) Database - Delete Data
```C#
string deletesql = "DELETE FROM Teacher WHERE email='" + email + "'";
```

##### [3.](form-movement) Form Movement Handle
###### *Example Only*
```C#
[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
private extern static void ReleaseCapture();
[DllImport("user32.DLL", EntryPoint = "SendMessage")]
private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

private void Headerpanel_MouseDown(object sender, MouseEventArgs e)
{
    ReleaseCapture();
    SendMessage(this.Handle,0x112,0xf012,0);
}
```

