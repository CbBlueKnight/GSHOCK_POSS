' CASH_QR - QR Code Generation and Display
Imports ZXing
Imports System.Drawing

Public Class CASH_QR

    ' Method to generate and display QR code
    Public Sub GenerateQRCode(textToEncode As String)
        ' Create a BarcodeWriter instance for QR code generation
        Dim barcodeWriter As New BarcodeWriter()
        barcodeWriter.Format = BarcodeFormat.QR_CODE

        ' Set encoding options (optional, here we set the QR code size)
        barcodeWriter.Options = New ZXing.Common.EncodingOptions With {
            .Width = 350, ' QR code width
            .Height = 350 ' QR code height
        }

        ' Generate the QR code as an image
        Dim qrCodeImage As Bitmap = barcodeWriter.Write(textToEncode)

        ' Display the QR code in the PictureBox control (Ensure you have a PictureBox control on your form)
        PictureBox1.Image = qrCodeImage
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PAYMENT.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class
