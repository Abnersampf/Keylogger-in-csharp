# Keylogger-in-csharp
This is my first successful attempt at making a keylogger. It's simple but it works!

<br>

<div>
    <img src="https://github.com/Abnersampf/Keylogger-in-csharp/assets/58574013/02a94cc5-15af-43f3-8866-fed9acdeb967" width="500px"/>
</div>

<br>

- PROGRAM DETAILS:
  - Can detect 254 different keys (mouse/keyboard);
    
  - Of these 254, only 31 do not have a representation (due to my laziness) and are therefore represented by a hexadecimal value, the meaning of which can be found at the following link: https://learn.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes.
    
  - Of the 223 keys registered in the program, 208 are part of the ConsoleKey Enum. And even though they are represented, some of the keys are difficult to understand. For example:
    - "D0" is the representation of the 0 key;
    - "D1" is the representation of the 1 key;
    - "NumPad1" is the representation of the 1 key on the numeric keypad;
    - "NumPad2" is the representation of the 2 key on the numeric keypad;
    - "OemComma" is the representation of the "," key;
    - To understand the meaning/representation of these words, go to the following link: https://learn.microsoft.com/en-us/dotnet/api/system.consolekey?view=net-7.0.
      
  - By default the console (application window) is visible, you can change this by following some tips below;
    
  - The log (Keylogger.txt) is automatically generated in the same folder as the executable. There is therefore no need to create a file to store the data. If you move the file (.txt), the program will create another (blank file) in the same location as the executable.

<br>

- IMPORTANT:
  - Use .NET 7.0 (dotnet 7.0);
  - The program does NOT work with online compilers;
  - I do not recommend testing the program in the terminal of your IDE/text editor, compile the program and run the executable file!

<br>

- IMAGES OF THE PROGRAM RUNNING:
  - Entering a password.
    
   <br>
   
  <div>
    <img src="https://github.com/Abnersampf/Keylogger-in-csharp/assets/58574013/dd6f08b5-bc7c-41b7-9333-e497cc8e3ea6" width="800px"/>
  </div>

  <br>

  - Accessing a website.
    
    <br>
  <div>
    <img src="https://github.com/Abnersampf/Keylogger-in-csharp/assets/58574013/8cca9f71-9f17-45b4-b92c-710558cc815d" width="800px"/>
  </div>

- (TIP) IF YOU WANT TO HIDE THE CONSOLE WINDOW, FOLLOW THE STEPS BELOW:
  - Go to solution explorer, then right-click on your project.
    
    <div>
      <img src="https://github.com/Abnersampf/Keylogger-in-csharp/assets/58574013/d15a8b52-2012-4ea7-8d73-ed8df18206d7" width="335px"/>
    </div>

  - A list of options will appear, look for properties and click on it.

    <div>
      <img src="https://github.com/Abnersampf/Keylogger-in-csharp/assets/58574013/bd3fcd8b-0dbf-43e6-9f1c-bc91c8cd3e13" width="335px"/>
    </div>

  - A new window will appear on your right, go to Application > General > Output type.
 
    <div>
      <img src="https://github.com/Abnersampf/Keylogger-in-csharp/assets/58574013/b96fcccb-0bbc-423c-bbea-86a19b7f6afd" width="770px"/>
    </div>

  - Choose the Windows Application option. That's it!
 
    <div>
      <img src="https://github.com/Abnersampf/Keylogger-in-csharp/assets/58574013/3041fb07-9d1a-45f1-b270-2596c62e3d6f" width="770px"/>
    </div>

  - (OPTIONAL) You can comment out/delete line 49 if you want, as it only allows you to see the keys that are being pressed when the console window is visible.
 
    <div>
      <img src="https://github.com/Abnersampf/Keylogger-in-csharp/assets/58574013/aae22c32-358a-4373-9f61-d8117457685d" width="770px"/>
    </div>
