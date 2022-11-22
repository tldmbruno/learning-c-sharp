// PROGRAM to render rectangles in the console

// Function to get user string input and convert to int
int ReadNumber(){
	return Convert.ToInt32(Console.ReadLine());
}

// Get width value
Console.Write("Width: ");
int width = ReadNumber();

// Get height value
Console.Write("Height: ");
int height = ReadNumber();

// Render the rectangle
for(int i = 0; i < height; i++) {
	for(int j = 0; j < width; j++){
		Console.Write("[]");
	}
	Console.WriteLine("");
}

// Wait for keypress to exit
Console.Read();
return 0;