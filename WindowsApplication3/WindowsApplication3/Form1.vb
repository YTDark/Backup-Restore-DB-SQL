Imports System.Data.SqlClient
Public Class Form1
    Dim cmd As New SqlCommand
    Dim red As SqlDataReader
    Dim op As New OpenFileDialog
    Dim opf As New FolderBrowserDialog
    Private Sub redr()
        'Try
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    Dim sle As String = "Select * From ba_t Where cod <> '" & False & "' AND tet <> '" & False & "' AND tete <> '" & False & "'"
        '    Dim data As New SqlDataAdapter(sle, con)
        '    Dim dats As New DataSet
        '    data.Fill(dats)
        '    If dats.Tables(0).Rows.Count >= 1 Then
        '        Dim id3 As Integer = 1
        '        cmd = New SqlCommand("SELECT * FROM ba_t WHERE id3= @id3", con)
        '        cmd.Parameters.Add(New SqlParameter("@id3", id3))
        '        con.Open()
        '        red = cmd.ExecuteReader()
        '        red.Read()
        '        cod.Text = red.GetString(0)
        '        tet.Text = red.GetString(1)
        '        tf.Text = red.GetString(2)
        '        red.Close()
        '        con.Close()
        '    ElseIf dats.Tables(0).Rows.Count < 1 Or dats.Tables(0).Rows.Count <> 1 Then
        '        con.Close()
        '        Return
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    con.Close()
        'End Try
    End Sub
    Private Sub bac()
        Dim fln As String
        Dim back As String
        fln = tf.Text + "\\برنامج تجريبي" + DateTime.Now.ToString("yyyy_MM_dd", New System.Globalization.CultureInfo("en-US")) + "___" + DateTime.Now.ToString("hh__mm tt")
        back = "Backup Database test to Disk='" + fln + ".bak'"
        cmd = New SqlCommand(back, con)
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub bac_nwe()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            Dim sle As String = "Select * From ba_t Where cod = '" & Now.ToString("dddd") & "' AND tet = '" & Now.ToString("hh") & "' AND tete = '" & tf.Text & "'"
            Dim dataa As New SqlDataAdapter(sle, con)
            Dim dats As New DataSet
            dataa.Fill(dats)
            If dats.Tables(0).Rows.Count > 0 Then
                bac()
                Timer1.Stop()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub INS_sit()
        Try
            con.Open()
            If cod.Text = "" Then MessageBox.Show("يجب تعبئة كافة الحقول قبل حفظ الإعدادات", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
            If tet.Text = "" Then MessageBox.Show("يجب تعبئة كافة الحقول قبل حفظ الإعدادات", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
            If tf.Text = "" Then MessageBox.Show("يجب تعبئة كافة الحقول قبل حفظ الإعدادات", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
            Dim sql As String = "insert into ba_t (cod,tet,tete,id3) values (@cod,@tet,@tete,@id3) "
            Dim cmd As SqlCommand = New SqlCommand(sql, con)
            Dim id3 As Integer = 1
            cmd.Parameters.Add(New SqlParameter("@cod", cod.Text))
            cmd.Parameters.Add(New SqlParameter("@tet", tet.Text))
            cmd.Parameters.Add(New SqlParameter("@tete", tf.Text))
            cmd.Parameters.Add(New SqlParameter("@id3", id3))
            cmd.ExecuteNonQuery()
            MessageBox.Show("تم حفظ الاعدادات بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        redr()
    End Sub
    Private Sub dbr_Click(sender As Object, e As EventArgs) Handles dbr.Click
        If opf.ShowDialog = DialogResult.OK Then
            tf.Text = opf.SelectedPath
        End If
    End Sub
    Private Sub BCO_Click(sender As Object, e As EventArgs) Handles BCO.Click
        If opf.ShowDialog = DialogResult.OK Then
            t1.Text = opf.SelectedPath
        End If
    End Sub
    Private Sub BRO_Click(sender As Object, e As EventArgs) Handles BRO.Click
        If (op.ShowDialog() = DialogResult.OK) Then
            T2.Text = op.FileName
        End If
    End Sub
    Private Sub BC_Click(sender As Object, e As EventArgs) Handles BC.Click
        Try
            If t1.Text = "" Then
                MessageBox.Show("يجب أختيار مسار حفظ النسخة الاحتياطية ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Me.Cursor = Cursors.WaitCursor
            Dim fln As String
            Dim back As String
            fln = t1.Text + "\\برنامج تجريبي" + DateTime.Now.ToString("yyyy_MM_dd", New System.Globalization.CultureInfo("en-US")) + "___" + DateTime.Now.ToString("hh__mm tt")
            back = "Backup Database test to Disk='" + fln + ".bak'"
            cmd = New SqlCommand(back, con)
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            t1.Text = ""
            Me.Cursor = Cursors.Default
            MessageBox.Show("تم حفظ النسخة الاحتياطية بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub BR_Click(sender As Object, e As EventArgs) Handles BR.Click
        'Try
        '    If T2.Text = "" Then
        '        MessageBox.Show("يجب أختيار مسارالنسخة الاحتياطية ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '        Return
        '    End If
        '    Me.Cursor = Cursors.WaitCursor
        '    Dim res As String
        '    res = "ALTER DATABASE test SET OFFLINE WITH ROLLBACK IMMEDIATE; RESTORE DATABASE test From Disk ='" + op.FileName + "' ALTER DATABASE test SET ONLINE WITH ROLLBACK IMMEDIATE"
        '    cmd = New SqlCommand(res, con)
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    cmd.ExecuteNonQuery()
        '    con.Close()
        '    Me.Cursor = Cursors.Default
        '    T2.Text = ""
        '    MessageBox.Show("تم إستعادة النسخة الاحتياطية بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        '    T2.Text = ""
        'End Try
    End Sub
    Private Sub BD_Click(sender As Object, e As EventArgs) Handles BD.Click
        If MsgBox("سوف يتم تفريغ قاعدة البيانات بشكل نهائي", vbYesNo + vbQuestion, "رسالة تأكيد") = MsgBoxResult.No Then
            If MsgBoxResult.Yes Then
                Return
            End If
        End If
        Me.Cursor = Cursors.WaitCursor
        Dim dle As String = ("Delete from [TE]")
        Dim cmd As New SqlCommand(dle, con)
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        Me.Cursor = Cursors.Default
        MessageBox.Show("تم تفريغ قاعدة البيانات بشكل نهائي ", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub ch1_CheckedChanged(sender As Object, e As EventArgs) Handles ch1.CheckedChanged
        If ch1.Checked = True Then
            If (MessageBox.Show("سوف يتم حذف الإعدادات السابقة هل ترغب في الإكمال", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                Dim dle As String = ("Delete from [ba_t]")
                Dim cmd As New SqlCommand(dle, con)
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                GroupBox1.Enabled = True
                cod.Text = Nothing
                tet.Text = ""
                tf.Text = ""
            End If
        Else
            GroupBox1.Enabled = False
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        INS_sit()
        GroupBox1.Enabled = False
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        bac_nwe()
    End Sub
End Class
