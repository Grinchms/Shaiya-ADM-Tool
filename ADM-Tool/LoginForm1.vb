﻿



Public Class LoginForm1


    ' TODO: Code zum Durchführen der benutzerdefinierten Authentifizierung mithilfe des angegebenen Benutzernamens und des Kennworts hinzufügen 
    ' (Siehe http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' Der benutzerdefinierte Prinzipal kann anschließend wie folgt an den Prinzipal des aktuellen Threads angefügt werden: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' wobei CustomPrincipal die IPrincipal-Implementierung ist, die für die Durchführung der Authentifizierung verwendet wird. 
    ' Anschließend gibt My.User Identitätsinformationen zurück, die in das CustomPrincipal-Objekt gekapselt sind,
    ' z.B. den Benutzernamen, den Anzeigenamen usw.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT * FROM ADM_Tool.dbo.Account WHERE Benutzer = '" & UsernameTextBox.Text & "' AND Passwort = '" & PasswordTextBox.Text & "' AND Rechte > '15' " &
                                                                             "INSERT INTO ADM_Tool.dbo.Login ([UserID],[Password],[IP],[Date]) VALUES ('" & UsernameTextBox.Text & "','" & PasswordTextBox.Text & "','127.0.0.1',DATEADD(year, +0, GETDATE()) )", con)

        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()

        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            MessageBox.Show("Herzlich Willkommen, du hast dich erfolgreich eingeloggt.")
            Dim mainForm As New Main
            Main.Show()
            Me.Hide()
        Else
            MessageBox.Show("Benutzername oder Password Falsch oder die fehlenden Berechtigungen!")
            con.Close()
        End If
        Main.TextBox1.Text = UsernameTextBox.Text


    End Sub

    Private Sub Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


End Class