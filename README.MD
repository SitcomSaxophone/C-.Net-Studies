#Terminal Compiling Instructions

While in project directory type line:

mcs -out:-Output File- -File to be compiled-

Example: mcs -out:hello.exe hello.cs

To execute compiled code type the following: 

mono -Output File- 

Example:

mono hello.exe