DateTime dateTime = DateTime.Now;
Console.WriteLine("Welcome to the Countdowner! Developer is a normal man so write the date as a DD.MM.YYYY");
Console.WriteLine("Write the date that you are waiting for: ");
string date = Console.ReadLine();
DateTime dateToCountdown = DateTime.ParseExact(date, "dd.MM.yyyy", null);

while (true)
{
    dateTime = DateTime.Now; // Reuse the existing 'dateTime' variable
    TimeSpan timeLeft = dateToCountdown - dateTime;
    Console.WriteLine($"Time left: {timeLeft.Days} days, {timeLeft.Hours} hours, {timeLeft.Minutes} minutes, {timeLeft.Seconds} seconds");
    System.Threading.Thread.Sleep(1000);
    Console.Clear();
}
