using System;
using System.Collections.Generic;
using ThirdPartyTools;

namespace FileData
{
    /// <summary>
    /// File Manager class initializes File Details object and runs functionality 
    /// using the RunFunctionality function.
    /// </summary>
    public class FileManager
    {
        //Fields
        private List<string> fileVersions = new List<string>() { "-v", "--v", "/v", "--version" };

        private List<string> fileSizes = new List<string>() { "-s", "--s", "/s", "--size" };

        public List<string> FileVersions { get { return fileVersions;  } }

        public List<string> FileSizes { get { return fileSizes; } }

        public FileDetails FileDetails { get; set; }

        /// <summary>
        /// Initializes FileDetails object
        /// </summary>
        public FileManager()
        {
            FileDetails = new FileDetails();
        }

        /// <summary>
        ///  The function checks to see if the "functionality" is part of the fileVersions
        ///  or fileSizes List. If the condition is true, calls the appropriate function, 
        ///  else throws an Arugment Exception
        /// </summary>
        /// <param name="functionality">represents the string of functionality to be performed</param>
        /// <param name="filePath">contains a string which represents the file location</param>
        /// <returns>string which represents the File Version or File Size</returns>
        public string RunFunctionality(string functionality, string filePath)
        {
            var result = "";

            if (FileVersions.Contains(functionality))
                result = FileDetails.Version(filePath);

            else if (FileSizes.Contains(functionality))
                result = FileDetails.Size(filePath).ToString();

            else
                throw new ArgumentException("Invalid Functionality!");

            return result; 
        }


    }
}
