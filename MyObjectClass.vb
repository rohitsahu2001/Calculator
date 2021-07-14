Public Class MyObjectClass
    Function Plus(ByVal FNumber As Double, ByVal SNumber As Double) As Double
        Dim Result As Double
        Result = FNumber + SNumber
        Plus = Result
    End Function
    Function Minus(ByVal FNumber As Double, ByVal SNumber As Double) As Double
        Dim Result As Double
        Result = FNumber - SNumber
        Minus = Result
    End Function
    Function Multiply(ByVal FNumber As Double, ByVal SNumber As Double) As Double
        Dim Result As Double
        Result = FNumber * SNumber
        Multiply = Result
    End Function
    Function Division(ByVal FNumber As Double, ByVal SNumber As Double) As Double
        Dim Result As Double
        Result = FNumber / SNumber
        Division = Result
    End Function
End Class
