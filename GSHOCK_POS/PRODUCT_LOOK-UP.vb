Imports System.Data.SqlClient

Public Class PRODUCT_LOOK_UP

    ' Connection String
    Private con As New SqlConnection("Data Source=DESKTOP-UD7BN0F;Initial Catalog=gshock;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    Private total As Decimal = 0

    ' Store matched products
    Private matchedProducts As New List(Of Product)()
    Private currentIndex As Integer = -1 ' To keep track of the current index in matched products

    ' Product structure to hold product data
    Public Class Product
        Public Property ID As String
        Public Property ProductName As String
        Public Property Series As String
        Public Property Price As Decimal
        Public Property Quantity As Integer
    End Class

    ' Load data on form load
    Private Sub PRODUCT_LOOK_UP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    ' Load Inventory and Cart
    Private Sub LoadData()
        Try
            Using con As New SqlConnection("Data Source=DESKTOP-UD7BN0F;Initial Catalog=gshock;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                con.Open()

                ' Load inventory data
                Dim inventoryAdapter As New SqlDataAdapter("SELECT * FROM gshock.dbo.products", con)
                Dim inventoryTable As New DataTable()
                inventoryAdapter.Fill(inventoryTable)
                DataGridView1.DataSource = inventoryTable

                ' Load cart data
                Dim cartAdapter As New SqlDataAdapter("SELECT * FROM gshock.dbo.lookup", con)
                Dim cartTable As New DataTable()
                cartAdapter.Fill(cartTable)
                DataGridView2.DataSource = cartTable
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    ' Add to Cart Button
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If Not String.IsNullOrWhiteSpace(TextBox5.Text) AndAlso IsNumeric(TextBox1.Text) Then
            Dim quantity As Integer = Convert.ToInt32(TextBox1.Text)
            If quantity > 0 Then
                AddToCart(TextBox5.Text, TextBox6.Text, quantity)
            Else
                MessageBox.Show("Quantity must be greater than 0.")
            End If
        Else
            MessageBox.Show("Please select a product and enter a valid quantity.")
        End If
    End Sub

    ' Add Product to Cart Logic
    Private Sub AddToCart(productId As String, productName As String, quantity As Integer)
        If quantity <= 0 Then Exit Sub

        Try
            Using con As New SqlConnection("Data Source=DESKTOP-UD7BN0F;Initial Catalog=gshock;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                con.Open()

                ' Retrieve product details from inventory
                Dim cmd As New SqlCommand("SELECT id, productname, series, price, quantity FROM gshock.dbo.products WHERE id = @id", con)
                cmd.Parameters.AddWithValue("@id", productId)

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim stock As Integer = Convert.ToInt32(reader("quantity"))
                        Dim price As Decimal = Convert.ToDecimal(reader("price"))
                        Dim series As String = reader("series").ToString()
                        reader.Close()

                        ' Check stock availability
                        If stock >= quantity Then
                            Dim totalPrice As Decimal = price * quantity
                            total += totalPrice

                            ' Update inventory and cart
                            UpdateInventory(con, productId, quantity)
                            UpdateCart(con, productId, productName, series, quantity, totalPrice)

                            ' Refresh UI and reset input fields
                            ClearProductFields()
                            LoadData()
                        Else
                            MessageBox.Show("Not enough stock for " & productName)
                            Me.Close() ' Close the form if stock is insufficient
                        End If
                    Else
                        MessageBox.Show("Product not found!")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message)
        End Try
    End Sub

    ' Update Inventory Stock
    Private Sub UpdateInventory(con As SqlConnection, productId As String, quantity As Integer)
        Try
            Using cmd As New SqlCommand("UPDATE gshock.dbo.products SET quantity = quantity - @quantity WHERE id = @id", con)
                cmd.Parameters.AddWithValue("@quantity", quantity)
                cmd.Parameters.AddWithValue("@id", productId)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating inventory: " & ex.Message)
        End Try
    End Sub

    ' Update or Insert into Cart
    Private Sub UpdateCart(con As SqlConnection, productId As String, productName As String, series As String, quantity As Integer, totalPrice As Decimal)
        Try
            Using cmd As New SqlCommand("SELECT quantity, price FROM gshock.dbo.lookup WHERE id = @id", con)
                cmd.Parameters.AddWithValue("@id", productId)

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Update existing product in cart
                        Dim existingQuantity As Integer = Convert.ToInt32(reader("quantity"))
                        Dim existingPrice As Decimal = Convert.ToDecimal(reader("price"))
                        reader.Close()

                        ' Update cart with new quantity and price
                        Using updateCmd As New SqlCommand("UPDATE gshock.dbo.lookup SET quantity = @newQuantity, price = @newPrice WHERE id = @id", con)
                            updateCmd.Parameters.AddWithValue("@newQuantity", existingQuantity + quantity)
                            updateCmd.Parameters.AddWithValue("@newPrice", existingPrice + totalPrice)
                            updateCmd.Parameters.AddWithValue("@id", productId)
                            updateCmd.ExecuteNonQuery()
                        End Using
                    Else
                        reader.Close()

                        ' Insert new product into cart if not found
                        Using insertCmd As New SqlCommand("INSERT INTO gshock.dbo.lookup (id, productname, quantity, price, series) VALUES (@id, @productname, @quantity, @price, @series)", con)
                            insertCmd.Parameters.AddWithValue("@id", productId)
                            insertCmd.Parameters.AddWithValue("@productname", productName)
                            insertCmd.Parameters.AddWithValue("@quantity", quantity)
                            insertCmd.Parameters.AddWithValue("@price", totalPrice)
                            insertCmd.Parameters.AddWithValue("@series", series)
                            insertCmd.ExecuteNonQuery()
                        End Using
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating cart: " & ex.Message)
        End Try
    End Sub

    ' Clear Product Input Fields
    Private Sub ClearProductFields()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox1.Clear()
    End Sub

    ' Start New Transaction
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult = MessageBox.Show("Start a new transaction? This will clear the current cart.", "Confirm New Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                Using con As New SqlConnection("Data Source=DESKTOP-UD7BN0F;Initial Catalog=gshock;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                    con.Open()

                    ' Clear the cart
                    Using cmd As New SqlCommand("DELETE FROM gshock.dbo.lookup", con)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Optionally, reset any other variables
                    total = 0
                    ClearProductFields()
                    LoadData()

                    MessageBox.Show("New transaction started. Cart is now empty.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            Catch ex As Exception
                MessageBox.Show("Error starting new transaction: " & ex.Message)
            End Try
        End If
    End Sub

    ' Clear Cart when Form Closes
    Private Sub PRODUCT_LOOK_UP_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Using con As New SqlConnection("Data Source=DESKTOP-UD7BN0F;Initial Catalog=gshock;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                con.Open()
                Dim cmd As New SqlCommand("DELETE FROM gshock.dbo.lookup", con)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error resetting cart: " & ex.Message)
        End Try
    End Sub

    ' Numeric input only for certain textboxes
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle DataGridView cell click to populate textboxes
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBox5.Text = row.Cells("id").Value.ToString() ' ID
            TextBox6.Text = row.Cells("productname").Value.ToString() ' ProductName
            TextBox7.Text = row.Cells("series").Value.ToString() ' Series
            TextBox8.Text = row.Cells("price").Value.ToString() ' Price
            TextBox1.Text = row.Cells("quantity").Value.ToString() ' Quantity
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        PAYMENT.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        If String.IsNullOrWhiteSpace(TextBox9.Text) Then
            ClearProductFields()
            Exit Sub
        End If

        Try
            Using con As New SqlConnection("Data Source=DESKTOP-UD7BN0F;Initial Catalog=gshock;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                con.Open()

                ' First, search for exact ID
                Dim exactIdQuery As String = "
                SELECT TOP 1 id, productname, series, price, quantity 
                FROM gshock.dbo.products 
                WHERE id = @searchText
            "
                Using cmd As New SqlCommand(exactIdQuery, con)
                    cmd.Parameters.AddWithValue("@searchText", TextBox9.Text.Trim())

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            FillProductFields(reader)
                            Return ' Found exact match, exit
                        End If
                    End Using
                End Using

                ' If no exact match, search partial ID or product name
                Dim partialQuery As String = "
                SELECT TOP 1 id, productname, series, price, quantity 
                FROM gshock.dbo.products 
                WHERE id LIKE @searchTextLike 
                   OR productname LIKE @searchTextName
            "
                Using cmd As New SqlCommand(partialQuery, con)
                    cmd.Parameters.AddWithValue("@searchTextLike", TextBox9.Text.Trim() + "%")
                    cmd.Parameters.AddWithValue("@searchTextName", "%" + TextBox9.Text.Trim() + "%")

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            FillProductFields(reader)
                        Else
                            ClearProductFields()
                        End If
                    End Using
                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching products: " & ex.Message)
        End Try
    End Sub

    Private Sub FillProductFields(reader As SqlDataReader)
        TextBox5.Text = reader("id").ToString()
        TextBox6.Text = reader("productname").ToString()
        TextBox7.Text = reader("series").ToString()
        TextBox8.Text = reader("price").ToString()
        TextBox1.Text = reader("quantity").ToString()
    End Sub

    ' Event: When user clicks a product in the Cart (DataGridView2)
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView2.Rows(e.RowIndex)

            Dim productId As String = selectedRow.Cells("id").Value.ToString()
            Dim productQuantity As Integer = Convert.ToInt32(selectedRow.Cells("quantity").Value)

            ' Confirm delete
            Dim result As DialogResult = MessageBox.Show($"Remove {productQuantity} pcs of {productId} from cart?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    Using con As New SqlConnection("Data Source=DESKTOP-UD7BN0F;Initial Catalog=gshock;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                        con.Open()

                        ' 1. Delete from cart
                        Using deleteCmd As New SqlCommand("DELETE FROM gshock.dbo.lookup WHERE id = @id", con)
                            deleteCmd.Parameters.AddWithValue("@id", productId)
                            deleteCmd.ExecuteNonQuery()
                        End Using

                        ' 2. Add back the quantity to products table
                        Using updateCmd As New SqlCommand("UPDATE gshock.dbo.products SET quantity = quantity + @quantity WHERE id = @id", con)
                            updateCmd.Parameters.AddWithValue("@quantity", productQuantity)
                            updateCmd.Parameters.AddWithValue("@id", productId)
                            updateCmd.ExecuteNonQuery()
                        End Using

                        ' Refresh DataGrids
                        LoadData()
                        ClearProductFields()

                        MessageBox.Show("Item successfully removed from cart and returned to inventory.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error while removing product: " & ex.Message)
                End Try
            End If
        End If
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class
