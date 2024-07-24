using System;
using System.IO;

class ProperlyHandleExceptionsDay15
{
    
    static void Main(string[] args)
    {
        FileStream fileStream = null;
        try
        {
            string filePath = "example.txt";
            // Initialize FileStream with appropriate FileMode and FileAccess
            fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            
            using (StreamReader reader = new StreamReader(fileStream))
            {
                // Read the entire content of the file
                string fileContent = reader.ReadToEnd();
                Console.WriteLine(fileContent);
            }
        }
        catch (FileNotFoundException ex)
        {
            // Handle file not found error
            Console.WriteLine("Error: File not found. Details: " + ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            // Handle directory not found error
            Console.WriteLine("Error: Directory not found. Details: " + ex.Message);
        }
        catch (IOException ex)
        {
            // Handle IO exception
            Console.WriteLine("Error: IO exception occurred. Details: " + ex.Message);
        }
        finally
        {
            // Ensure file is closed and resources are cleaned up
            if (fileStream != null)
            {
                // Close and dispose of the FileStream
                fileStream.Close();
                fileStream.Dispose();
            }
        }
    }
}
