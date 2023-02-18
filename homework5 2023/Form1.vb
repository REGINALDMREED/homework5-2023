Public Class frmDevConference
    Private Sub btnCalc_Click(sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        'Determine and display total cost per company
        'for developers attending the conference
        'Variable declaration sections.
        Dim intNumOfMemb As Decimal
        Dim decTotalCost As Decimal
        Dim decCost As Decimal
        'Check if user enter valid numbers?
        If IsNumeric(txtNumOfMemb.Text) Then
            Integer.TryParse(txtNumOfMemb.Text, intNumOfMemb)
            Select Case intNumOfMemb
                Case 1
                    decCost = 795
                Case 2 To 4
                    decCost = 645
                Case 5 To 7
                    decCost = 475
                Case 8 To 16
                    decCost = 385
                Case Else
                    'Display error message if user enters more than 16 peoples
                    MsgBox("There is not allowed more than 16 people from single company.",, "Input Error")
                    txtNumOfMemb.Text = ""
                    txtNumOfMemb.Focus()

            End Select
            'Perform calculation and display total cost
            If radNew.Checked Then
                'total cost for new attendee
                decTotalCost = intNumOfMemb * decCost
            Else
                'total cost for old attendee
                decTotalCost = (intNumOfMemb * decCost) - (0.15 * intNumOfMemb * decCost)
            End If
            'Display total cost for attendee per company
            lblCost.Text = decTotalCost.ToString("C2")
        Else
            'Display error message if user enter invalid numbees
            MsgBox("Please Enter Valid Number(s).",, "Input Error")
            txtNumOfMemb.Text = ""
            txtNumOfMemb.Focus()
        End If
    End Sub

    Private Sub btnClear_Click(sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'To clear textbox, reset radio button and clear label text
        txtNumOfMemb.Clear()
        txtNumOfMemb.Focus()
        radNew.Checked = True
        radPre.Checked = False
        lblCost.Text = ""

    End Sub
End Class
