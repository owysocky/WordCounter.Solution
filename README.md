# _Word Count_

#### _2/15/2019_

#### By _**Olha Wysocky**_

## Description
_This is a program that counts how many times a word used in a sentance._

### Specs
| Behavior - Plain English | Input | Output |
| :-------------     | :------------- | :------------- |
| **The easiest behavior a program can possibly have - check if the user entered anything at all:** |
| **Program evaluates if there is no input** | User input: "" | "I am sorry, you've missed a line!" |
| **Next behavior a program can possibly have - compare one word to another, because it is easy to find one wordout of one:** |
| **Program matches word to word from a sentence** | User input: "a", "a" | 1 |
| **Program matches numerical input from a sentence** | User input: "1", "1" | 1 |
| **The program can compare to words regardless of the case:** |
| **Program matches word to word from a sentence regardless of capitalization** | User input: "A", "a" | 1 |
| **The program counts all words that match, that is the the last step:** |
| **Program shows the count of words** | User input: "a", "A dog, a cat" | 2 |
| **The program counts all words that match without counting punctuatoin, that is almost the most code requireble step step:** |
| **Program shows the count of words** | User input: "cat", "A cat, a CAT!" | 2 |
| **The program counts all words even if there are white spaces, that is the very last and the most code requireble step step:** |
| **Program shows the count of words** | User input: "  cat  ", "A cat, a CAT!" | 2 |

## Known Bugs

_No known bugs._

## Installation Requirements
* _Download and install .NET Core 1.1.4 SDK._
* _Download and install .NET Core Runtime 1.1.2_
* _Download and install Mono_

## Setup instructions
* _On GitHub, navigate to the main page of the repository._
* _On the right find the green button "Clone or download", click it._
* _To clone the repository in Desktop choose "Open in Desktop" or download the ZIP file._
* _For more information, see "Cloning a repository from GitHub to GitHub Desktop."_
* _Change into the work directory:: $ cd WordCounter.Solution._
* _To run the program, first navigate to the location of the WordCounter.cs file then compile and execute: $ cd WordCounter/Models $ mcs WordCounter.cs; mono WordCounter.exe._
* _To run the tests, use these commands: $ cd WordCounter.Tests $ dotnet test._

## Technologies Used

* _C#_

### License
MIT
**

Copyright (c) 2019 **_Olha Wysocky_**
