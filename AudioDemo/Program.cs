using System;
using static System.Console;
using System.Media;

namespace AudioDemo
{
    class Program
    {
        static void Main(string[] args)
        {
                //If(OperatingSystem.IsWindows()) ei töödanud
            
                SoundPlayer spookyplayer = new SoundPlayer(@"C:\Users\opilane\source\repos\TITpe21\What_in_the_F_ck_was_that_-Gaming_Sound_Effect (HD).wav");
                spookyplayer.Load();

                spookyplayer.PlayLooping();
            
            ForegroundColor = ConsoleColor.DarkBlue;
            WriteLine(@"
                                              ,           ^'^  _
                                              )               (_) ^'^
         _/\_                    .---------. ((        ^'^
         (('>                    )`'`'`'`'`( ||                 ^'^
    _    /^|                    /`'`'`'`'`'`\||           ^'^
    =>--/__|m---               /`'`'`'`'`'`'`\|
         ^^           ,,,,,,, /`'`'`'`'`'`'`'`\      ,
                     .-------.`|`````````````|`  .   )
                    / .^. .^. \|  ,^^, ,^^,  |  / \ ((
                   /  |_| |_|  \  |__| |__|  | /,-,\||
        _         /_____________\ |')| |  |  |/ |_| \|
       (')         |  __   __  |  '==' '=='  /_______\     _
      (' ')        | /  \ /  \ |   _______   |,^, ,^,|    (')
       \  \        | |--| |--| |  ((--.--))  ||_| |_||   (' ')
     _  ^^^ _      | |__| |('| |  ||  |  ||  |,-, ,-,|   /  /
   ,' ',  ,' ',    |           |  ||  |  ||  ||_| |_||   ^^^
.,,|RIP|,.|RIP|,.,,'==========='==''=='==''=='=======',,....,,,,.,ldb
== Credits ==
Music: 'Fun House' by Coyote Hearing from youtube.com/audiolibrary
Art: Haunted house by ldb from https://www.asciiart.eu/holiday-and-events/halloween
");
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("\n(Press any key to exit)");
            ReadKey();
        }
    }
}
