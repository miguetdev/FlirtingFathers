using System.Collections.Generic;
using UnityEngine;

namespace MiguetDev.EventSystems
{
  public class CoreEvent : ScriptableObject
  {
    /// <summary>
    /// The list of listeners that this event will notify if it is raised.
    /// </summary>
    private readonly List<CoreEventListener> eventListeners =
        new List<CoreEventListener>( );

    public void Raise()
    {
      for ( int i = eventListeners.Count - 1 ; i >= 0 ; i-- )
        eventListeners[ i ].OnEventRaised( );
    }

    public void RegisterListener( CoreEventListener listener )
    {
      if ( !eventListeners.Contains( listener ) )
        eventListeners.Add( listener );
    }

    public void UnregisterListener( CoreEventListener listener )
    {
      if ( eventListeners.Contains( listener ) )
        eventListeners.Remove( listener );
    }
  }
}

