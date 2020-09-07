Public Class operation
    Dim v As New List(Of vertices)
    Dim listPoly As New List(Of Polygon)

    Public radius, dTeta, dVarphi As Double
    Public nLong As Integer
    Public nLat As Integer
    Public r As Double = -0.002 '-1/zc

    Public m As New matrix

    Public dop(2), translate(2), rotate(2) As Double

    Public Sub main()
        dTeta = 360 / nLong
        dVarphi = 90 / nLat

        listVertex()
        calVT()

        listPolygon()

        Dim C = Color.FromArgb(255, Color.Yellow)

        FormSphere.PictureBox.Image = FormSphere.Bit
    End Sub

    Public Sub calVT()
        For i = 0 To 2
            rotate(i) = -rotate(i)
        Next

        Dim mRotate(3)() As Double
        mRotate(0) = New Double(3) {}
        mRotate(0)(0) = Math.Cos(rotate(1)) * Math.Cos(rotate(2))
        mRotate(0)(1) = -Math.Cos(rotate(1)) * Math.Sin(rotate(2))
        mRotate(0)(2) = Math.Sin(rotate(1))
        mRotate(0)(3) = 0

        mRotate(1) = New Double(3) {}
        mRotate(1)(0) = Math.Sin(rotate(0)) * Math.Sin(rotate(1)) * Math.Cos(rotate(2)) + Math.Cos(rotate(0)) * Math.Sin(rotate(2))
        mRotate(1)(1) = -Math.Sin(rotate(0)) * Math.Sin(rotate(1)) * Math.Sin(rotate(2)) + Math.Cos(rotate(0)) * Math.Cos(rotate(2))
        mRotate(1)(2) = -Math.Sin(rotate(0)) * Math.Cos(rotate(1))
        mRotate(1)(3) = 0

        mRotate(2) = New Double(3) {}
        mRotate(2)(0) = -Math.Cos(rotate(0)) * Math.Sin(rotate(1)) * Math.Cos(rotate(2)) + Math.Sin(rotate(0)) * Math.Sin(rotate(2))
        mRotate(2)(1) = Math.Cos(rotate(0)) * Math.Sin(rotate(1)) * Math.Sin(rotate(2)) + Math.Sin(rotate(0)) * Math.Cos(rotate(2))
        mRotate(2)(2) = Math.Cos(rotate(0)) * Math.Cos(rotate(1))
        mRotate(2)(3) = 0

        mRotate(3) = New Double(3) {}
        mRotate(3)(0) = 0
        mRotate(3)(1) = 0
        mRotate(3)(2) = 0
        mRotate(3)(3) = 1

        Dim VT(3)() As Double
        VT(0) = New Double() {1, 0, 0, 0}
        VT(1) = New Double() {0, 1, 0, 0}
        VT(2) = New Double() {0, 0, 1, r}
        VT(3) = New Double() {translate(0), translate(1), translate(2), 1 + r * translate(2)}

        VT = m.matrixMul44(mRotate, VT)

        For Each vertex In v
            vertex.v = m.matrixMul14(vertex.v, VT)
            vertex.v(0) = vertex.v(0) / vertex.v(3)
            vertex.v(1) = vertex.v(1) / vertex.v(3)
            vertex.v(2) = vertex.v(2) / vertex.v(3)

            'FormSphere.G.DrawLine(Pens.Black, CInt(vertex.v(0) + 200), CInt(vertex.v(1) + 200), CInt(vertex.v(0) + 201), CInt(vertex.v(1) + 200))
        Next

    End Sub

    Public Sub reset()
        FormSphere.G.Clear(Color.White)
        listPoly.Clear()
        v.Clear()
    End Sub

    'Procedure for the coordinates of the vertices
    Private Function calVertex(ByVal teta As Double, ByVal varphi As Double) As List(Of Double)
        Dim x, y, z, d As Double
        Dim vertices As New List(Of Double)
        Dim aVarphi, aTeta As Double

        aVarphi = Math.PI * varphi / 180.0
        aTeta = Math.PI * teta / 180.0
        y = radius * Math.Sin(aVarphi)
        d = radius * Math.Cos(aVarphi)
        x = d * Math.Sin(aTeta)
        z = d * Math.Cos(aTeta)

        vertices.Add(x)
        vertices.Add(y)
        vertices.Add(z)

        Return vertices
    End Function

    Private Sub listVertex()
        Dim n As Integer = 0
        Dim teta As Double
        Dim varphi As Double

        'down
        For j = 0 To nLat - 1
            For i = 0 To nLong - 1
                varphi = j * dVarphi
                teta = i * dTeta

                v.Add(New vertices)
                v(n).newVertices(calVertex(teta, varphi).Item(0), calVertex(teta, varphi).Item(1), calVertex(teta, varphi).Item(2))
                n = n + 1
            Next
        Next
        v.Add(New vertices)
        v(n).newVertices(0, radius, 0)
        n = n + 1

        'up
        For j = 1 To nLat - 1
            For i = 0 To nLong - 1
                varphi = j * dVarphi
                teta = i * dTeta

                v.Add(New vertices)
                v(n).newVertices(calVertex(teta, varphi).Item(0), -calVertex(teta, varphi).Item(1), calVertex(teta, varphi).Item(2))
                n = n + 1
            Next
        Next
        v.Add(New vertices)
        v(n).newVertices(0, -radius, 0)
    End Sub

    Private Sub listPolygon()
        Dim k As Integer
        Dim n As Integer = 0

        'up
        For j = 0 To nLat - 2
            k = j * nLong
            For i = 0 To nLong - 2

                listPoly.Add(New Polygon)
                listPoly(n).newPolygon(v(i + k), v(i + k + 1), v(i + k + nLong + 1))
                n = n + 1

                listPoly.Add(New Polygon)
                listPoly(n).newPolygon(v(i + k), v(i + k + nLong + 1), v(i + k + nLong))
                n = n + 1
            Next

            listPoly.Add(New Polygon)
            listPoly(n).newPolygon(v(k + nLong - 1), v(k), v(k + nLong))
            n = n + 1

            listPoly.Add(New Polygon)
            listPoly(n).newPolygon(v(k + nLong - 1), v(k + nLong), v(k + 2 * nLong - 1))
            n = n + 1
        Next

        For i = (nLat - 1) * nLong To nLat * nLong - 2

            listPoly.Add(New Polygon)
            listPoly(n).newPolygon(v(i), v(i + 1), v(nLat * nLong))
            n = n + 1
        Next

        listPoly.Add(New Polygon)
        listPoly(n).newPolygon(v(nLat * nLong - 1), v((nLat - 1) * nLong), v(nLat * nLong))
        n = n + 1

        'down
        Dim l As Integer = nLat * nLong + 1
        For j = 0 To nLat - 2
            k = j * nLong
            For i = 0 To nLong - 2

                If j = 0 Then
                    listPoly.Add(New Polygon)
                    listPoly(n).newPolygon(v(i + l + k), v(i + l + 1 + k), v(i + 1 + k))
                    n = n + 1

                    listPoly.Add(New Polygon)
                    listPoly(n).newPolygon(v(i + l + k), v(i + 1 + k), v(i + k))
                    n = n + 1

                Else
                    listPoly.Add(New Polygon)
                    listPoly(n).newPolygon(v(i + k + l), v(i + k + 1 + l), v(i + k + 1 + l - nLong))
                    n = n + 1

                    listPoly.Add(New Polygon)
                    listPoly(n).newPolygon(v(i + k + l), v(i + k + 1 + l - nLong), v(i + k + l - nLong))
                    n = n + 1
                End If

            Next

            If j = 0 Then
                listPoly.Add(New Polygon)
                listPoly(n).newPolygon(v(l + nLong - 1), v(l), v(0))
                n = n + 1

                listPoly.Add(New Polygon)
                listPoly(n).newPolygon(v(l + nLong - 1), v(0), v(nLong - 1))
                n = n + 1
            Else
                listPoly.Add(New Polygon)
                listPoly(n).newPolygon(v(l + nLong - 1 + k), v(k + l), v(k + l - nLong))
                n = n + 1

                listPoly.Add(New Polygon)
                listPoly(n).newPolygon(v(l + nLong - 1 + k), v(k + l - nLong), v(l - 1 + k))
                n = n + 1
            End If

        Next

        Dim idxDown = nLong * (2 * nLat - 1) + 1

        For i = 2 * nLong * (nLat - 1) To nLong * (2 * nLat - 1) - 1
            listPoly.Add(New Polygon)
            listPoly(n).newPolygon(v(i), v(idxDown), v(i + 1))
            n = n + 1
        Next
        listPoly.Add(New Polygon)
        listPoly(n).newPolygon(v(idxDown - 1), v(idxDown), v(idxDown - nLong))

    End Sub
End Class

'Vertices Class
Public Class vertices
    Public v(3) As Double

    Public Sub newVertices(ByVal x As Double, ByVal y As Double, ByVal z As Double)
        Me.v(0) = x
        Me.v(1) = y
        Me.v(2) = z
        Me.v(3) = 1
    End Sub

End Class

Public Class Polygon
    Public v1, v2, v3 As vertices
    Public normal(3) As Double
    Public dotProduct As Double
    Public m As New matrix

    Public Sub newPolygon(ByVal v1 As vertices, ByVal v2 As vertices, ByVal v3 As vertices)
        Me.v1 = v1
        Me.v2 = v2
        Me.v3 = v3

        normal = calculateNormal()
        dotProduct = m.dot(FormSphere.op.dop, normal)
        drawPoly()
    End Sub

    'calculate normal
    Public Function calculateNormal() As Double()
        Dim vector1(2), vector2(2), normal(2) As Double

        vector1 = m.matrixMin33(v1.v, v2.v)
        vector2 = m.matrixMin33(v2.v, v3.v)

        normal = m.cross(vector1, vector2)

        Return normal
    End Function

    'draw polygon
    Public Sub drawPoly()
        If FormSphere.flagCulling Then
            If (dotProduct < 0) Then
                FormSphere.G.DrawLine(Pens.Black, CInt(v1.v(0) + FormSphere.xCenter), CInt(-v1.v(1) + FormSphere.yCenter), CInt(v2.v(0) + FormSphere.xCenter), CInt(-v2.v(1) + FormSphere.yCenter))
                FormSphere.G.DrawLine(Pens.Black, CInt(v2.v(0) + FormSphere.xCenter), CInt(-v2.v(1) + FormSphere.yCenter), CInt(v3.v(0) + FormSphere.xCenter), CInt(-v3.v(1) + FormSphere.yCenter))
                FormSphere.G.DrawLine(Pens.Black, CInt(v3.v(0) + FormSphere.xCenter), CInt(-v3.v(1) + FormSphere.yCenter), CInt(v1.v(0) + FormSphere.xCenter), CInt(-v1.v(1) + FormSphere.yCenter))
            End If
        Else
            FormSphere.G.DrawLine(Pens.Black, CInt(v1.v(0) + FormSphere.xCenter), CInt(-v1.v(1) + FormSphere.yCenter), CInt(v2.v(0) + FormSphere.xCenter), CInt(-v2.v(1) + FormSphere.yCenter))
            FormSphere.G.DrawLine(Pens.Black, CInt(v2.v(0) + FormSphere.xCenter), CInt(-v2.v(1) + FormSphere.yCenter), CInt(v3.v(0) + FormSphere.xCenter), CInt(-v3.v(1) + FormSphere.yCenter))
            FormSphere.G.DrawLine(Pens.Black, CInt(v3.v(0) + FormSphere.xCenter), CInt(-v3.v(1) + FormSphere.yCenter), CInt(v1.v(0) + FormSphere.xCenter), CInt(-v1.v(1) + FormSphere.yCenter))
        End If
    End Sub
End Class