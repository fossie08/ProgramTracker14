'
' Created by SharpDevelop.
' User: 19ofoster
' Date: 08/11/2021
' Time: 14:02
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	Sub Main()
		'Dimension the variables
		Dim nth As Int64 = 0
		Dim sorc As String = ""
		Dim square As Double = 0
		Dim cube As Double = 0
		Dim answer(500000) As Long
		
		'User inputs the required data
		Console.WriteLine("Please enter s for squared numbers and c for cubed numbers . . . ")
		sorc = Console.ReadLine()
		
		Console.WriteLine("Please enter the nth term . . . ")
		nth = Console.ReadLine()
		nth = nth + 1
		
		'Working out the squares
		If sorc = "s" Then
			For c=0 To nth Step + 1
				square = c ^ 2
				answer(c) = square
			Next
		End If
		
		'Working out the cubes
		If sorc = "c" Then
			For c=0 To nth Step + 1
				cube = c ^ 3
				answer(c) = cube
			Next
		End If
		
		'Displaying the answer to the user
		For c=0 To nth
			c=c+1
			Console.WriteLine(answer(c))
		Next
		
		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
End Module
