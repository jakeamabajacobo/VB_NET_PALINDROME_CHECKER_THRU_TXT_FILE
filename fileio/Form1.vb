Imports System.Globalization
Imports System.IO
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub btn_load_Click(sender As Object, e As EventArgs) Handles btn_load.Click

        Dim FileDir = ""
        Dim openFileDilog As OpenFileDialog = New OpenFileDialog()
        Dim palinString As String
        Dim tempStr As String = ""
        Dim stringReader As String
        openFileDilog.Title = "Browse Text File"
        openFileDilog.InitialDirectory = "C:\\"
        openFileDilog.Filter = "Text Files|*.txt"
        openFileDilog.FilterIndex = 2
        openFileDilog.RestoreDirectory = True

        If openFileDilog.ShowDialog Then
            FileDir = openFileDilog.FileName
        End If

        If openFileDilog.FileNames IsNot "" Then

            Dim StmReader As StreamReader = New StreamReader(FileDir)
            Dim count As Integer = 1
            Try
                Do While StmReader.Peek() >= 0
                    stringReader = String.Empty
                    stringReader = StmReader.ReadLine

                    'CHECK PALINDROME FIRST LETTER:
                    If (CheckPalindromeLetters(stringReader)) Then

                        'CHECK PALINDROME WORDS AFTER REVERSING TEXT
                        palinString = StrReverse(stringReader)
                        If palinString.Equals(palinString) Then
                            'CHECK PALINDROME REVERSE:
                            If (CheckPlandromeLetterReverse(stringReader) = True) Then

                                'CHECK PALINDROME WHITESPACE AND CASE SENSITIVITY
                                If (CheckPalindromeWhiteSpaceAndCaseSentivitiy(stringReader, True, True) = True) Then
                                    tempStr &= stringReader & "-PALINDROME" & vbNewLine
                                End If

                            End If
                        End If
                    Else
                        tempStr &= stringReader & "-NOT PALINDROME" & vbNewLine
                    End If
                    ' Console.WriteLine(words)
                    count += 1
                Loop
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            txtbox1.Text = tempStr


        Else
            MessageBox.Show("Please Upload correct file!!")
            openFileDilog.Reset()
            txtbox1.Text = ""
        End If

    End Sub

    Public Function CheckPalindromeLetters(palinString As String)
        Dim intCurr As Integer = 0
        Dim intLength As Integer = palinString.Length - 1
        While intCurr < intLength
            If palinString(intCurr) <> palinString(intLength) Then
                Return False
            End If
            intCurr += 1
            intLength -= 1
        End While
        Return True
    End Function

    Public Function CheckPlandromeLetterReverse(strText As String)
        Dim blnPal As Boolean = True

        For i As Integer = 0 To strText.Length \ 2

            If strText(i) <> strText(strText.Length - i - 1) Then

                blnPal = False

                Exit For

            End If

        Next

        Return blnPal
    End Function


    Private Function CheckPalindromeWhiteSpaceAndCaseSentivitiy(ByVal strText As String,
        ByVal blnWhiteSpace As Boolean,
        ByVal blnCase As Boolean) As Boolean

        Dim scCompare As StringComparison = If(blnCase,
           StringComparison.CurrentCultureIgnoreCase,
           StringComparison.CurrentCulture)

        If blnWhiteSpace Then

            Return String.Equals(strText.Replace(" ", String.Empty),
               String.Join("", strText.Replace(" ", String.Empty) _
               .ToArray.Reverse), scCompare)

        Else

            Return String.Equals(strText, String.Join("",
               strText.ToArray.Reverse), scCompare)

        End If
    End Function
End Class
