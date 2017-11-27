Module Module1
    Public Function grayscale(ByVal img As Image) As Boolean
        Dim cm As Imaging.ColorMatrix = New Imaging.ColorMatrix(New Single()() _
                               {New Single() {0.299, 0.299, 0.299, 0, 0},
                                New Single() {0.587, 0.587, 0.587, 0, 0},
                                New Single() {0.114, 0.114, 0.114, 0, 0},
                                New Single() {0, 0, 0, 1, 0},
                                New Single() {0, 0, 0, 0, 1}})


        Return draw_adjusted_image(img, cm)

    End Function
End Module
