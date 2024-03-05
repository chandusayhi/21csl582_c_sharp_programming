# Setting up C\# Development Environment  
To write and compile C# programs on Ubuntu 22.04, you can use the .NET SDK, which is a free, open-source, and cross-platform framework for building modern, cloud-based, and internet-connected applications. Here are the steps to set up your environment and write/compile C# programs:

[[_TOC_]]

## Install .NET SDK:  
Open a terminal and follow these steps to install the .NET SDK:  
First let us add the Microsoft package repository  
**`$ wget https://packages.microsoft.com/config/ubuntu/22.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb`**  
**`$ sudo dpkg -i packages-microsoft-prod.deb`**  

Next let us install the .NET SDK, next run the following commands in the terminal.  
**`$ sudo apt update`**  
**`$ sudo apt install -y apt-transport-https`**  
**`$ sudo apt update`**  
**`$ sudo apt install -y dotnet-sdk-8.0`**  

# Compiling & Execution  

## Create a New Project: 
Enter the following command to create a new project, the last parameter is your Project Name.   
**`$ dotnet new console -n HelloCSharp`**  

You can see a HelloCSharp folder created in your current directory. It will contain a file **Program.cs** that has a simple Hello World program. You can edit this file to write your own program.  
Let us write the following code in the **Program.cs** file. 

```
using System;  
  
class Program  
{  
    static void Main()  
    {  
        Console.WriteLine("Hello, Ubuntu 22.04!");  
    }  
}  
```

Now save the file.  

## Compiling the C\# program  
To compile the C\# program, use the following command:  

**`$ dotnet build -o out HelloCSharp.csproj`**

## Execution
To execute the C\# program, use the following command:  

**`$ ./out/HelloCSharp`**





