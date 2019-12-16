using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


namespace SweepstakeProject
{
    public class Sweepstakes
    {
        public Dictionary<int, Contestant> contestantsDictionary;
        public string name;
        public Contestant winner;

        public Random random;
        
        Sweepstakes()
        {
        }
        public Sweepstakes(string name)
        {
            this.name = name;
            contestantsDictionary = new Dictionary<int, Contestant>();
            Random random = new Random();
            
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestant.Registration_Num = contestantsDictionary.Count + 1;            //do the count first before assign registration number
            contestantsDictionary.Add(contestant.Registration_Num, contestant);
        }
        
        public string PickWinner()
        {
            Random random = new Random();
            int winnerContestant;
            winnerContestant = random.Next(contestantsDictionary.Count + 1);            // assign operator; ex. y = x+1
            winner = contestantsDictionary[winnerContestant];                           // pick value winner in dictionary same as below
                                                                                        // contestantsDictionary.TryGetValue(winnerContestant, out winner);           
            string name = "First Name: " + winner.First_Name + "   Last Name: " + winner.Last_Name + "   Registration Number: " + winner.Registration_Num;
            return name;

            //    TValue value;
            //    // attempt to get the value of the key from the dictionary
            //    dictionary.TryGetValue(key, out value);
            //    return value;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"First Name: {contestant.First_Name}");
            Console.WriteLine($"Last Name: {contestant.Last_Name}");
            Console.WriteLine($"Email: {contestant.Email_Address}");
            Console.WriteLine($"Registration Number: {contestant.Registration_Num}");
            Console.ReadLine();
        }

        public void NotifyEachContestants()
        {
            int winnerContestant;
            winnerContestant = random.Next(contestantsDictionary.Count) + 1;            // assign operator; ex. y = x+1                                                                                            // contestantsDictionary.TryGetValue(winnerContestant, out winner);            // TryGetValue to pick winner
                                                                                        //foreach (KeyValuePair<int, Contestant> pair in contestantsDictionary)
                                                                                        //{
            if (winner == contestantsDictionary[winnerContestant])
            {
                Console.WriteLine("Congratulation, you're the winner!");
            }
            else
            {
                Console.WriteLine("Sorry, you're not the winner!");
            }

        }

       public void NotifyWinnerEmail(Contestant contestant)
        {
            int winnerContestant;
            winnerContestant = random.Next(contestantsDictionary.Count) + 1;            // assign operator; ex. y = x+1
            winner = contestantsDictionary[winnerContestant];

            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("Archana karmakar", "archanakmr83@gmail.com"));
            message.To.Add(new MailboxAddress(contestant.Email_Address));
            message.Subject = "Congratulation,You're The Sweepstakes Winner 2019";
           /* message.Body = new TextPart("plain")
            {
                Text = @"Congratulation, you're the winner!"
            };*/
            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587);
                
                client.AuthenticationMechanisms.Remove("XOAUTH2");
               
                client.Authenticate("archanakmr83@gmail.com", "devCodeCamp2019");
                client.Send(message);
                client.Disconnect(true);
            }
            Console.WriteLine("MessageSent");
        }
    }
}


