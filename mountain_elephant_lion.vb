Public Class MindOasis
	
	'Declare global variables
	Private intAge As Integer	
	Private dblGPA As Double
	
	'Main method
	Sub Main()
		'Welcome the user
		Console.WriteLine("Welcome to the Mind Oasis!")
		
		'Prompt user to enter their age
		Console.Write("Please enter your age: ")
		intAge = Integer.Parse(Console.ReadLine())
		
		'Prompt user to enter their GPA
		Console.Write("Please enter your GPA: ")
		dblGPA = Double.Parse(Console.ReadLine())
		
		'Check if user meets age requirement
		If intAge < 18 Then
			Console.WriteLine("Sorry, you must be 18 years or older to use Mind Oasis.")
		Else
			'Check if user meets GPA requirement
			If dblGPA < 3.0 Then
				Console.WriteLine("Sorry, you must have a GPA of 3.0 or higher to use Mind Oasis.")
			Else
				Console.WriteLine("Congratulations! You have qualified to use Mind Oasis!")
			End If
		End If
		
		'Let the user know what to expect
		Console.WriteLine("Mind Oasis offers a variety of stress relief activities that you can do to relax your mind and body.")
		
		'List the activities
		Console.WriteLine("Here are the available activities:")
		Console.WriteLine("1. Meditation")
		Console.WriteLine("2. Yoga")
		Console.WriteLine("3. Tai Chi")
		Console.WriteLine("4. Nature walks")
		Console.WriteLine("5. Journaling")
		Console.WriteLine("6. Coloring")
		
		'Prompt user to choose an activity
		Console.Write("Please choose an activity (1-6): ")
		Dim intChoice As Integer = Integer.Parse(Console.ReadLine())
		
		'Provide instructions for the activity
		Select Case intChoice
			Case 1
				Console.WriteLine("For meditation, sit quietly in a comfortable spot. Close your eyes and focus on your breathing. Try to clear your mind of all thoughts.")
			Case 2
				Console.WriteLine("For yoga, find a comfortable spot in a room with enough space to move. Follow along with an online yoga session, focusing on your breathing and posture.")
			Case 3
				Console.WriteLine("For tai chi, follow along with an online tai chi session, focusing on the slow, gentle movements and concentrating on your breathing.")
			Case 4
				Console.WriteLine("For nature walks, go outside and explore a nearby park or natural area. Take in the sights, sounds, and smells around you.")
			Case 5
				Console.WriteLine("For journaling, find a comfortable spot and grab a pen and paper. Write down your thoughts, feelings, and experiences.")
			Case 6
				Console.WriteLine("For coloring, find a coloring book or printable coloring page. Find a crayon, colored pencil, or marker and start coloring.")
		End Select
		
		'Encourage the user to do the activity
		Console.WriteLine("We hope you enjoy your chosen activity. Have fun!")
		
	End Sub
	
End Class