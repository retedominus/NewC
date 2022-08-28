// Мктод печати в определенном месте экрана
void DrawText(string text, int left, int top)
{
    Console.SetCursorPosition(left, top);
    System.Console.WriteLine(text);
}
string caption = "Intensive C# Demo Text";
int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2;
int screenHeightPosition = Console.WindowHeight / 2;

DrawText(
    text: caption,
    left: screenWidthPosition,
    top: screenHeightPosition
);