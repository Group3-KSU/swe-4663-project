using System;

public class RequirementsGeneralInput
{

    public static void Main(String[] args)
    {
        String IntialUserAnswer;  //This will take in the first answer from the user.
        Console.WriteLine("Hello! Would you like open an old project? If so type the file location into the console, if starting a new project type NO."); // This will act as the question to the user.
        IntialUserAnswer = Console.ReadLine(); //This takes in the users answer.


        if (IntialUserAnswer == "NO") // if the user answer is intially no we will call startNewProject.
        {
            StartNewProject();
        }
        else
        {
            OpenOldFile(IntialUserAnswer);  // If the users answer is anything else we will call openold file to see if file is located.
        }






    }

    public void StartNewProject() //This is called if the user has no previous file. This will be responsible for asking all question , taking in user input, and calling save to file.
    {

    }
    public void OpenOldFile(String OldFileName) //This method will be used in the case that the user has already opened this and wants to view old information
    {
        //This will need a try catch to confirm file is there if not it will take in another user input to get correct file name.


    }

    public void SaveToFile() //This method will be used to save all information entered by user to a file which could be then opened.
    {

    }



}
