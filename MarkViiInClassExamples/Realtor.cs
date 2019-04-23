using System;
using System.Collections.Generic;
using System.Text;

namespace MarkViiInClassExamples
{
    class Realtor
    {
        public void WelcomeVisitor(Visitor visitor)
        {
            Speak("Welcome to this open house!");
            visitor.Name = GetAnswerFromVisitor("What is your name?");
            Speak($"Hello, {visitor.Name}, it's nice to meet you!");
        }

        public void Speak(string message)
        {
            Console.WriteLine(message);
        }

        public string GetAnswerFromVisitor(string question)
        {
            Speak(question);
            return Console.ReadLine();
        }

        public void ShowRoom(Room roomToShow)
        {
            string response = GetAnswerFromVisitor($"Would you like to see the {roomToShow.Name}?");

            if (response.ToUpper() == "YES" || response.ToUpper() == "Y")
            {
                Speak($"This is the {roomToShow.Name}.");
                Speak($"It has {roomToShow.NumberOfWindows} window(s).");
                Speak(roomToShow.Description);
            }
            else
            {
                Speak($"Ok, we won't look at the {roomToShow.Name} right now.");
            }
        }
    }
}
