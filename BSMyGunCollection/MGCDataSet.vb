

Partial Public Class MGCDataSet
    Partial Class Gun_CollectionDataTable

    End Class

    Partial Class Gun_Collection_AmmoDataTable

        Private Sub Gun_Collection_AmmoDataTable_ColumnChanging(ByVal sender As Object, ByVal e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.JacketColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace MGCDataSetTableAdapters
    
    Partial Public Class FullDetailsTableAdapter
    End Class
End Namespace
