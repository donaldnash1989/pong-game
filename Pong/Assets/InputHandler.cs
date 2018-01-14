using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public void Notify(float amount)
    {
        foreach(IInputListener listener in listeners)
        {
            //Notify listeners of input
            listener.mouseDeltaYChanged(amount);
        }
    }


}
