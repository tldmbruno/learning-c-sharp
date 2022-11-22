using System;
using System.Collections.Generic;

// AUTHOR: Bruno Peres (@TheLastDarkMage)

class Program {
	static void Main(string[] args) {
		// String to remember the last save's filename
		String lastFilename = "list.txt";
		
		// List containing every line
		List<String> tasks = new List<String>();
		
		// Shows the commands the user can perform
		ShowCommands();
		
		// Continuity boolean for main loop
		bool quit = false;
		
		// Main loop
		while (!quit) {
			// Prints a prompt
			Console.Write(" > ");
			
			// Waits for user's command
			String command = Console.ReadLine();
			
			// Check for which command was typed, considering
			// simillar commands and wording.
			switch (command.ToLower()) {
				case "help":
				case "?":
				case "commands":
				case "man":
				case "h":
					ShowCommands();
					break;
				
				case "add":
				case "new":
				case "a":
				case "n":
					// Creates a new task
					String newTask = AddTaskItem();
					if (newTask != null) {
						tasks.Add(newTask);
					}
					break;
				
				case "remove":
				case "delete":
				case "r":
				case "rm":
					// Removal instructions
					Console.WriteLine(
						"Insert task number to REMOVE it. " + 
						"Leave it blank to cancel the operation. ");
						
					// Lists every task
					ListAll(tasks);
					
					// Asks task number for deletion
					Console.Write("Task Number: ");
					int taskNumber = Convert.ToInt32(Console.ReadLine()) - 1;
					
					// Removes the selected task, if it exists.
					if (tasks[taskNumber] != null) {
						// Asks for confirmation before deletion
						if (AskConfirmation(
								"Are you sure you want to remove " +
								"the task \"" + tasks[taskNumber] +
								"\"?")) {
							// Removes the respective task
							tasks.RemoveAt(taskNumber);
							Console.WriteLine(
								"Task item number " + (taskNumber + 1) +
								" has been removed. ");
						} else {
							Console.WriteLine(
								"Aborting... "
								);
						}
						
					} else {
						Console.WriteLine("Invalid task number. ");
					}
					break;
				
				case "list":
				case "ls":
				case "show":
				case "l":
					// Lists every task
					ListAll(tasks);
					break;
				
				case "sort":
				case "srt":
				case "organize":
					// Sorts the list alphabetically
					tasks.Sort();
					Console.WriteLine("Task list has been sorted. ");
					break;
				
				case "save":
				case "s":
				case "write":
				case "export":
					// Joins every line together in a single multiline string.
					String allTasks = "";
					
					foreach (String taskItem in tasks) {
						allTasks += (tasks.IndexOf(taskItem)+1) +
							". " + taskItem + "\n";
					}
					
					// Ask for filename, defaulting to list.txt or the last one
					Console.Write("Insert filename (" + lastFilename + "): ");
					String filename = Console.ReadLine();
					
					// Applies the default if empty
					if (filename == "") filename = lastFilename;
					
					// Remembers the last
					lastFilename = filename;
					
					// Saves the current list to a file, overwriting it.
					Console.WriteLine("Saving... ");
					System.IO.File.WriteAllText(@".\" + filename, allTasks);
					
					Console.WriteLine("File saved. ");
					break;
				
				case "quit":
				case "leave":
				case "exit":
				case "q":
					// Asks for confirmation				
					if (AskConfirmation("Are you sure you want to quit? ")) {
						// Quits the program
						Console.WriteLine("Quitting... ");
						quit = true;
					} else {
						Console.WriteLine("Ok then. ");
					}
					break;
				
				default:
					Console.WriteLine("Invalid command. ");
					break;
			}
		}
	}
	
	
	static void ShowCommands() {
		Console.WriteLine(
			"COMMANDS\n"+
			"\thelp = shows this commands list\n"+
			"\tadd = add a new task\n"+
			"\tremove = removes a task\n"+
			"\tlist = list all tasks\n"+
			"\tsort = sorts tasks alphabetically\n" +
			"\tsave = saves to a file\n" +
			"\tquit = quits without saving\n"
			);
	}
	
	
	// Method to list the content of a... list, in a numbered... list.
	static void ListAll(List<String> list) {
		foreach (String taskItem in list) {
			Console.WriteLine((list.IndexOf(taskItem)+1) +
				". " + taskItem);
		}
	}
	
	
	static String AddTaskItem() {
		Console.Write("New task: ");
		
		String newTask = Console.ReadLine();
		
		// If not an empty line, add the task
		if (newTask != "") {
			return newTask;
			Console.WriteLine("Task sucessfully added. ");
		} else {
			Console.WriteLine("Aborting... ");
			return null;
		}
	}
	
	
	static bool AskConfirmation(String question) {
		// Prints the question
		Console.WriteLine(question);
		
		// Tell the user about his options
		Console.WriteLine("Answer with (Y)es or (N)o. Default: No. ");
		Console.Write(" > ");
		
		String answer = Console.ReadLine();
		
		switch (answer.ToLower()) {
			// Although there was only two options, it's nice to have a 
			// program who understands us.
			case "y":
			case "yes":
			case "confirm":
			case "affirmative":
			case "please":
			case "ok":
			case "sim":
			case "si":
				return true;
			default:
				return false;
		}
	}
}