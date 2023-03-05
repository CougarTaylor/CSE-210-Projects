using System;

public class Animation
{
    private bool _cursorVisibility;

    public virtual void RunAnimation(int timer)
    {
        CursorDisappearance();
    }

    protected void CursorDisappearance()
    {
        Console.CursorVisible = false;
    }
    protected void CursorAppearance()
    {
        Console.CursorVisible = true;
    }
}
