public class Prompt
{
  public static ConsoleColor foregroundColor = ConsoleColor.Blue;
  public static string mainMenuTitle = "Zelda Database";
  public static string consoleLabel = "Zelda Database";
  public Prompt()
  {
    Console.Title = consoleLabel;
  }

  public void ShowMenu()
  {
    Console.WriteLine(mainMenuTitle);
    Console.ReadLine();
  }
}
