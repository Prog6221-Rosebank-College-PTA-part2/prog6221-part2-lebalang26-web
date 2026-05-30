using System;
using System.Media;

namespace ChatBot_GUI
{
    public static class Assets
    {
        public static string GetAsciiArt()
        {
            return @"
   _____      _                                        _ _                                                             
  / ____|    | |                                      (_) |             
 | |    _   _| |__   ___ _ __ ___  ___  ___ _   _ _ __ _| |_ _   _     
 | |   | | | | '_ \ / _ \ '__/ __|/ _ \/ __| | | | '__| | __| | | |   
 | |___| |_| | |_) |  __/ |  \__ \  __/ (__| |_| | |  | | |_| |_| |  
  \_____\__, |_.__/ \___|_|  |___/\___|\___|\__,_|_|  |_|\__|\__, | 
         __/ |                                                __/ |                                                                     
        |___/                                                |___/                                                                                                    

                                                    
      /\                                            
     /  \__      ____ _ _ __ ___ _ __   ___ ___ ___ 
    / /\ \ \ /\ / / _` | '__/ _ \ '_ \ / _ Y __/ __|
   / ____ \ V  V / (_| | | |  __/ | | |  __|__ \__ \
  /_/    \_\_/\_/ \__,_|_|  \___|_| |_|\___|___/___/
                                                    
                                                    

   _           _   
  | |         | |  
  | |__   ___ | |_ 
  | '_ \ / _ \| __|
  | |_) | (_) | |_ 
  |_.__/ \___/ \__|
                   
                   


";
        }

        public static void PlayGreeting()
        {
            try
            {
                SoundPlayer player =new SoundPlayer("C:\\Users\\lebal\\source\\repos\\StructureBot\\Structure\\welcome.wav");

                player.Play();
                SystemSounds.Asterisk.Play();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Sound Error: " + ex.Message);
            }
        }
    }
}