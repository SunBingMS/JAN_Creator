Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmMain

    Private strJANCode As String

    Function ConvertToBarcodeTwo(intNum As Integer) As String
        '13桁JANコード用の事業者コードの変換
        Select Case intNum
            Case 0 : Return "@"
            Case 1 : Return "A"
            Case 2 : Return "B"
            Case 3 : Return "C"
            Case 4 : Return "D"
            Case 5 : Return "E"
            Case 6 : Return "F"
            Case 7 : Return "G"
            Case 8 : Return "H"
            Case Else : Return "I"
        End Select
    End Function

    Function ConvertToBarcodeShopCode(intNum As Integer) As String
        'JANコードの商品コード用の変換
        Select Case intNum
            Case 0 : Return "P"
            Case 1 : Return "Q"
            Case 2 : Return "R"
            Case 3 : Return "S"
            Case 4 : Return "T"
            Case 5 : Return "U"
            Case 6 : Return "V"
            Case 7 : Return "W"
            Case 8 : Return "X"
            Case Else : Return "Y"
        End Select
    End Function

    Sub ConvertToBarcode()
        '指定のセルのJANコードをバーコードフォント用に変換する

        Dim L1 As String, L2 As String, L3 As String, L4 As String, L5 As String, L6 As String, L7 As String, L8 As String, L9 As String, L10 As String, L11 As String, L12 As String
        Dim CD As Integer

        'JANコードそれぞれの桁をバーコード用に変換する
        strJANCode = txtJAN.Text
        If Len(strJANCode) = 13 Then
            '以下JANコードが13桁だった場合の処理
            CD = CInt(Strings.Left(strJANCode, 1))
            Select Case CD
                Case 0
                    L1 = Mid(strJANCode, 2, 1)
                    L2 = Mid(strJANCode, 3, 1)
                    L3 = Mid(strJANCode, 4, 1)
                    L4 = Mid(strJANCode, 5, 1)
                    L5 = Mid(strJANCode, 6, 1)
                    L6 = Mid(strJANCode, 7, 1)
                    L7 = ConvertToBarcodeShopCode(Mid(strJANCode, 8, 1))
                    L8 = ConvertToBarcodeShopCode(Mid(strJANCode, 9, 1))
                    L9 = ConvertToBarcodeShopCode(Mid(strJANCode, 10, 1))
                    L10 = ConvertToBarcodeShopCode(Mid(strJANCode, 11, 1))
                    L11 = ConvertToBarcodeShopCode(Mid(strJANCode, 12, 1))
                    L12 = ConvertToBarcodeShopCode(Mid(strJANCode, 13, 1))
                Case 1
                    L1 = Mid(strJANCode, 2, 1)
                    L2 = Mid(strJANCode, 3, 1)
                    L3 = ConvertToBarcodeTwo(Mid(strJANCode, 4, 1))
                    L4 = Mid(strJANCode, 5, 1)
                    L5 = ConvertToBarcodeTwo(Mid(strJANCode, 6, 1))
                    L6 = ConvertToBarcodeTwo(Mid(strJANCode, 7, 1))
                    L7 = ConvertToBarcodeShopCode(Mid(strJANCode, 8, 1))
                    L8 = ConvertToBarcodeShopCode(Mid(strJANCode, 9, 1))
                    L9 = ConvertToBarcodeShopCode(Mid(strJANCode, 10, 1))
                    L10 = ConvertToBarcodeShopCode(Mid(strJANCode, 11, 1))
                    L11 = ConvertToBarcodeShopCode(Mid(strJANCode, 12, 1))
                    L12 = ConvertToBarcodeShopCode(Mid(strJANCode, 13, 1))
                Case 2
                    L1 = Mid(strJANCode, 2, 1)
                    L2 = Mid(strJANCode, 3, 1)
                    L3 = ConvertToBarcodeTwo(Mid(strJANCode, 4, 1))
                    L4 = ConvertToBarcodeTwo(Mid(strJANCode, 5, 1))
                    L5 = Mid(strJANCode, 6, 1)
                    L6 = ConvertToBarcodeTwo(Mid(strJANCode, 7, 1))
                    L7 = ConvertToBarcodeShopCode(Mid(strJANCode, 8, 1))
                    L8 = ConvertToBarcodeShopCode(Mid(strJANCode, 9, 1))
                    L9 = ConvertToBarcodeShopCode(Mid(strJANCode, 10, 1))
                    L10 = ConvertToBarcodeShopCode(Mid(strJANCode, 11, 1))
                    L11 = ConvertToBarcodeShopCode(Mid(strJANCode, 12, 1))
                    L12 = ConvertToBarcodeShopCode(Mid(strJANCode, 13, 1))
                Case 3
                    L1 = Mid(strJANCode, 2, 1)
                    L2 = Mid(strJANCode, 3, 1)
                    L3 = ConvertToBarcodeTwo(Mid(strJANCode, 4, 1))
                    L4 = ConvertToBarcodeTwo(Mid(strJANCode, 5, 1))
                    L5 = ConvertToBarcodeTwo(Mid(strJANCode, 6, 1))
                    L6 = Mid(strJANCode, 7, 1)
                    L7 = ConvertToBarcodeShopCode(Mid(strJANCode, 8, 1))
                    L8 = ConvertToBarcodeShopCode(Mid(strJANCode, 9, 1))
                    L9 = ConvertToBarcodeShopCode(Mid(strJANCode, 10, 1))
                    L10 = ConvertToBarcodeShopCode(Mid(strJANCode, 11, 1))
                    L11 = ConvertToBarcodeShopCode(Mid(strJANCode, 12, 1))
                    L12 = ConvertToBarcodeShopCode(Mid(strJANCode, 13, 1))
                Case 4
                    L1 = Mid(strJANCode, 2, 1)
                    L2 = ConvertToBarcodeTwo(Mid(strJANCode, 3, 1))
                    L3 = Mid(strJANCode, 4, 1)
                    L4 = Mid(strJANCode, 5, 1)
                    L5 = ConvertToBarcodeTwo(Mid(strJANCode, 6, 1))
                    L6 = ConvertToBarcodeTwo(Mid(strJANCode, 7, 1))
                    L7 = ConvertToBarcodeShopCode(Mid(strJANCode, 8, 1))
                    L8 = ConvertToBarcodeShopCode(Mid(strJANCode, 9, 1))
                    L9 = ConvertToBarcodeShopCode(Mid(strJANCode, 10, 1))
                    L10 = ConvertToBarcodeShopCode(Mid(strJANCode, 11, 1))
                    L11 = ConvertToBarcodeShopCode(Mid(strJANCode, 12, 1))
                    L12 = ConvertToBarcodeShopCode(Mid(strJANCode, 13, 1))
                Case 5
                    L1 = Mid(strJANCode, 2, 1)
                    L2 = ConvertToBarcodeTwo(Mid(strJANCode, 3, 1))
                    L3 = ConvertToBarcodeTwo(Mid(strJANCode, 4, 1))
                    L4 = Mid(strJANCode, 5, 1)
                    L5 = Mid(strJANCode, 6, 1)
                    L6 = ConvertToBarcodeTwo(Mid(strJANCode, 7, 1))
                    L7 = ConvertToBarcodeShopCode(Mid(strJANCode, 8, 1))
                    L8 = ConvertToBarcodeShopCode(Mid(strJANCode, 9, 1))
                    L9 = ConvertToBarcodeShopCode(Mid(strJANCode, 10, 1))
                    L10 = ConvertToBarcodeShopCode(Mid(strJANCode, 11, 1))
                    L11 = ConvertToBarcodeShopCode(Mid(strJANCode, 12, 1))
                    L12 = ConvertToBarcodeShopCode(Mid(strJANCode, 13, 1))
                Case 6
                    L1 = Mid(strJANCode, 2, 1)
                    L2 = ConvertToBarcodeTwo(Mid(strJANCode, 3, 1))
                    L3 = ConvertToBarcodeTwo(Mid(strJANCode, 4, 1))
                    L4 = ConvertToBarcodeTwo(Mid(strJANCode, 5, 1))
                    L5 = Mid(strJANCode, 6, 1)
                    L6 = Mid(strJANCode, 7, 1)
                    L7 = ConvertToBarcodeShopCode(Mid(strJANCode, 8, 1))
                    L8 = ConvertToBarcodeShopCode(Mid(strJANCode, 9, 1))
                    L9 = ConvertToBarcodeShopCode(Mid(strJANCode, 10, 1))
                    L10 = ConvertToBarcodeShopCode(Mid(strJANCode, 11, 1))
                    L11 = ConvertToBarcodeShopCode(Mid(strJANCode, 12, 1))
                    L12 = ConvertToBarcodeShopCode(Mid(strJANCode, 13, 1))
                Case 7
                    L1 = Mid(strJANCode, 2, 1)
                    L2 = ConvertToBarcodeTwo(Mid(strJANCode, 3, 1))
                    L3 = Mid(strJANCode, 4, 1)
                    L4 = ConvertToBarcodeTwo(Mid(strJANCode, 5, 1))
                    L5 = Mid(strJANCode, 6, 1)
                    L6 = ConvertToBarcodeTwo(Mid(strJANCode, 7, 1))
                    L7 = ConvertToBarcodeShopCode(Mid(strJANCode, 8, 1))
                    L8 = ConvertToBarcodeShopCode(Mid(strJANCode, 9, 1))
                    L9 = ConvertToBarcodeShopCode(Mid(strJANCode, 10, 1))
                    L10 = ConvertToBarcodeShopCode(Mid(strJANCode, 11, 1))
                    L11 = ConvertToBarcodeShopCode(Mid(strJANCode, 12, 1))
                    L12 = ConvertToBarcodeShopCode(Mid(strJANCode, 13, 1))
                Case 8
                    L1 = Mid(strJANCode, 2, 1)
                    L2 = ConvertToBarcodeTwo(Mid(strJANCode, 3, 1))
                    L3 = Mid(strJANCode, 4, 1)
                    L4 = ConvertToBarcodeTwo(Mid(strJANCode, 5, 1))
                    L5 = ConvertToBarcodeTwo(Mid(strJANCode, 6, 1))
                    L6 = Mid(strJANCode, 7, 1)
                    L7 = ConvertToBarcodeShopCode(Mid(strJANCode, 8, 1))
                    L8 = ConvertToBarcodeShopCode(Mid(strJANCode, 9, 1))
                    L9 = ConvertToBarcodeShopCode(Mid(strJANCode, 10, 1))
                    L10 = ConvertToBarcodeShopCode(Mid(strJANCode, 11, 1))
                    L11 = ConvertToBarcodeShopCode(Mid(strJANCode, 12, 1))
                    L12 = ConvertToBarcodeShopCode(Mid(strJANCode, 13, 1))
                Case 9
                    L1 = Mid(strJANCode, 2, 1)
                    L2 = ConvertToBarcodeTwo(Mid(strJANCode, 3, 1))
                    L3 = ConvertToBarcodeTwo(Mid(strJANCode, 4, 1))
                    L4 = Mid(strJANCode, 5, 1)
                    L5 = ConvertToBarcodeTwo(Mid(strJANCode, 6, 1))
                    L6 = Mid(strJANCode, 7, 1)
                    L7 = ConvertToBarcodeShopCode(Mid(strJANCode, 8, 1))
                    L8 = ConvertToBarcodeShopCode(Mid(strJANCode, 9, 1))
                    L9 = ConvertToBarcodeShopCode(Mid(strJANCode, 10, 1))
                    L10 = ConvertToBarcodeShopCode(Mid(strJANCode, 11, 1))
                    L11 = ConvertToBarcodeShopCode(Mid(strJANCode, 12, 1))
                    L12 = ConvertToBarcodeShopCode(Mid(strJANCode, 13, 1))
                Case Else
                    L1 = ""
                    L2 = ""
                    L3 = ""
                    L4 = ""
                    L5 = ""
                    L6 = ""
                    L7 = ""
                    L8 = ""
                    L9 = ""
                    L10 = ""
                    L11 = ""
                    L12 = ""
            End Select
            '変数Barcodeに変換した文字を全てつなげて文字列にして代入する
            lblJANBAR.Text = "(" & L1 & L2 & L3 & L4 & L5 & L6 & "|" & L7 & L8 & L9 & L10 & L11 & L12 & ")"
        ElseIf Len(strJANCode) = 8 Then
            '以下JANコードが8桁だった場合の処理
            L1 = ConvertToBarcodeTwo(CInt(Mid(strJANCode, 1, 1)))
            L2 = ConvertToBarcodeTwo(CInt(Mid(strJANCode, 2, 1)))
            L3 = ConvertToBarcodeTwo(CInt(Mid(strJANCode, 3, 1)))
            L4 = ConvertToBarcodeTwo(CInt(Mid(strJANCode, 4, 1)))
            L5 = ConvertToBarcodeTwo(CInt(Mid(strJANCode, 5, 1)))
            L6 = ConvertToBarcodeTwo(CInt(Mid(strJANCode, 6, 1)))
            L7 = ConvertToBarcodeTwo(CInt(Mid(strJANCode, 7, 1)))
            L8 = ConvertToBarcodeTwo(CInt(Mid(strJANCode, 8, 1)))
            '変数Barcodeに変換した文字を全てつなげて文字列にして代入する
            lblJANBAR.Text = "(" & L1 & L2 & L3 & L4 & L5 & L6 & "|" & L7 & L8 & ")"
        End If
    End Sub

    Private Sub btnCONV_Click(sender As Object, e As EventArgs) Handles btnCONV.Click
        Select Case cmbFONT.SelectedIndex
            Case 0
                lblJANBAR.Font = New System.Drawing.Font("TIS_JAN_1", lblJANBAR.Font.Size)
            Case 1
                lblJANBAR.Font = New System.Drawing.Font("TIS_JAN_1.5", lblJANBAR.Font.Size)
            Case 2
                lblJANBAR.Font = New System.Drawing.Font("TIS_JAN_2", lblJANBAR.Font.Size)
            Case 3
                lblJANBAR.Font = New System.Drawing.Font("TIS_JAN_2.5", lblJANBAR.Font.Size)
            Case 4
                lblJANBAR.Font = New System.Drawing.Font("TIS_JAN_3", lblJANBAR.Font.Size)
        End Select

        ConvertToBarcode()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim arrayFont() As String = {"TIS_JAN_1", "TIS_JAN_1.5", "TIS_JAN_2", "TIS_JAN_2.5", "TIS_JAN_3"}

        cmbFONT.Items.Clear()

        For Each strFont In arrayFont
            cmbFONT.Items.Add(strFont)
        Next

        cmbFONT.SelectedIndex = 0
    End Sub
End Class
