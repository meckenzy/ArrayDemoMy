Public Class Form1
    'Declare a form level array
    Private strFriends(4) As String

    Private Sub btnArrayElement_Click(sender As Object, e As EventArgs) Handles btnArrayElement.Click

        'Clear the list
        ClearList()

        'Declare an array
        Dim strFriends(4) As String

        'Populate the array
        strFriends(0) = "Josette"
        strFriends(1) = "Sindy"
        strFriends(2) = "Sophia"
        strFriends(3) = "Clint"
        strFriends(4) = "Muffin"

        'Add the first array item to the list
        lstFriends.Items.Add(strFriends(0))
    End Sub

    Private Sub ClearList()
        'Clear the list
        lstFriends.Items.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Populate the array
        strFriends(0) = "Zuba"
        strFriends(1) = "Serge"
        strFriends(2) = "Marcus"
        strFriends(3) = "Florence"
        strFriends(4) = "Sabrina"
    End Sub

    Private Sub btnEnumerateArray_Click(sender As Object, e As EventArgs) Handles btnEnumerateArray.Click
        'Clear the list
        ClearList()

        'Enumerate the array
        For Each strName As String In strFriends
            'Add the array item to the list
            lstFriends.Items.Add(strName)
        Next
    End Sub

    Private Sub btnArraysAsParameters_Click(sender As Object, e As EventArgs) Handles btnArraysAsParameters.Click
        'Clear the list
        ClearList()

        'List your friends
        AddItemsToList(strFriends)
    End Sub

    Private Sub AddItemsToList(ByVal arrayList As String())
        'Enumerate the array
        For Each strName As String In arrayList
            'Add the array item to the list
            lstFriends.Items.Add(strName)
        Next
    End Sub

    Private Sub btnMoreArrayParameters_Click(sender As Object, e As EventArgs) Handles btnMoreArrayParameters.Click
        'Clear the list
        ClearList()

        'Declare an array
        Dim strMoreFriends(1) As String

        'Populate the array
        strMoreFriends(0) = "Entoine"
        strMoreFriends(1) = "Vincent"

        'List your friends
        AddItemsToList(strFriends)
        AddItemsToList(strMoreFriends)
    End Sub

    Private Sub btnSortingArrays_Click(sender As Object, e As EventArgs) Handles btnSortingArrays.Click
        'clear the list, sort your array and add list your friends
        ClearList()
        Array.Sort(strFriends)
        AddItemsToList(strFriends)
    End Sub

    Private Sub btnReversingAnArray_Click(sender As Object, e As EventArgs) Handles btnReversingAnArray.Click
        ClearList()
        Array.Reverse(strFriends)
        AddItemsToList(strFriends)
    End Sub

    Private Sub btnInitializingArrayWithValues_Click(sender As Object, e As EventArgs) Handles btnInitializingArrayWithValues.Click
        ClearList()
        Dim strMyFriends() As String = {"Jordynn", "Alex", "Kurt", "Charlene"}
        AddItemsToList(strMyFriends)
    End Sub
End Class
