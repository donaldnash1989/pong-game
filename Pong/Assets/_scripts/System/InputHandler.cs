using System.Collections.Generic;

public class InputHandler {

    private static InputHandler instance;

    private List<IInputListener> listeners = new List<IInputListener>();

    private InputHandler() { }

    public static InputHandler GetInstance()
    {
        if (instance == null) instance = new InputHandler();
        return instance;
    }

    public void Register(IInputListener listener)
    {
        listeners.Add(listener);
    }

    public void Unregister(IInputListener listener)
    {
        listeners.Remove(listener);
    }

    public void NotifyMouseMove(float amount)
    {
        foreach(IInputListener listener in listeners)
        {
            //Notify listeners of mouse input
            listener.mouseDeltaYChanged(amount);
        }
    }

    public void NotifyCtrlPressed()
    {
        foreach (IInputListener listener in listeners)
        {
            //Notify listeners of key input
            listener.CtrlPressed();
        }
    }
}
