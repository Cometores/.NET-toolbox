namespace StatusBar;

/// <summary>
/// Represents a status bar for displaying the progress.
/// </summary>
public class StatusBar
{
    private static readonly string[] WheelSymbols = { "―", "\\", "|", "/" };
    private readonly ConsoleColor _color;
    private readonly int _consoleTopPos;
    
    private readonly object _lockCounting = new();
    private readonly CancellationTokenSource _cancellationTokenSource;
    private readonly CancellationToken _cancellationToken;
    
    private readonly int _tasksAmount;
    private int _tasksFinished;

    /// <summary>
    /// Creates status bar
    /// </summary>
    /// <param name="tasksAmount">Represents status bar length</param>
    /// <param name="color">Bar's color</param>
    public StatusBar(int tasksAmount, ConsoleColor color = ConsoleColor.Cyan)
    {
        _tasksFinished = 0;
        _tasksAmount = tasksAmount;
        _color = color;
        _consoleTopPos = Console.CursorTop;
        
        // Initial status bar
        ConsoleMT.WriteLine($"[{new string('-', tasksAmount)}]");
        
        // Start loading wheel
        _cancellationTokenSource = new CancellationTokenSource();
        _cancellationToken = _cancellationTokenSource.Token;
        
        Task.Factory.StartNew(DrawLoadingWheel, _cancellationToken);
    }

    /// <summary>
    /// Increments the tasks finished count and updates the status bar progress.
    /// </summary>
    /// <remarks>
    /// This method is used to simulate the completion of a task and update the visual progress
    /// on the status bar.
    /// </remarks>
    public void Add()
    {
        lock (_lockCounting)
        {
            _tasksFinished += 1;
            PrintBar(_tasksFinished);
            if (_tasksFinished == _tasksAmount)
                _cancellationTokenSource.Cancel();
        }
    }
    
    private void PrintBar(int leftPosition)
    {
        ConsoleMT.WriteAtPos("_", leftPosition, _consoleTopPos, _color);
    }
    
    private void DrawLoadingWheel()
    {
        int i = 0;
        
        try
        {
            while (!_cancellationToken.IsCancellationRequested)
            {
                ConsoleMT.WriteAtPos(WheelSymbols[i], _tasksAmount + 2, _consoleTopPos);
            
                Task.Delay(200, _cancellationToken).Wait(_cancellationToken);
                i = (i + 1) % WheelSymbols.Length;
            }
        }
        catch (OperationCanceledException)
        {
            ConsoleMT.WriteAtPos(" ", _tasksAmount + 2, _consoleTopPos);
        }
    }
}