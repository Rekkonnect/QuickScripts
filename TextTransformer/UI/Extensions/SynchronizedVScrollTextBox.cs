namespace TextTransformer.UI.Extensions;

public delegate void VScrollEventHandler(TextBox sender, ref WinFormsMessage message);

// In hopes of this ever working
public partial class SynchronizedVScrollTextBox : TextBox
{
    public event VScrollEventHandler VScroll;

    public void SynchronizeVScrollWith(SynchronizedVScrollTextBox otherTextBox)
    {
        otherTextBox.VScroll += Accept;
        VScroll += otherTextBox.Accept;
    }
    public void UnsynchronizeVScrollFrom(SynchronizedVScrollTextBox otherTextBox)
    {
        otherTextBox.VScroll -= Accept;
        VScroll -= otherTextBox.Accept;
    }

    private void Accept(TextBox sender, ref WinFormsMessage message)
    {
        if (Lines.Length == sender.Lines.Length)
        {
            PubWndProc(ref message);
        }
    }

    protected override void WndProc(ref WinFormsMessage msg)
    {
        if (msg.Msg is WindowsFormsMessageHandles.WM_MOUSEWHEEL)
        {
            VScroll?.Invoke(this, ref msg);
        }
        base.WndProc(ref msg);
    }

    public void PubWndProc(ref WinFormsMessage msg)
    {
        base.WndProc(ref msg);
    }
}
