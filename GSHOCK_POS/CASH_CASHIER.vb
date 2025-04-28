Public Class CARD_CASHIER
    ' Event when the form is loaded
    Private Sub CARD_CASHIER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Any initialization code can go here, such as clearing fields
    End Sub

    ' Validate Debit Card Information on Submit
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Validate the Card Number (16 digits)
        If Not IsValidCardNumber(txtCardNumber.Text) Then
            MessageBox.Show("Invalid card number. Please enter a 16-digit card number.", "Invalid Card Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate Expiry Date (MM/YY format)
        If Not IsValidExpiryDate(txtExpiryDate.Text) Then
            MessageBox.Show("Invalid expiry date. Please enter in MM/YY format and ensure the year is valid.", "Invalid Expiry Date", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate CVV (3 digits)
        If Not IsValidCVV(txtCVV.Text) Then
            MessageBox.Show("Invalid CVV. Please enter a 3-digit CVV.", "Invalid CVV", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate Cardholder Name (cannot be empty, only letters, and convert to uppercase)
        If String.IsNullOrWhiteSpace(txtCardholderName.Text) OrElse Not txtCardholderName.Text.All(AddressOf Char.IsLetter) Then
            MessageBox.Show("Please enter a valid cardholder's name (letters only).", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        ' Ensure the cardholder name is always in uppercase
        txtCardholderName.Text = txtCardholderName.Text.ToUpper()

        ' If everything is valid, show a success message
        MessageBox.Show("Card details are valid. Proceeding with payment.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Function to validate Card Number (16 digits, only numbers)
    Private Function IsValidCardNumber(cardNumber As String) As Boolean
        Return cardNumber.Length = 16 AndAlso cardNumber.All(AddressOf Char.IsDigit)
    End Function

    ' Function to validate Expiry Date (MM/YY format)
    Private Function IsValidExpiryDate(expiryDate As String) As Boolean
        ' Check if the expiry date is in MM/YY format (using regex)
        Dim regex As New System.Text.RegularExpressions.Regex("^(0[1-9]|1[0-2])\/\d{2}$")
        If Not regex.IsMatch(expiryDate) Then
            Return False
        End If

        ' Check if the expiry year is less than the current year
        Dim expiryYear As Integer = Convert.ToInt32(expiryDate.Substring(3, 2))
        Dim currentYear As Integer = DateTime.Now.Year Mod 100 ' Get last two digits of the current year
        Dim expiryMonth As Integer = Convert.ToInt32(expiryDate.Substring(0, 2))

        If expiryYear < currentYear OrElse (expiryYear = currentYear AndAlso expiryMonth < DateTime.Now.Month) Then
            Return False
        End If

        Return True
    End Function

    ' Function to validate CVV (3 digits, only numbers)
    Private Function IsValidCVV(cvv As String) As Boolean
        Return cvv.Length = 3 AndAlso cvv.All(AddressOf Char.IsDigit)
    End Function

    ' Event when the form is closing (optional)
    Private Sub CARD_CASHIER_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Any cleanup code when the form closes (optional)
    End Sub

    ' KeyPress event to ensure only valid characters are entered for Card Number
    Private Sub txtCardNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCardNumber.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' KeyPress event to ensure only valid characters are entered for CVV
    Private Sub txtCVV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCVV.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' KeyPress event to ensure only letters are entered for Cardholder Name
    Private Sub txtCardholderName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCardholderName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' TextChanged event to automatically format Expiry Date as MM/YY
    Private Sub txtExpiryDate_TextChanged(sender As Object, e As EventArgs) Handles txtExpiryDate.TextChanged
        If txtExpiryDate.Text.Length = 2 AndAlso Not txtExpiryDate.Text.Contains("/") Then
            txtExpiryDate.Text = txtExpiryDate.Text.Insert(2, "/")
            txtExpiryDate.SelectionStart = txtExpiryDate.Text.Length ' Place the cursor at the end
        End If
    End Sub

    ' TextChanged event to ensure the cardholder name is always in uppercase
    Private Sub txtCardholderName_TextChanged(sender As Object, e As EventArgs) Handles txtCardholderName.TextChanged
        ' Convert text to uppercase as user types
        If Not txtCardholderName.Focused Then Exit Sub
        txtCardholderName.Text = txtCardholderName.Text.ToUpper()
        txtCardholderName.SelectionStart = txtCardholderName.Text.Length ' Place the cursor at the end
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PAYMENT.Show()
        Me.Hide()
    End Sub
End Class
