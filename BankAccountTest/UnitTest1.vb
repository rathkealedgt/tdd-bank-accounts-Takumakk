Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestConstructors()
        'arrange 
        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = "4.3"
        Dim Balance As Double = "10343.82"
        Dim CountryOfOrigin As String = "Isle of Man"

        'act 
        Dim account1 As New BankAccounts.Accounts(AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)
        Dim account2 As New BankAccounts.Accounts(AccountHolder, AccountNumber, Balance, InterestRate)
        Dim account3 As New BankAccounts.Accounts(AccountHolder, AccountNumber, Balance)


        'assert
        Assert.IsNotNull(account1)
        Assert.IsNotNull(account2)
        Assert.IsNotNull(account3)


    End Sub

    <TestMethod()> Public Sub TestGetAccountHolder()
        'arrange 
        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = "4.3"
        Dim Balance As Double = "10343.82"
        Dim CountryOfOrigin As String = "Isle of Man"

        Dim account1 As New BankAccounts.Accounts(AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)

        'act 
        Dim Name As String = account1.GetAccountHolder()

        'assert
        Assert.AreEqual(Name, "Ms I. N. Cognito")

    End Sub

    <TestMethod()> Public Sub TestGetAccountNumber()
        'arrange 
        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = "4.3"
        Dim Balance As Double = "10343.82"
        Dim CountryOfOrigin As String = "Isle of Man"

        Dim account1 As New BankAccounts.Accounts(AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)

        'act 
        Dim Name As String = account1.GetAccountNumber()

        'assert
        Assert.AreEqual(Name, "ABCD 890111 11167890")

    End Sub

    <TestMethod()> Public Sub TestGetInterestRate()
        'arrange 
        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = "4.3"
        Dim Balance As Double = "10343.82"
        Dim CountryOfOrigin As String = "Isle of Man"

        Dim account1 As New BankAccounts.Accounts(AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)

        'act 
        Dim Rate As String = account1.GetInterestRate()

        'assert
        Assert.AreEqual(Rate, "4.3")

    End Sub

    <TestMethod()> Public Sub TestGetBalance()
        'arrange 
        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = "4.3"
        Dim Balance As Double = "10343.82"
        Dim CountryOfOrigin As String = "Isle of Man"

        Dim account1 As New BankAccounts.Accounts(AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)

        'act 
        Dim Rate As String = account1.GetBalance()

        'assert
        Assert.AreEqual(Rate, "10343.82")

    End Sub

    <TestMethod()> Public Sub TestGetCountry()
        'arrange 
        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = "4.3"
        Dim Balance As Double = "10343.82"
        Dim CountryOfOrigin As String = "Isle of Man"

        Dim account1 As New BankAccounts.Accounts(AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)

        'act 
        Dim Country As String = account1.GetCountryOfOrigin()

        'assert
        Assert.AreEqual(Country, "Isle of Man")

    End Sub

    <TestMethod()> Public Sub TestSetInterestRate()
        'arrange 
        Dim account1 As BankAccounts.Accounts = Me.NewAccount()

        'Act 
        account1.SetInterestRate(0.051)

        'Assert 
        Assert.AreEqual(0.051, account1.GetInterestRate())

    End Sub

    <TestMethod()> Public Sub TestSetAccountNumber()
        'arrange 
        Dim account1 As BankAccounts.Accounts = Me.NewAccount()

        'Act 
        account1.SetAccountNumber("ABCD 0000 9999")

        'Assert 
        Assert.AreEqual("ABCD 0000 9999", account1.GetAccountNumber())

    End Sub

    <TestMethod()> Public Sub TestSetAccountHolder()
        'arrange 
        Dim account1 As BankAccounts.Accounts = Me.NewAccount()

        'Act 
        account1.SetAccountHolder("Takuma Kaneko")

        'Assert 
        Assert.AreEqual("Takuma Kaneko", account1.GetAccountHolder())

    End Sub

    <TestMethod()> Public Sub TestSetCountry()
        'arrange 
        Dim account1 As BankAccounts.Accounts = Me.NewAccount()

        'Act 
        account1.SetCountry("NewZealand")

        'Assert 
        Assert.AreEqual("NewZealand", account1.GetCountryOfOrigin())

    End Sub

    <TestMethod()> Public Sub TestSetBalance()
        'arrange 
        Dim account1 As BankAccounts.Accounts = Me.NewAccount()

        'Act 
        account1.SetBalance(10000.9)

        'Assert 
        Assert.AreEqual(10000.9, account1.GetBalance())

    End Sub

    <TestMethod()> Public Sub TestApplyInterestRate()
        'arrange 
        Dim account1 As BankAccounts.Accounts = Me.NewAccount()

        'Act 
        account1.ApplyInterestRate()

        'Assert 
        Assert.AreEqual(10380.89, account1.GetBalance())

    End Sub
    Public Function NewAccount() As BankAccounts.Accounts
        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 0.043
        Dim Balance As Double = 10343.82
        Dim CountryOfOrigin As String = "Isle of Man"

        Return New BankAccounts.Accounts(AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)
    End Function

    <TestMethod()> Public Sub TestToString()
        'arrange 
        Dim ExpectedValueString As New StringBuilder
        ExpectedValueString.Append("Ms I. N. Cognito" + vbCrLf)
        ExpectedValueString.Append("ABCD 890111 11167890" + vbCrLf)
        ExpectedValueString.Append("0.043" + vbCrLf)
        ExpectedValueString.Append("10343.82" + vbCrLf)
        ExpectedValueString.Append("Isle of Man" + vbCrLf)

        Dim account1 As BankAccounts.Accounts = NewAccount()
        'Console.WriteLine(account1)

        'Act 
        Dim ActualString = account1.ToString()
        Console.WriteLine(ActualString)

        'Assert 
        Assert.AreEqual(ExpectedValueString.ToString(), ActualString)

    End Sub



End Class
