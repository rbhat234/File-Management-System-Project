Imports System.Data.OleDb
Public Class FormAddMemberQualification
    

    Private Sub ComboBoxQualification_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxQualification.SelectedIndexChanged

        If ComboBoxQualification.SelectedIndex = 0 Then


            TextBoxMatricPercent.Text = "NULL"
            TextBoxMatricPercent.ReadOnly = True
            ComboBoxHrSecStream.Text = "NULL"
            ComboBoxHrSecStream.Enabled = False
            TextBoxAnyOtherHrSecStreamName.ReadOnly = True
            TextBoxAnyOtherHrSecStreamName.Text = "NULL"
            TextBoxHrSecSubjects.ReadOnly = True
            TextBoxHrSecSubjects.Text = "NULL"
            TextBoxHrSecPercentage.ReadOnly = True
            TextBoxHrSecPercentage.Text = "NULL"
            ComboBoxGraduationStream.Text = "NULL"
            ComboBoxGraduationStream.Enabled = False
            TextBoxAnyOtherGraduationStream.Text = "NULL"
            TextBoxAnyOtherGraduationStream.ReadOnly = True
            TextBoxGraduationSubjects.Text = "NULL"
            TextBoxGraduationSubjects.ReadOnly = True
            TextBoxGraduationParcentage.Text = "NULL"
            TextBoxGraduationParcentage.ReadOnly = True
            ComboBoxPGStream.Text = "NULL"
            ComboBoxPGStream.Enabled = False
            TextBoxPGSubjects.Text = "NULL"
            TextBoxPGPercentage.ReadOnly = True
            TextBoxPGPercentage.Text = "NULL"
            TextBoxPGSubjects.Text = "NULL"
            TextBoxPGSubjects.ReadOnly = True
            TextBoxAnyOtherPGStream.Text = "NULL"
            TextBoxAnyOtherPGStream.ReadOnly = True
            TextBoxOtherQual.ReadOnly = True
            TextBoxOtherQual.Text = "NULL"
            TextBoxMoreQualPercent.Text = "NULL"
            TextBoxMoreQualPercent.ReadOnly = True


        End If

        If ComboBoxQualification.SelectedIndex = 1 Then


            ComboBoxHrSecStream.Text = "NULL"
            ComboBoxHrSecStream.Enabled = False

            TextBoxAnyOtherHrSecStreamName.ReadOnly = True
            TextBoxAnyOtherHrSecStreamName.Text = "NULL"

            TextBoxHrSecSubjects.ReadOnly = True
            TextBoxHrSecSubjects.Text = "NULL"
            TextBoxHrSecPercentage.ReadOnly = True
            TextBoxHrSecPercentage.Text = "NULL"
            ComboBoxGraduationStream.Text = "NULL"
            ComboBoxGraduationStream.Enabled = False
            TextBoxAnyOtherGraduationStream.Text = "NULL"
            TextBoxAnyOtherGraduationStream.ReadOnly = True
            TextBoxGraduationSubjects.Text = "NULL"
            TextBoxGraduationSubjects.ReadOnly = True
            TextBoxGraduationParcentage.Text = "NULL"
            TextBoxGraduationParcentage.ReadOnly = True
            ComboBoxPGStream.Text = "NULL"
            ComboBoxPGStream.Enabled = False
            TextBoxPGSubjects.Text = "NULL"
            TextBoxPGPercentage.ReadOnly = True
            TextBoxPGPercentage.Text = "NULL"
            TextBoxPGSubjects.Text = "NULL"
            TextBoxPGSubjects.ReadOnly = True
            TextBoxAnyOtherPGStream.Text = "NULL"
            TextBoxAnyOtherPGStream.ReadOnly = True
            TextBoxOtherQual.ReadOnly = True
            TextBoxOtherQual.Text = "NULL"
            TextBoxMoreQualPercent.Text = "NULL"
            TextBoxMoreQualPercent.ReadOnly = True

            TextBoxMatricPercent.ReadOnly = False
            TextBoxMatricPercent.Clear()
        End If

        If ComboBoxQualification.SelectedIndex = 2 Then

            ComboBoxGraduationStream.Text = "NULL"
            ComboBoxGraduationStream.Enabled = False
            TextBoxAnyOtherGraduationStream.Text = "NULL"
            TextBoxAnyOtherGraduationStream.ReadOnly = True
            TextBoxGraduationSubjects.Text = "NULL"
            TextBoxGraduationSubjects.ReadOnly = True
            TextBoxGraduationParcentage.Text = "NULL"
            TextBoxGraduationParcentage.ReadOnly = True
            ComboBoxPGStream.Text = "NULL"
            ComboBoxPGStream.Enabled = False
            TextBoxPGSubjects.Text = "NULL"
            TextBoxPGPercentage.ReadOnly = True
            TextBoxPGPercentage.Text = "NULL"
            TextBoxPGSubjects.Text = "NULL"
            TextBoxPGSubjects.ReadOnly = True

            TextBoxAnyOtherPGStream.Text = "NULL"
            TextBoxAnyOtherPGStream.ReadOnly = True
            TextBoxOtherQual.ReadOnly = True
            TextBoxOtherQual.Text = "NULL"
            TextBoxMoreQualPercent.Text = "NULL"
            TextBoxMoreQualPercent.ReadOnly = True



            TextBoxMatricPercent.ReadOnly = False
            ComboBoxHrSecStream.ResetText()
            ComboBoxHrSecStream.Enabled = True
            TextBoxAnyOtherHrSecStreamName.ReadOnly = False
            TextBoxAnyOtherHrSecStreamName.Clear()
            TextBoxHrSecSubjects.ReadOnly = False
            TextBoxHrSecSubjects.Clear()
            TextBoxHrSecPercentage.ReadOnly = False
            TextBoxHrSecPercentage.Clear()
        End If

        If ComboBoxQualification.SelectedIndex = 3 Then

            ComboBoxPGStream.Text = "NULL"
            ComboBoxPGStream.Enabled = False
            TextBoxPGSubjects.Text = "NULL"
            TextBoxPGPercentage.ReadOnly = True
            TextBoxPGPercentage.Text = "NULL"
            TextBoxPGSubjects.Text = "NULL"
            TextBoxPGSubjects.ReadOnly = True
            TextBoxAnyOtherPGStream.Text = "NULL"
            TextBoxAnyOtherPGStream.ReadOnly = True
            TextBoxOtherQual.ReadOnly = True
            TextBoxOtherQual.Text = "NULL"
            TextBoxMoreQualPercent.Text = "NULL"
            TextBoxMoreQualPercent.ReadOnly = True


            TextBoxMatricPercent.ReadOnly = False
            ComboBoxHrSecStream.ResetText()
            ComboBoxHrSecStream.Enabled = True
            TextBoxAnyOtherHrSecStreamName.ReadOnly = False
            TextBoxAnyOtherHrSecStreamName.Clear()
            TextBoxHrSecSubjects.ReadOnly = False
            TextBoxHrSecSubjects.Clear()
            TextBoxHrSecPercentage.ReadOnly = False
            TextBoxHrSecPercentage.Clear()
            ComboBoxGraduationStream.ResetText()
            ComboBoxGraduationStream.Enabled = True
            TextBoxAnyOtherGraduationStream.Clear()
            TextBoxAnyOtherGraduationStream.ReadOnly = False
            TextBoxGraduationSubjects.Clear()
            TextBoxGraduationSubjects.ReadOnly = False
            TextBoxGraduationParcentage.Clear()
            TextBoxGraduationParcentage.ReadOnly = False
        End If

        If ComboBoxQualification.SelectedIndex = 4 Then

            TextBoxOtherQual.ReadOnly = True
            TextBoxOtherQual.Text = "NULL"
            TextBoxMoreQualPercent.Text = "NULL"
            TextBoxMoreQualPercent.ReadOnly = True


            TextBoxMatricPercent.ReadOnly = False
            ComboBoxHrSecStream.ResetText()
            ComboBoxHrSecStream.Enabled = True
            TextBoxAnyOtherHrSecStreamName.ReadOnly = False
            TextBoxAnyOtherHrSecStreamName.Clear()
            TextBoxHrSecSubjects.ReadOnly = False
            TextBoxHrSecSubjects.Clear()
            TextBoxHrSecPercentage.ReadOnly = False
            TextBoxHrSecPercentage.Clear()
            ComboBoxGraduationStream.ResetText()
            ComboBoxGraduationStream.Enabled = True
            TextBoxAnyOtherGraduationStream.Clear()
            TextBoxAnyOtherGraduationStream.ReadOnly = False
            TextBoxGraduationSubjects.Clear()
            TextBoxGraduationSubjects.ReadOnly = False
            TextBoxGraduationParcentage.Clear()
            TextBoxGraduationParcentage.ReadOnly = False
            ComboBoxPGStream.ResetText()
            ComboBoxPGStream.Enabled = True
            TextBoxPGSubjects.Clear()
            TextBoxAnyOtherPGStream.ReadOnly = False
            TextBoxAnyOtherPGStream.Clear()
            TextBoxPGPercentage.ReadOnly = False
            TextBoxPGSubjects.Clear()
            TextBoxPGSubjects.ReadOnly = False
            TextBoxPGPercentage.Clear()
        End If
        If ComboBoxQualification.SelectedIndex = 5 Then

            TextBoxMatricPercent.ReadOnly = False
            ComboBoxHrSecStream.ResetText()
            ComboBoxHrSecStream.Enabled = True
            TextBoxAnyOtherHrSecStreamName.ReadOnly = False
            TextBoxAnyOtherHrSecStreamName.Clear()
            TextBoxHrSecSubjects.ReadOnly = False
            TextBoxHrSecSubjects.Clear()
            TextBoxHrSecPercentage.ReadOnly = False
            TextBoxHrSecPercentage.Clear()
            ComboBoxGraduationStream.ResetText()
            ComboBoxGraduationStream.Enabled = True
            TextBoxAnyOtherGraduationStream.Clear()
            TextBoxAnyOtherGraduationStream.ReadOnly = False
            TextBoxGraduationSubjects.Clear()
            TextBoxGraduationSubjects.ReadOnly = False
            TextBoxGraduationParcentage.Clear()
            TextBoxGraduationParcentage.ReadOnly = False
            ComboBoxPGStream.ResetText()
            ComboBoxPGStream.Enabled = True
            TextBoxPGSubjects.Clear()
            TextBoxAnyOtherPGStream.ReadOnly = False
            TextBoxAnyOtherPGStream.Clear()
            TextBoxPGPercentage.ReadOnly = False
            TextBoxPGSubjects.Clear()
            TextBoxPGSubjects.ReadOnly = False

            TextBoxOtherQual.ReadOnly = False
            TextBoxOtherQual.Clear()
            TextBoxMoreQualPercent.Clear()
            TextBoxMoreQualPercent.ReadOnly = False
        End If
    End Sub

    Private Sub FormAddMemberQualification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = MRId
    End Sub

    Private Sub ComboBoxOccupation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxOccupation.SelectedIndexChanged

        If ComboBoxOccupation.SelectedIndex = 0 Then
            TextBoxOccupationDepartment.ReadOnly = True
            TextBoxOccupationDepartment.Text = "NULL"
            ComboBoxOccupationType.Enabled = False
            ComboBoxOccupationType.Text = "NULL"
            TextBoxOccupationDesignation.Text = "Student"
            TextBoxOccupationDesignation.ReadOnly = True

        ElseIf ComboBoxOccupation.SelectedIndex = 2 Then
            ComboBoxOccupationType.Text = "NULL"
            ComboBoxOccupationType.Enabled = False

            TextBoxOccupationDepartment.Text = "NULL"
            TextBoxOccupationDepartment.ReadOnly = True

            TextBoxOccupationDesignation.Text = "NULL"
            TextBoxOccupationDesignation.ReadOnly = True

        Else

            TextBoxOccupationDepartment.ReadOnly = False
            TextBoxOccupationDepartment.Clear()
            ComboBoxOccupationType.Enabled = True
            ComboBoxOccupationType.ResetText()
            TextBoxOccupationDesignation.ReadOnly = False
            TextBoxOccupationDesignation.Clear()

            ComboBoxOccupationType.ResetText()
            ComboBoxOccupationType.Enabled = True

            TextBoxOccupationDepartment.Clear()
            TextBoxOccupationDepartment.ReadOnly = False

            TextBoxOccupationDesignation.Clear()
            TextBoxOccupationDesignation.ReadOnly = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCncl.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Dim cmd As New OleDbCommand("Delete From Members Where Member_Registration_ID =" & TextBox1.Text & "", con)
        Try
            con.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        
        Me.Close()
    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            CheckBox2.Checked = False
            TextBoxReason.Clear()
            TextBoxReason.ReadOnly = False
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.CheckState = CheckState.Checked Then
            CheckBox1.Checked = False
            TextBoxReason.Text = "NOT FACED ANY CHARGE"
            TextBoxReason.ReadOnly = True
        End If
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
       
        If ComboBoxHrSecStream.Text = "" Or
       TextBoxAnyOtherHrSecStreamName.Text = "" Or
           TextBoxHrSecSubjects.Text = "" Or
           TextBoxHrSecPercentage.Text = "" Or
       ComboBoxGraduationStream.Text = "" Or
        TextBoxAnyOtherGraduationStream.Text = "" Or
        TextBoxGraduationSubjects.Text = "" Or
        TextBoxGraduationParcentage.Text = "" Or
        ComboBoxPGStream.Text = "" Or
        TextBoxPGSubjects.Text = "" Or
        TextBoxPGSubjects.Text = "" Or
        TextBoxPGSubjects.Text = "" Or
        TextBoxAnyOtherPGStream.Text = "" Or
        TextBoxOtherQual.Text = "" Or
        TextBoxMoreQualPercent.Text = "" Or
        ComboBoxQualification.Text = "" Or
        TextBoxMatricPercent.Text = "" Or
        TextBoxMatricPercent.Text = "" Or
        TextBoxUnderMatricPercent.Text = "" Then
            MessageBox.Show("Some ComboBoxes or TextBoxes are Empty")
        End If


        Dim cmd As New OleDbCommand("update Members set [Qualification] = @Qualification, [Under_Matriculation_Percentage] = @Under_Matriculation_Percentage, " & _
                                    "[Matriculation_Percentage] = @Matriculation_Percentage, [Hr_Secondary_Stream] = @Hr_Secondary_Stream, " & _
                                    "[Any_Other_Hr_Sec_Stream] = @Any_Other_Hr_Sec_Stream, [Enter_Subject] = @Enter_Subject, [Hr_Secondary_Percentage] = @Hr_Secondary_Percentage," & _
                                    "[Graduation_Stream] = @Graduation_Stream, [Any_Other_Graduation_Stream] = @Any_Other_Graduation_Stream, [Graduation_Subjects] = @Graduation_Subjects, " & _
                                    "[Graduation_Percentage] = @Graduation_Percentage, [PG_Stream] = @PG_Stream, [Any_Other_PG_Stream] = @Any_Other_PG_Stream, " & _
                                    "[Enter_PG_Subjects] = @Enter_PG_Subjects, [PG_Percentage] = @PG_Percentage, [Any_Other_Qualification] = @Any_Other_Qualification, " & _
                                    "[Other_Qualifiacation_Percentage] = @Other_Qualifiacation_Percentage, [Occupation] = @Occupation, [Job_Type] = @Job_Type, " & _
                                    "[Department] = @Department, [Designation] = @Designation, [Reason] = @Reason  where [Member_Registration_ID] = @RegistrationID", con)

        con.Open()
        cmd.Parameters.AddWithValue("@Qualification", CType(ComboBoxQualification.Text, String))
        cmd.Parameters.AddWithValue("@Under_Matriculation_Percentage", CType(TextBoxUnderMatricPercent.Text, String))
        cmd.Parameters.AddWithValue("@Matriculation_Percentage", CType(TextBoxMatricPercent.Text, String))

        cmd.Parameters.AddWithValue("@Hr_Secondary_Stream", CType(ComboBoxHrSecStream.Text, String))
        cmd.Parameters.AddWithValue("@Any_Other_Hr_Sec_Stream", CType(TextBoxAnyOtherHrSecStreamName.Text, String))
        cmd.Parameters.AddWithValue("@Enter_Subject", CType(TextBoxHrSecSubjects.Text, String))
        cmd.Parameters.AddWithValue("@Hr_Secondary_Percentage", CType(TextBoxHrSecPercentage.Text, String))

        cmd.Parameters.AddWithValue("@Graduation_Stream", CType(ComboBoxGraduationStream.Text, String))
        cmd.Parameters.AddWithValue("@Any_Other_Graduation_Stream", CType(TextBoxAnyOtherGraduationStream.Text, String))
        cmd.Parameters.AddWithValue("@Graduation_Subjects", CType(TextBoxGraduationSubjects.Text, String))
        cmd.Parameters.AddWithValue("@Graduation_Percentage", CType(TextBoxGraduationParcentage.Text, String))

        cmd.Parameters.AddWithValue("@PG_Stream", CType(ComboBoxPGStream.Text, String))
        cmd.Parameters.AddWithValue("@Any_Other_PG_Stream", CType(TextBoxAnyOtherPGStream.Text, String))
        cmd.Parameters.AddWithValue("@Enter_PG_Subjects", CType(TextBoxPGSubjects.Text, String))
        cmd.Parameters.AddWithValue("@PG_Percentage", CType(TextBoxPGPercentage.Text, String))

        cmd.Parameters.AddWithValue("@Any_Other_Qualification", CType(TextBoxOtherQual.Text, String))
        cmd.Parameters.AddWithValue("@Other_Qualification_Percentage", CType(TextBoxMoreQualPercent.Text, String))

        cmd.Parameters.AddWithValue("@Occupation", CType(ComboBoxOccupation.Text, String))
        cmd.Parameters.AddWithValue("@Job_Type", CType(ComboBoxOccupationType.Text, String))
        cmd.Parameters.AddWithValue("@Department", CType(TextBoxOccupationDepartment.Text, String))
        cmd.Parameters.AddWithValue("@Designation", CType(TextBoxOccupationDesignation.Text, String))

        cmd.Parameters.AddWithValue("@Reason", CType(TextBoxReason.Text, String))

        cmd.Parameters.AddWithValue("@RegistrationID", TextBox1.Text)

        Try

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("Record Saved")
        FormAddMember.Show()
        Me.Close()
        FormAddMember.Show()
        FormAddMember.Focus()
    End Sub

   
End Class