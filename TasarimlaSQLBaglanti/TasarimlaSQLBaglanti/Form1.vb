Public Class Form1
    Private Sub MenuTablosuBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MenuTablosuBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MenuTablosuBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BilgiKafeDS)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BilgiKafeDS.MenuTablosu' table. You can move, or remove it, as needed.
        Me.MenuTablosuTableAdapter.Fill(Me.BilgiKafeDS.MenuTablosu)

    End Sub

    Private Sub MenuUrunAraToolStripButton_Click(sender As Object, e As EventArgs) Handles MenuUrunAraToolStripButton.Click
        Try
            Me.MenuTablosuTableAdapter.MenuUrunAra(Me.BilgiKafeDS.MenuTablosu, MenuUrunAdiToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
