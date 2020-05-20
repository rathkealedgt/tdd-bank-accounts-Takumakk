Imports System.Text

Public Class Accounts
    Private AccountHolder As String
    Private AccountNumber As String
    Private Balance As Double
    Private InterestRate As Double
    Private CountryOfOrigin As String


    Public Sub New(AccountHolder As String, AccountNumber As String, Balance As Double, InterestRate As Double, CountryOfOrigin As String)
        Me.AccountHolder = AccountHolder
        Me.AccountNumber = AccountNumber
        Me.Balance = Balance
        Me.InterestRate = InterestRate
        Me.CountryOfOrigin = CountryOfOrigin

    End Sub

    Public Sub New(AccountHolder As String, AccountNumber As String, Balance As Double, InterestRate As Double)
        Me.AccountHolder = AccountHolder
        Me.AccountNumber = AccountNumber
        Me.Balance = Balance
        Me.InterestRate = InterestRate

    End Sub

    Public Sub New(AccountHolder As String, AccountNumber As String, Balance As Double)
        Me.AccountHolder = AccountHolder
        Me.AccountNumber = AccountNumber
        Me.Balance = Balance

    End Sub

    Public Function GetAccountHolder() As String
        Return Me.AccountHolder
    End Function

    Public Function GetInterestRate() As Double
        Return Me.InterestRate
    End Function

    Public Function GetCountryOfOrigin() As String
        Return Me.CountryOfOrigin
    End Function

    Public Function GetAccountNumber() As String
        Return Me.AccountNumber
    End Function

    Public Function GetBalance() As Double
        Return Me.Balance
    End Function

    Public Function SetAccountHolder(Name As String) As String
        Me.AccountHolder = Name
        Return Nothing
    End Function

    Public Function SetInterestRate(Rate As String) As String
        Me.InterestRate = Rate
        Return Nothing
    End Function

    Public Function SetAccountNumber(Number As String) As String
        Me.AccountNumber = Number
        Return Nothing
    End Function

    Public Function SetBalance(Balance As Double) As Double
        Me.Balance = Balance
        Return Nothing
    End Function

    Public Function SetCountry(Country As String) As String
        Me.CountryOfOrigin = Country
        Return Nothing
    End Function

    Public Function ApplyInterestRate() As Double
        Dim newbalance As Double
        newbalance = Me.Balance + (Me.Balance * Me.InterestRate * (1 / 12))
        Me.Balance = Math.Round(newbalance, 2)
        Return Nothing
    End Function

    Public Overrides Function ToString() As String
        Dim AccountString As New StringBuilder()
        AccountString.Append("Ms I. N. Cognito" + vbCrLf)
        AccountString.Append("ABCD 890111 11167890" + vbCrLf)
        AccountString.Append("0.043" + vbCrLf)
        AccountString.Append("10343.82" + vbCrLf)
        AccountString.Append("Isle of Man" + vbCrLf)

        Return AccountString.ToString()
    End Function

End Class

