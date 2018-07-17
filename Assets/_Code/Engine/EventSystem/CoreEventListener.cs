using UnityEngine;
using UnityEngine.Events;

namespace MiguetDev.EventSystems
{
  public class CoreEventListener : MonoBehaviour
  {
    [Tooltip( "Event to register with." )]
    public CoreEvent Event;

    [Tooltip( "Response to invoke when Event is raised." )]
    public UnityEvent Response;

    private void OnEnable()
    { Event.RegisterListener( this ); }

    private void OnDisable()
    { Event.UnregisterListener( this ); }

    public void OnEventRaised()
    { Response.Invoke( ); }
  }
}
