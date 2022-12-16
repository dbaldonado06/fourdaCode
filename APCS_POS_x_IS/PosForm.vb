Imports System.Data.SqlClient
Public Class PosForm
    Public Shared ID As String
    Public Shared Cancel As Boolean = False
    Public Shared buttonPressed As Boolean = False
    Public Shared getQty As Integer
    Public Shared SubTotal As Double
    Public Shared Total As Double
    Public Shared Vatable As Double
    Private Sub btnPOSNewTransaction_Click(sender As Object, e As EventArgs) Handles btnPOSNewTransaction.Click
        NewtransactionForm.Show()
        LblTranNo.Text = GenTransactionNo()
        DateOrder.Text = Now.ToString("MMMM dd, yyyy")
    End Sub

    Private Sub btnPOSSettlePayment_Click(sender As Object, e As EventArgs) Handles btnPOSSettlePayment.Click
        SettlepaymentForm.Show()
    End Sub

    Private Sub btnPOSManageOrders_Click(sender As Object, e As EventArgs) Handles btnPOSManageOrders.Click
        ManageordersForm.Show()
    End Sub

    Private Sub btnPOSManageProductMenu_Click(sender As Object, e As EventArgs) Handles btnPOSManageProductMenu.Click
        With ManagemenuproductForm
            .ShowDialog()
        End With
    End Sub

    Private Sub btnPOSCancelOrder_Click(sender As Object, e As EventArgs) Handles btnPOSCancelOrder.Click
        CancelOrderForm.Show()
    End Sub
    Private Sub btnPOSSalesReport_Click(sender As Object, e As EventArgs) Handles btnPOSSalesReport.Click
        With DailySalesForm
            .ShowDialog()
        End With
    End Sub
    Private Sub btnPOSAddVoucher_Click(sender As Object, e As EventArgs) Handles btnPOSAddVoucher.Click
        VoucherForm.Show()
    End Sub
    Private Sub btnPOSStart_Click(sender As Object, e As EventArgs) Handles btnPOSStart.Click
        With StartofDayForm
            .ShowDialog()
        End With
    End Sub

    'Private Sub DateAndTime_Tick(sender As Object, e As EventArgs)
    '    RealtimeDate.Text = Date.Now.ToString(String.Format("MMM dd, yy" + Environment.NewLine + "hh: mm: ss tt"))
    'End Sub





    Private Sub FoodCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FoodCategory.SelectedIndexChanged
        dataGridViewPMenus.Rows.Clear()
        ID = GetCategory()
        Connection()
        cmd = New SqlCommand("SELECT PCode, Name, Price, Availability FROM [ProductMenu] WHERE CategoryID = '" & ID & "'") With {
            .Connection = con}
        dr = cmd.ExecuteReader
        While dr.Read
            dataGridViewPMenus.Rows.Add(0, dr.Item("PCode").ToString, dr.Item("Name").ToString, dr.Item("Price"))
        End While
        con.Close()
    End Sub

    Private Sub PosForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            btnPOSNewTransaction_Click(sender, e)
        ElseIf e.KeyCode = Keys.F2 Then
            btnPOSSettlePayment_Click(sender, e)
        ElseIf e.KeyCode = Keys.F3 Then
            btnPOSAddVoucher_Click(sender, e)
        ElseIf e.KeyCode = Keys.F4 Then
            btnPOSCancelOrder_Click(sender, e)
        ElseIf e.KeyCode = Keys.F4 Then
            btnPOSCancelOrder_Click(sender, e)
        ElseIf e.KeyCode = Keys.F5 Then
            btnPOSManageProductMenu_Click(sender, e)
        ElseIf e.KeyCode = Keys.F6 Then
            btnPOSManageOrders_Click(sender, e)
        ElseIf e.KeyCode = Keys.F7 Then
            btnPOSSalesReport_Click(sender, e)
        End If
    End Sub

    Private Sub dataGridViewPMenus_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewPMenus.CellValueChanged

        'For Each row As DataGridViewRow In dataGridViewPMenus.Rows
        '    If dataGridViewPMenus_CellContentClick(sender, e) Then

        '    End If
        'Next
    End Sub

    Private Sub dataGridViewPMenus_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewPMenus.CellClick
        'Dim dt As New DataTable
        'dt.Columns.Add("PCode")
        'dt.Columns.Add("Name")
        'dt.Columns.Add("Price")
        'dt.Columns.Add("Quantity")
        'dt.Columns.Add("Total")
        Dim selectedRow As DataGridViewRow
        With SetQuantity
            .ShowDialog()
        End With

        If Cancel = False And buttonPressed = True Then

            selectedRow = dataGridViewPMenus.Rows(e.RowIndex)
            Dim TotalxQty As Double = selectedRow.Cells(3).Value.ToString * getQty
            Dim price As Double = selectedRow.Cells(3).Value.ToString
            dataGridViewPOS.Rows.Add(0, selectedRow.Cells(1).Value, selectedRow.Cells(2).Value, price.ToString("###,###,###.00"), getQty, TotalxQty.ToString("###,###,###.00"))
            SubTotal += TotalxQty
        End If
        Dim vatableSales As Double = SubTotal / 1.12
        Vatable = vatableSales * 0.12
        SubTot.Text = SubTotal.ToString("###,###,###.00")
        VAT.Text = Vatable.ToString("###,###,###.00")
        Total = SubTotal + Vatable
        TotalLbl.Text = Total.ToString("###,###,###.00")

    End Sub

    Private Sub posPanel_Paint(sender As Object, e As PaintEventArgs) Handles posPanel.Paint
        btnPOSStart.Enabled = False
        btnPOSEnd.Enabled = False
    End Sub
    Private Sub posPanel_Load(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Me.KeyPreview = True
        Connection()
        cmd = New SqlCommand("SELECT Name FROM [Category]") With {
            .Connection = con}
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        FoodCategory.DataSource = dt

        FoodCategory.DisplayMember = "Name"
    End Sub
    Function GenTransactionNo()
        Dim trNo As String = Now.ToString("AyyPMMCddSHmm")
        Return trNo
    End Function
    Function GetCategory()
        Connection()
        cmd = New SqlCommand("SELECT CategoryID FROM [Category] WHERE Name = '" & FoodCategory.Text & "'") With {
            .Connection = con}
        dr = cmd.ExecuteReader
        If (dr.Read()) Then
            Return dr("CategoryID")
        End If
        dr.Close()
        con.Close()
    End Function

    Private Sub dataGridViewPOS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewPOS.CellContentClick
        Dim len As Integer = dataGridViewPOS.RowCount
        Dim rw As DataGridViewRow = dataGridViewPOS.Rows(e.RowIndex)
        For row As Integer = 1 To len
            MsgBox(rw.Cells(2).Value.ToString)
        Next
    End Sub
End Class