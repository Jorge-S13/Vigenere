# Vigenere Cipher

## Description
The Vigenère cipher is a polyalphabetic encryption method that uses a keyword to encrypt the text

## Example:
>**Message:** HELLO
>>**Key:** KEY (repeated up to the length of the message: KEYKE)
>
>> **Encryption:**
>
>> - H + K (shift by 10) → R
>> - E + E (shift by 4) → I
>> - L + Y (shift by 24) → J
>> - L + K (shift by 10) → V
>> - O + E (shift 4) → S
>
>> **Encrypted message: RIJVS**

## Requirements
Before installing, make sure you have the following installed on your computer:
- .NET SDK (.NET 8.0)
- Git

## Installation
### Cloning a repository
First, clone the repository to your local computer:
```bash
git clone https://github.com/Jorge-S13/Vigenere.git
```

## Usage
### Go to the project directory:
```bash
cd repository-name
```
### Building a project
To build a project, run the following command:
```bash
dotnet build
```

## Launching the application
To launch the application, execute: 
```bash
dotnet run apple
```
The dotnet run command must be followed by a command line argument.\
This is your cipher key. In the example above, the key is **“apple”**