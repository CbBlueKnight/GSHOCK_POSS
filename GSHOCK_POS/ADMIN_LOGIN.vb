Imports System.Data.SqlClient
Imports System.IO

Public Class ADMIN_LOGIN
    ' Add this at the class level to track password visibility
    Private passwordVisible As Boolean = False
    Private WithEvents eyeIcon As PictureBox

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Validate input fields
        If String.IsNullOrWhiteSpace(TextBox1.Text) Or String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MsgBox("Please enter both username and password", vbExclamation)
            Return
        End If

        Try
            con.Open()
            ' Update your stored procedure call to ensure case sensitivity
            cmd = New SqlCommand("gshock.dbo.login1", con)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@user", TextBox1.Text)
                .Parameters.AddWithValue("@pass", TextBox2.Text)
                .Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output

                .ExecuteNonQuery()

                If CInt(.Parameters("@result").Value) = 1 Then
                    MsgBox("✅ Login successful!", vbInformation)
                    ADMIN_SALES_OVERVIEW.Show()
                    Me.Hide()
                Else
                    MsgBox("❌ Invalid username or password (case-sensitive).", vbCritical)
                    ' Optional: Clear the password field but keep the username for retry
                    TextBox2.Clear()
                    TextBox2.Focus()
                End If
            End With
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            opencon()

            ' Set password masking
            TextBox2.PasswordChar = "●"

            ' Create Eye Icon at right of textbox
            eyeIcon = New PictureBox()
            With eyeIcon
                .Size = New Size(24, 24)
                .SizeMode = PictureBoxSizeMode.StretchImage
                .Location = New Point(TextBox2.Right - 26, TextBox2.Top + (TextBox2.Height - 24) / 2)
                .BackColor = Color.Transparent

                ' Try multiple approaches to load the image
                Try
                    ' Approach 1: Try Application.StartupPath
                    Dim path1 As String = Path.Combine(Application.StartupPath, "Images", "eye.png")

                    ' Approach 2: Try relative path from the executable
                    Dim path2 As String = "Images\eye.png"

                    ' Approach 3: Try path from project directory
                    Dim path3 As String = "..\..\Images\eye.png"

                    ' Try each path in sequence
                    If File.Exists(path1) Then
                        .Image = Image.FromFile(path1)
                        ' Alert which path worked
                        Debug.WriteLine("Used path: " & path1)
                    ElseIf File.Exists(path2) Then
                        .Image = Image.FromFile(path2)
                        Debug.WriteLine("Used path: " & path2)
                    ElseIf File.Exists(path3) Then
                        .Image = Image.FromFile(path3)
                        Debug.WriteLine("Used path: " & path3)
                    Else
                        ' Show message with all attempted paths for debugging
                        Dim message As String = "Could not find image file. Tried:" & vbNewLine &
                                                "1: " & path1 & vbNewLine &
                                                "2: " & path2 & vbNewLine &
                                                "3: " & path3
                        MsgBox(message, vbInformation)

                        ' Fall back to system icon
                        .Image = System.Drawing.SystemIcons.Information.ToBitmap()
                    End If
                Catch ex As Exception
                    ' Log and show error
                    Debug.WriteLine("Error loading image: " & ex.Message)
                    MsgBox("Error loading image: " & ex.Message, vbInformation)

                    ' Fall back to system icon
                    .Image = System.Drawing.SystemIcons.Information.ToBitmap()
                End Try

                .Cursor = Cursors.Hand
            End With
            Me.Controls.Add(eyeIcon)
            eyeIcon.BringToFront()

            con.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message, vbCritical)
        End Try
    End Sub

    ' Event handler for eye icon click - toggle password visibility
    Private Sub eyeIcon_Click(sender As Object, e As EventArgs) Handles eyeIcon.Click
        passwordVisible = Not passwordVisible

        If passwordVisible Then
            TextBox2.PasswordChar = ControlChars.NullChar ' Show the password
        Else
            TextBox2.PasswordChar = "●" ' Hide the password with dots
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        ' Optional: add image behavior here
    End Sub

    ' Keep the focus handlers
    Private Sub Form2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ' Set focus to username field when form loads
        TextBox1.Focus()
    End Sub

    ' Optional: Allow Enter key for login
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
            e.SuppressKeyPress = True ' Prevent the ding sound
        End If
    End Sub

    ' This can be used to handle text changes if needed
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ' The TextBox is already masked with dots through the PasswordChar property
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class