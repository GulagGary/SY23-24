Public Class CoinSlot
    Public Property Quarters As Integer
    Public Property Nickels As Integer
    Public Property Dimes As Integer
    Public Property Dollars As Integer
    Dim _total As Decimal
    Public ReadOnly Property total As Decimal
        Get
            _total = Nickels * 0.05 + Dimes * 0.1 + Quarters * 0.25 + Dollars * 1
            Return _total
        End Get
    End Property
    Public Sub insertquarter()
        Quarters += 1
    End Sub
    Public Sub insertnickels()
        Nickels += 1
    End Sub
    Public Sub insertdimes()
        Dimes += 1
    End Sub
    Public Sub insertdollars()
        Dollars += 1
    End Sub
    Public Sub Coinreturn()
        RaiseEvent Coinreturnevent(Dollars, Quarters, Dimes, Nickels)
        Dollars = 0
        Quarters = 0
        Dimes = 0
        Nickels = 0
    End Sub
    Public Sub buy(p As productcontrol)
        If p.productcount > 0 And p.productprice <
                _total = _total - p.productprice Then
            p.buy
        End If
    End Sub
End Class
