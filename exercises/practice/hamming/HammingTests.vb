Imports System
Imports Xunit
Public Class HammingTest
    <Fact>
    Public Sub EmptyStrands()
        Assert.Equal(0, Distance("", ""))
    End Sub
    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub SingleLetterIdenticalStrands()
        Assert.Equal(0, Distance("A", "A"))
    End Sub
    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub SingleLetterDifferentStrands()
        Assert.Equal(1, Distance("G", "T"))
    End Sub
    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub LongIdenticalStrands()
        Assert.Equal(0, Distance("GGACTGAAATCTG", "GGACTGAAATCTG"))
    End Sub
    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub LongDifferentStrands()
        Assert.Equal(9, Distance("GGACGGATTCTG", "AGGACGGATTCT"))
    End Sub
    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub DisallowFirstStrandLonger()
        Assert.Throws(Of ArgumentException)(Function() Distance("AATG", "AAA"))
    End Sub
    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub DisallowSecondStrandLonger()
        Assert.Throws(Of ArgumentException)(Function() Distance("ATA", "AGTG"))
    End Sub
    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub DisallowLeftEmptyStrand()
        Assert.Throws(Of ArgumentException)(Function() Distance("", "G"))
    End Sub
    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub DisallowRightEmptyStrand()
        Assert.Throws(Of ArgumentException)(Function() Distance("G", ""))
    End Sub
End Class