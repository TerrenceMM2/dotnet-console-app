public class Prompt
{
  public static ConsoleColor foregroundColor = ConsoleColor.Green;
  public static string mainMenuTitle = "Zelda Database";
  public static string consoleLabel = "Zelda Database";
  public Prompt()
  {
    Console.Title = consoleLabel;
    Console.ForegroundColor = foregroundColor;
  }

  public void ShowMenu()
  {
    Console.WriteLine(mainMenuTitle);
    Console.ReadLine();
  }
}
